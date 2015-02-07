﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Vbe.Interop;
using Rubberduck.Extensions;
using Rubberduck.Inspections;
using Rubberduck.VBA;
using Rubberduck.VBA.Nodes;

namespace Rubberduck.UI.CodeInspections
{
    [ComVisible(false)]
    public class CodeInspectionsDockablePresenter : DockablePresenterBase
    {
        private readonly IRubberduckParser _parser;
        private CodeInspectionsWindow Control { get { return UserControl as CodeInspectionsWindow; } }

        private readonly IList<IInspection> _inspections;
        private List<CodeInspectionResultBase> _results;

        public CodeInspectionsDockablePresenter(IRubberduckParser parser, IEnumerable<IInspection> inspections, VBE vbe, AddIn addin, CodeInspectionsWindow window) 
            : base(vbe, addin, window)
        {
            _parser = parser;
            _inspections = inspections.ToList();

            Control.RefreshCodeInspections += OnRefreshCodeInspections;
            Control.NavigateCodeIssue += OnNavigateCodeIssue;
            Control.QuickFix += OnQuickFix;
        }

        private void OnQuickFix(object sender, QuickFixEventArgs e)
        {
            e.QuickFix(VBE);
            OnRefreshCodeInspections(null, EventArgs.Empty);
            Control.FindNextIssue();
        }

        public override void Show()
        {
            if (VBE.ActiveVBProject != null)
            {
                OnRefreshCodeInspections(this, EventArgs.Empty);
            }
            base.Show();
        }

        private void OnNavigateCodeIssue(object sender, NavigateCodeEventArgs e)
        {
            try
            {
                var location = VBE.FindInstruction(e.QualifiedName, e.Context);
                location.CodeModule.CodePane.SetSelection(location.Selection);

                var codePane = location.CodeModule.CodePane;
                var selection = location.Selection;
                codePane.SetSelection(selection);
            }
            catch (Exception exception)
            {
                System.Diagnostics.Debug.Assert(false, exception.ToString());
            }
        }

        private void OnRefreshCodeInspections(object sender, EventArgs e)
        {
            var code = _parser.Parse(VBE.ActiveVBProject).ToList();

            _results = new List<CodeInspectionResultBase>();
            foreach (var inspection in _inspections.Where(inspection => inspection.Severity != CodeInspectionSeverity.DoNotShow))
            {
                var result = inspection.GetInspectionResults(code).ToArray();
                if (result.Length != 0)
                {
                    _results.AddRange(result);
                }
            }

            Control.SetContent(_results.Select(item => new CodeInspectionResultGridViewItem(item)).OrderBy(item => item.Component).ThenBy(item => item.Line));
        }
    }
}
