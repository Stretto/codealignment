﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17626
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CMcG.CodeAlignment.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "12.0.0.0")]
    public sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::System.Collections.Specialized.StringCollection Delimiters {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["Delimiters"]));
            }
            set {
                this["Delimiters"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool UseRegex {
            get {
                return ((bool)(this["UseRegex"]));
            }
            set {
                this["UseRegex"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"<?xml version=""1.0"" encoding=""utf-16""?>
<ArrayOfKeyShortcut xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">
  <KeyShortcut>
    <Value>EqualsPlus</Value>
    <Alignment>(^|[\w\s])(?&lt;x&gt;=)</Alignment>
    <AlignFromCaret>false</AlignFromCaret>
    <UseRegex>true</UseRegex>
    <AddSpace>true</AddSpace>
  </KeyShortcut>
  <KeyShortcut>
    <Value>M</Value>
    <Alignment>m_</Alignment>
    <AlignFromCaret>false</AlignFromCaret>
    <UseRegex>false</UseRegex>
  </KeyShortcut>
  <KeyShortcut>
    <Value>Quotes</Value>
    <Alignment>""</Alignment>
    <AlignFromCaret>false</AlignFromCaret>
    <UseRegex>false</UseRegex>
  </KeyShortcut>
  <KeyShortcut>
    <Value>Period</Value>
    <Alignment>.</Alignment>
    <AlignFromCaret>true</AlignFromCaret>
    <UseRegex>false</UseRegex>
  </KeyShortcut>
  <KeyShortcut>
    <Value>Space</Value>
    <Alignment>\s+(?&lt;x&gt;[^\s])</Alignment>
    <AlignFromCaret>true</AlignFromCaret>
    <UseRegex>true</UseRegex>
  </KeyShortcut>
</ArrayOfKeyShortcut>")]
        public string Shortcuts {
            get {
                return ((string)(this["Shortcuts"]));
            }
            set {
                this["Shortcuts"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"<?xml version=""1.0"" encoding=""utf-16""?>
<ArrayOfString xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">
  <string>.xaml</string>
  <string>.xml</string>
  <string>.html</string>
  <string>.xhtml</string>
  <string>.aspx</string>
  <string>.master</string>
  <string>.cshtml</string>
</ArrayOfString>")]
        public global::System.Collections.Specialized.StringCollection XmlTypes {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["XmlTypes"]));
            }
            set {
                this["XmlTypes"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(" { } }; ( )")]
        public string ScopeSelectorLineValues {
            get {
                return ((string)(this["ScopeSelectorLineValues"]));
            }
            set {
                this["ScopeSelectorLineValues"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string ScopeSelectorLineEnds {
            get {
                return ((string)(this["ScopeSelectorLineEnds"]));
            }
            set {
                this["ScopeSelectorLineEnds"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool UseIdeTabSettings {
            get {
                return ((bool)(this["UseIdeTabSettings"]));
            }
            set {
                this["UseIdeTabSettings"] = value;
            }
        }
    }
}
