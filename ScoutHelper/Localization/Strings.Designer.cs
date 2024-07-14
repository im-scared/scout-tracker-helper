﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ScoutHelper.Localization {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Strings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Strings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("ScoutHelper.Localization.Strings", typeof(Strings).Assembly);
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
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Bear Toolkit.
        /// </summary>
        internal static string BearButton {
            get {
                return ResourceManager.GetString("BearButton", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to generate a Bear Toolkit link from the Hunt Helper train recorder..
        /// </summary>
        internal static string BearButtonTooltip {
            get {
                return ResourceManager.GetString("BearButtonTooltip", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to DESCRIPTION:.
        /// </summary>
        internal static string ConfigWindowDescriptionLabel {
            get {
                return ResourceManager.GetString("ConfigWindowDescriptionLabel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to PREVIEW:.
        /// </summary>
        internal static string ConfigWindowPreviewLabel {
            get {
                return ResourceManager.GetString("ConfigWindowPreviewLabel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to FULL-TEXT TEMPLATE.
        /// </summary>
        internal static string ConfigWindowSectionLabelFullText {
            get {
                return ResourceManager.GetString("ConfigWindowSectionLabelFullText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Configure the template used by the full-text copy mode. When the full-text mode is selected, this template is what will be copied to your clipboard, rather than just the generated tracker link. Variables can be referenced by surrounding them with curly braces (e.g. &quot;{link}&quot;), and the following variables are available:.
        /// </summary>
        internal static string ConfigWindowTemplateDesc {
            get {
                return ResourceManager.GetString("ConfigWindowTemplateDesc", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to RESET.
        /// </summary>
        internal static string ConfigWindowTemplateResetButton {
            get {
                return ResourceManager.GetString("ConfigWindowTemplateResetButton", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to sets the full-text template back to the default value.
        /// </summary>
        internal static string ConfigWindowTemplateResetTooltip {
            get {
                return ResourceManager.GetString("ConfigWindowTemplateResetTooltip", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {#} - the number of hunt marks in the train.
        ///
        ///{#max} - the maximum possible number of hunt marks in the patch.
        ///
        ///{link} - the generated tracker link \(≧▽≦)/
        ///
        ///{patch} - the name for the latest patch contained in the recorded train. If there are 6 HW marks and 1 SHB mark in the train, the patch will be SHB.
        ///
        ///{patch-emote} - the discord emote for the latest patch contained in the recorded train. If there are 6 HW marks and 1 SHB mark in the train, the patch-emote will be &quot;:5x:&quot;.
        ///
        ///{tracker} - the name  [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string ConfigWindowTemplateVariables {
            get {
                return ResourceManager.GetString("ConfigWindowTemplateVariables", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SCOUT HELPER SETTINGS.
        /// </summary>
        internal static string ConfigWindowTitle {
            get {
                return ResourceManager.GetString("ConfigWindowTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to configure how many instances there are for each map. this allows users to set the number of instances to the correct values after a new patch change and before scout helper updates with the new values..
        /// </summary>
        internal static string ConfigWindowTweaksInstanceDescription {
            get {
                return ResourceManager.GetString("ConfigWindowTweaksInstanceDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to NOTE: once scout helper deploys a new update with the latest patch instance values, any customizations you made here will be reset automatically..
        /// </summary>
        internal static string ConfigWindowTweaksInstanceDescriptionNote {
            get {
                return ResourceManager.GetString("ConfigWindowTweaksInstanceDescriptionNote", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to RESET.
        /// </summary>
        internal static string ConfigWindowTweaksInstanceResetButton {
            get {
                return ResourceManager.GetString("ConfigWindowTweaksInstanceResetButton", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to reset all configured instances to the current patch defaults..
        /// </summary>
        internal static string ConfigWindowTweaksInstanceResetTooltip {
            get {
                return ResourceManager.GetString("ConfigWindowTweaksInstanceResetTooltip", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to INSTANCES.
        /// </summary>
        internal static string ConfigWindowTweaksSectionLabelInstances {
            get {
                return ResourceManager.GetString("ConfigWindowTweaksSectionLabelInstances", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to full-text.
        /// </summary>
        internal static string CopyModeFullTextButton {
            get {
                return ResourceManager.GetString("CopyModeFullTextButton", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to link.
        /// </summary>
        internal static string CopyModeLinkButton {
            get {
                return ResourceManager.GetString("CopyModeLinkButton", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to copies a full-text template to your clipboard, which can contain data about the scouted marks beyond just the tracker link. click on the &apos;?&apos; currently underneath your mouse, to open the SCOUT HELPER settings and configure the template, or open the settings from the Dalamud plugin installer screen..
        /// </summary>
        internal static string CopyModeTooltipFullTextDesc {
            get {
                return ResourceManager.GetString("CopyModeTooltipFullTextDesc", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to only copies the generated tracker link to your clipboard.
        /// </summary>
        internal static string CopyModeTooltipLinkDesc {
            get {
                return ResourceManager.GetString("CopyModeTooltipLinkDesc", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to the copy mode that tracker generators will use when generating tracker links..
        /// </summary>
        internal static string CopyModeTooltipSummary {
            get {
                return ResourceManager.GetString("CopyModeTooltipSummary", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to    DISMISS   .
        /// </summary>
        internal static string MainWindowNoticesAck {
            get {
                return ResourceManager.GetString("MainWindowNoticesAck", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to dismiss these notices..
        /// </summary>
        internal static string MainWindowNoticesAckTooltip {
            get {
                return ResourceManager.GetString("MainWindowNoticesAckTooltip", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to GENERATORS.
        /// </summary>
        internal static string MainWindowSectionLabelGenerators {
            get {
                return ResourceManager.GetString("MainWindowSectionLabelGenerators", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to MODE.
        /// </summary>
        internal static string MainWindowSectionLabelMode {
            get {
                return ResourceManager.GetString("MainWindowSectionLabelMode", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to NOTICES.
        /// </summary>
        internal static string MainWindowSectionLabelNotices {
            get {
                return ResourceManager.GetString("MainWindowSectionLabelNotices", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SCOUT HELPER.
        /// </summary>
        internal static string MainWindowTitle {
            get {
                return ResourceManager.GetString("MainWindowTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Siren Hunts.
        /// </summary>
        internal static string SirenButton {
            get {
                return ResourceManager.GetString("SirenButton", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to generate a Siren Hunts link from the Hunt Helper train recorder data..
        /// </summary>
        internal static string SirenButtonTooltip {
            get {
                return ResourceManager.GetString("SirenButtonTooltip", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Turtle Scouter.
        /// </summary>
        internal static string TurtleButton {
            get {
                return ResourceManager.GetString("TurtleButton", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to update the turtle collab session with the latest scouted marks in your hunt helper train recorder..
        /// </summary>
        internal static string TurtleButtonActiveCollabTooltip {
            get {
                return ResourceManager.GetString("TurtleButtonActiveCollabTooltip", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to generate a turtle scouter link from the hunt helper train recorder data..
        /// </summary>
        internal static string TurtleButtonTooltip {
            get {
                return ResourceManager.GetString("TurtleButtonTooltip", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to  COLLAB .
        /// </summary>
        internal static string TurtleCollabButton {
            get {
                return ResourceManager.GetString("TurtleCollabButton", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to click to leave the current session..
        /// </summary>
        internal static string TurtleCollabButtonActiveTooltip {
            get {
                return ResourceManager.GetString("TurtleCollabButtonActiveTooltip", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to start or join a collaborative scouting session on turtle..
        /// </summary>
        internal static string TurtleCollabButtonTooltip {
            get {
                return ResourceManager.GetString("TurtleCollabButtonTooltip", resourceCulture);
            }
        }
    }
}
