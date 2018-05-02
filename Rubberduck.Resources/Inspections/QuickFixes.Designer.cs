﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Rubberduck.Resources.Inspections {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class QuickFixes {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal QuickFixes() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Rubberduck.Resources.Inspections.QuickFixes", typeof(QuickFixes).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Refer to statically accessible sheet by its code name.
        /// </summary>
        public static string AccessSheetUsingCodeNameQuickFix {
            get {
                return ResourceManager.GetString("AccessSheetUsingCodeNameQuickFix", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Add explicit &apos;Step&apos; clause.
        /// </summary>
        public static string AddStepOneQuickFix {
            get {
                return ResourceManager.GetString("AddStepOneQuickFix", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Use Application.WorksheetFunction explicitly..
        /// </summary>
        public static string ApplicationWorksheetFunctionQuickFix {
            get {
                return ResourceManager.GetString("ApplicationWorksheetFunctionQuickFix", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Create and use a local copy of the parameter.
        /// </summary>
        public static string AssignedByValParameterMakeLocalCopyQuickFix {
            get {
                return ResourceManager.GetString("AssignedByValParameterMakeLocalCopyQuickFix", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Replace &apos;Dim&apos; with &apos;Private&apos;.
        /// </summary>
        public static string ChangeDimToPrivateQuickFix {
            get {
                return ResourceManager.GetString("ChangeDimToPrivateQuickFix", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Convert function to procedure.
        /// </summary>
        public static string ConvertFunctionToProcedureQuickFix {
            get {
                return ResourceManager.GetString("ConvertFunctionToProcedureQuickFix", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Declare as explicit Variant.
        /// </summary>
        public static string DeclareAsExplicitVariantQuickFix {
            get {
                return ResourceManager.GetString("DeclareAsExplicitVariantQuickFix", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Replace empty string with the &apos;vbNullString&apos; constant.
        /// </summary>
        public static string EmptyStringLiteralInspectionQuickFix {
            get {
                return ResourceManager.GetString("EmptyStringLiteralInspectionQuickFix", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Encapsulate field &apos;{0}&apos; with a property.
        /// </summary>
        public static string EncapsulatePublicFieldInspectionQuickFix {
            get {
                return ResourceManager.GetString("EncapsulatePublicFieldInspectionQuickFix", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Ignore once.
        /// </summary>
        public static string IgnoreOnce {
            get {
                return ResourceManager.GetString("IgnoreOnce", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Pass parameter by reference explicitly.
        /// </summary>
        public static string ImplicitByRefModifierQuickFix {
            get {
                return ResourceManager.GetString("ImplicitByRefModifierQuickFix", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Change type to &apos;Long&apos;.
        /// </summary>
        public static string IntegerDataTypeQuickFix {
            get {
                return ResourceManager.GetString("IntegerDataTypeQuickFix", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Introduce local variable.
        /// </summary>
        public static string IntroduceLocalVariableQuickFix {
            get {
                return ResourceManager.GetString("IntroduceLocalVariableQuickFix", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Context type &apos;{0}&apos; is not valid for {1}..
        /// </summary>
        public static string InvalidContextTypeInspectionFix {
            get {
                return ResourceManager.GetString("InvalidContextTypeInspectionFix", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Write variable on one line.
        /// </summary>
        public static string MakeSingleLineParameterQuickFix {
            get {
                return ResourceManager.GetString("MakeSingleLineParameterQuickFix", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Replace &apos;Global&apos; access modifier with &apos;Public&apos;.
        /// </summary>
        public static string ObsoleteGlobalInspectionQuickFix {
            get {
                return ResourceManager.GetString("ObsoleteGlobalInspectionQuickFix", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Specify &apos;Option Explicit&apos;.
        /// </summary>
        public static string OptionExplicitQuickFix {
            get {
                return ResourceManager.GetString("OptionExplicitQuickFix", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Pass parameter by reference.
        /// </summary>
        public static string PassParameterByReferenceQuickFix {
            get {
                return ResourceManager.GetString("PassParameterByReferenceQuickFix", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Pass parameter by value.
        /// </summary>
        public static string PassParameterByValueQuickFix {
            get {
                return ResourceManager.GetString("PassParameterByValueQuickFix", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Implement as function and update usages..
        /// </summary>
        public static string ProcedureShouldBeFunctionInspectionQuickFix {
            get {
                return ResourceManager.GetString("ProcedureShouldBeFunctionInspectionQuickFix", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Change &apos;{0}&apos; to &apos;{1}&apos;.
        /// </summary>
        public static string QuickFixUseTypedFunction_ {
            get {
                return ResourceManager.GetString("QuickFixUseTypedFunction_", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Remove &apos;ByRef&apos; modifier.
        /// </summary>
        public static string RedundantByRefModifierQuickFix {
            get {
                return ResourceManager.GetString("RedundantByRefModifierQuickFix", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Remove comment.
        /// </summary>
        public static string RemoveCommentQuickFix {
            get {
                return ResourceManager.GetString("RemoveCommentQuickFix", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Remove empty &apos;Else&apos; block.
        /// </summary>
        public static string RemoveEmptyElseBlockQuickFix {
            get {
                return ResourceManager.GetString("RemoveEmptyElseBlockQuickFix", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Remove empty If block.
        /// </summary>
        public static string RemoveEmptyIfBlockQuickFix {
            get {
                return ResourceManager.GetString("RemoveEmptyIfBlockQuickFix", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Remove obsolete statement.
        /// </summary>
        public static string RemoveObsoleteStatementQuickFix {
            get {
                return ResourceManager.GetString("RemoveObsoleteStatementQuickFix", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Remove &apos;Option Base&apos; statement.
        /// </summary>
        public static string RemoveOptionBaseStatementQuickFix {
            get {
                return ResourceManager.GetString("RemoveOptionBaseStatementQuickFix", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Remove redundant &apos;Step&apos; clause.
        /// </summary>
        public static string RemoveStepOneQuickFix {
            get {
                return ResourceManager.GetString("RemoveStepOneQuickFix", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Remove usage of the &apos;Stop&apos; keyword.
        /// </summary>
        public static string RemoveStopKeywordQuickFix {
            get {
                return ResourceManager.GetString("RemoveStopKeywordQuickFix", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Remove type hints.
        /// </summary>
        public static string RemoveTypeHintsQuickFix {
            get {
                return ResourceManager.GetString("RemoveTypeHintsQuickFix", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Remove unassigned variable.
        /// </summary>
        public static string RemoveUnassignedIdentifierQuickFix {
            get {
                return ResourceManager.GetString("RemoveUnassignedIdentifierQuickFix", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Remove usage (breaks code).
        /// </summary>
        public static string RemoveUnassignedVariableUsageQuickFix {
            get {
                return ResourceManager.GetString("RemoveUnassignedVariableUsageQuickFix", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Remove unused declaration.
        /// </summary>
        public static string RemoveUnusedDeclarationQuickFix {
            get {
                return ResourceManager.GetString("RemoveUnusedDeclarationQuickFix", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Remove unused parameter.
        /// </summary>
        public static string RemoveUnusedParameterQuickFix {
            get {
                return ResourceManager.GetString("RemoveUnusedParameterQuickFix", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Replace &apos;Rem&apos; usage with a single-quote comment marker.
        /// </summary>
        public static string ReplaceCommentMarkerQuickFix {
            get {
                return ResourceManager.GetString("ReplaceCommentMarkerQuickFix", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Replace If/Else with single assignment.
        /// </summary>
        public static string ReplaceIfElseWithConditionalStatementQuickFix {
            get {
                return ResourceManager.GetString("ReplaceIfElseWithConditionalStatementQuickFix", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Replace &apos;Error&apos; with &apos;Err.Raise&apos;.
        /// </summary>
        public static string ReplaceObsoleteErrorStatementQuickFix {
            get {
                return ResourceManager.GetString("ReplaceObsoleteErrorStatementQuickFix", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Return explicit Variant.
        /// </summary>
        public static string SetExplicitVariantReturnTypeQuickFix {
            get {
                return ResourceManager.GetString("SetExplicitVariantReturnTypeQuickFix", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Use &apos;Set&apos; keyword.
        /// </summary>
        public static string SetObjectVariableQuickFix {
            get {
                return ResourceManager.GetString("SetObjectVariableQuickFix", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Specify Public access modifier explicitly.
        /// </summary>
        public static string SpecifyExplicitPublicModifierQuickFix {
            get {
                return ResourceManager.GetString("SpecifyExplicitPublicModifierQuickFix", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Separate multiple declarations into multiple instructions.
        /// </summary>
        public static string SplitMultipleDeclarationsQuickFix {
            get {
                return ResourceManager.GetString("SplitMultipleDeclarationsQuickFix", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Synchronize attributes/annotations in module.
        /// </summary>
        public static string SynchronizeAttributesQuickFix {
            get {
                return ResourceManager.GetString("SynchronizeAttributesQuickFix", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Introduce error handling subroutine.
        /// </summary>
        public static string UnhandledOnErrorResumeNextInspectionQuickFix {
            get {
                return ResourceManager.GetString("UnhandledOnErrorResumeNextInspectionQuickFix", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Add to whitelist.
        /// </summary>
        public static string WhiteListIdentifierQuickFix {
            get {
                return ResourceManager.GetString("WhiteListIdentifierQuickFix", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Add property get accessor.
        /// </summary>
        public static string WriteOnlyPropertyQuickFix {
            get {
                return ResourceManager.GetString("WriteOnlyPropertyQuickFix", resourceCulture);
            }
        }
    }
}
