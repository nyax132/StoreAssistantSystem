﻿//------------------------------------------------------------------------------
// <auto-generated>
//     このコードはツールによって生成されました。
//     ランタイム バージョン:4.0.30319.42000
//
//     このファイルへの変更は、以下の状況下で不正な動作の原因になったり、
//     コードが再生成されるときに損失したりします。
// </auto-generated>
//------------------------------------------------------------------------------

namespace StoreAssistantSystem.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.5.0.0")]
    internal sealed partial class Settings1 : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings1 defaultInstance = ((Settings1)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings1())));
        
        public static Settings1 Default {
            get {
                return defaultInstance;
            }
        }
        
        /// <summary>
        /// サーバーに接続するIPアドレス
        /// </summary>
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("サーバーに接続するIPアドレス")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("127.0.0.1")]
        public string IPaddress {
            get {
                return ((string)(this["IPaddress"]));
            }
            set {
                this["IPaddress"] = value;
            }
        }
        
        /// <summary>
        /// サーバーに接続するポート番号
        /// </summary>
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("サーバーに接続するポート番号")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("55555")]
        public int Port {
            get {
                return ((int)(this["Port"]));
            }
            set {
                this["Port"] = value;
            }
        }
    }
}
