﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LinusForumTipsDesktop.Settings {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.0.1.0")]
    internal sealed partial class Preferences : global::System.Configuration.ApplicationSettingsBase {
        
        private static Preferences defaultInstance = ((Preferences)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Preferences())));
        
        public static Preferences Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool DarkTheme {
            get {
                return ((bool)(this["DarkTheme"]));
            }
            set {
                this["DarkTheme"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool ConfiguredColors {
            get {
                return ((bool)(this["ConfiguredColors"]));
            }
            set {
                this["ConfiguredColors"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool DetectedSpecs {
            get {
                return ((bool)(this["DetectedSpecs"]));
            }
            set {
                this["DetectedSpecs"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool ViewedLicense {
            get {
                return ((bool)(this["ViewedLicense"]));
            }
            set {
                this["ViewedLicense"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool MaximizedOnLaunch {
            get {
                return ((bool)(this["MaximizedOnLaunch"]));
            }
            set {
                this["MaximizedOnLaunch"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool ConfiguredLanguages {
            get {
                return ((bool)(this["ConfiguredLanguages"]));
            }
            set {
                this["ConfiguredLanguages"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("English")]
        public string LanguageChosen {
            get {
                return ((string)(this["LanguageChosen"]));
            }
            set {
                this["LanguageChosen"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool customColors {
            get {
                return ((bool)(this["customColors"]));
            }
            set {
                this["customColors"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool customFonts {
            get {
                return ((bool)(this["customFonts"]));
            }
            set {
                this["customFonts"] = value;
            }
        }
    }
}
