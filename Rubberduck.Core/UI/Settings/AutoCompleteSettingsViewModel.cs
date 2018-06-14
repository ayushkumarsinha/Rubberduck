﻿using NLog;
using Rubberduck.Resources;
using Rubberduck.Settings;
using Rubberduck.SettingsProvider;
using Rubberduck.UI.Command;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Rubberduck.UI.Settings
{
    public class AutoCompleteSettingsViewModel : SettingsViewModelBase, ISettingsViewModel
    {
        public AutoCompleteSettingsViewModel(Configuration config)
        {
            Settings = new ObservableCollection<AutoCompleteSetting>(config.UserSettings.AutoCompleteSettings.AutoCompletes);
            CompleteBlockOnEnter = config.UserSettings.AutoCompleteSettings.CompleteBlockOnEnter;
            CompleteBlockOnTab = config.UserSettings.AutoCompleteSettings.CompleteBlockOnTab;

            ExportButtonCommand = new DelegateCommand(LogManager.GetCurrentClassLogger(), _ => ExportSettings());
            ImportButtonCommand = new DelegateCommand(LogManager.GetCurrentClassLogger(), _ => ImportSettings());
        }

        private ObservableCollection<AutoCompleteSetting> _settings;
        public ObservableCollection<AutoCompleteSetting> Settings
        {
            get { return _settings; }
            set
            {
                if (_settings != value)
                {
                    _settings = value;
                    OnPropertyChanged();
                    SelectAll = _settings.All(e => e.IsEnabled) || _settings.Any(e => e.IsEnabled) ? (bool?)null : true;
                }
            }
        }

        public void SetToDefaults(Configuration config)
        {
            TransferSettingsToView(config.UserSettings.AutoCompleteSettings);
        }

        public void UpdateConfig(Configuration config)
        {
            config.UserSettings.AutoCompleteSettings.CompleteBlockOnTab = CompleteBlockOnTab;
            config.UserSettings.AutoCompleteSettings.CompleteBlockOnEnter = CompleteBlockOnEnter;
            config.UserSettings.AutoCompleteSettings.AutoCompletes = new HashSet<AutoCompleteSetting>(_settings);
        }

        private void TransferSettingsToView(Rubberduck.Settings.AutoCompleteSettings toLoad)
        {
            CompleteBlockOnTab = toLoad.CompleteBlockOnTab;
            CompleteBlockOnEnter = toLoad.CompleteBlockOnEnter;
            Settings = new ObservableCollection<AutoCompleteSetting>(toLoad.AutoCompletes);
        }

        private bool _completeBlockOnTab;
        public bool CompleteBlockOnTab
        {
            get { return _completeBlockOnTab; }
            set
            {
                if (_completeBlockOnTab != value)
                {
                    _completeBlockOnTab = value;
                    OnPropertyChanged();
                    if (!_completeBlockOnTab && !_completeBlockOnEnter)
                    {
                        // one must be enabled...
                        CompleteBlockOnEnter = true;
                    }
                }
            }
        }
        
        private bool _completeBlockOnEnter;
        public bool CompleteBlockOnEnter
        {
            get { return _completeBlockOnEnter; }
            set
            {
                if (_completeBlockOnEnter != value)
                {
                    _completeBlockOnEnter = value;
                    OnPropertyChanged();
                    if (!_completeBlockOnTab && !_completeBlockOnEnter)
                    {
                        // one must be enabled...
                        CompleteBlockOnTab = true;
                    }
                }
            }
        }

        private bool? _selectAll;
        public bool? SelectAll
        {
            get
            {
                return _selectAll;
            }
            set
            {
                if (_selectAll != value)
                {
                    _selectAll = value;
                    foreach (var setting in Settings)
                    {
                        setting.IsEnabled = value.Value;
                    }
                    OnPropertyChanged();
                }
            }
        }

        private void ImportSettings()
        {
            using (var dialog = new OpenFileDialog
            {
                Filter = RubberduckUI.DialogMask_XmlFilesOnly,
                Title = RubberduckUI.DialogCaption_LoadInspectionSettings
            })
            {
                dialog.ShowDialog();
                if (string.IsNullOrEmpty(dialog.FileName)) return;
                var service = new XmlPersistanceService<Rubberduck.Settings.AutoCompleteSettings> { FilePath = dialog.FileName };
                var loaded = service.Load(new Rubberduck.Settings.AutoCompleteSettings());
                TransferSettingsToView(loaded);
            }
        }

        private void ExportSettings()
        {
            using (var dialog = new SaveFileDialog
            {
                Filter = RubberduckUI.DialogMask_XmlFilesOnly,
                Title = RubberduckUI.DialogCaption_SaveInspectionSettings
            })
            {
                dialog.ShowDialog();
                if (string.IsNullOrEmpty(dialog.FileName)) return;
                var service = new XmlPersistanceService<Rubberduck.Settings.AutoCompleteSettings> { FilePath = dialog.FileName };
                service.Save(new Rubberduck.Settings.AutoCompleteSettings
                {
                    CompleteBlockOnTab = this.CompleteBlockOnTab,
                    AutoCompletes = new HashSet<AutoCompleteSetting>(Settings),
                });
            }
        }
    }
}
