namespace TrayPassGen.Properties
{
    [global::System.Runtime.CompilerServices.CompilerGenerated()]
    [global::System.CodeDom.Compiler.GeneratedCode("SettingsSingleFileGenerator", "1.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase
    {
        private static Settings defaultInstance = ((Settings)(Synchronized(new Settings())));

        public static Settings Default => defaultInstance;

        public bool IncludeLowercase
        {
            get => ((bool)this["IncludeLowercase"]);
            set => this["IncludeLowercase"] = value;
        }

        public bool IncludeUppercase
        {
            get => ((bool)this["IncludeUppercase"]);
            set => this["IncludeUppercase"] = value;
        }

        public bool IncludeDigits
        {
            get => ((bool)this["IncludeDigits"]);
            set => this["IncludeDigits"] = value;
        }

        public bool IncludeSpecialChars
        {
            get => ((bool)this["IncludeSpecialChars"]);
            set => this["IncludeSpecialChars"] = value;
        }

        public bool UseSafeSymbols
        {
            get => ((bool)this["UseSafeSymbols"]);
            set => this["UseSafeSymbols"] = value;
        }

        public int PasswordLength
        {
            get => ((int)this["PasswordLength"]);
            set => this["PasswordLength"] = value;
        }

        public string StaticPrefix
        {
            get => ((string)this["StaticPrefix"]);
            set => this["StaticPrefix"] = value;
        }
    }
}
