using System.Reflection;
using System.Runtime.CompilerServices;

[assembly: AssemblyKeyFile(@"..\binaries\key.snk")]
[assembly: AssemblyDelaySignAttribute(true)]
[assembly: InternalsVisibleTo("System, PublicKey=00000000000000000400000000000000")]
[assembly: InternalsVisibleTo("System.Core, PublicKey=00000000000000000400000000000000")]

namespace System
{
    internal enum CompatibilityFlag
    {
        DateTimeParseIgnorePunctuation,
        EagerlyGenerateRandomAsymmKeys,
        FullTrustListAssembliesInGac
    }

        internal static class AssemblyRef
        {
            public const string Mscorlib = "";
        public const string MicrosoftJScript = "";
        public const string MicrosoftVisualCCppCodeProvider = "";
        public const string SystemWeb = "";
        public const string SystemData = "";
            public const string WindowsBase = "";

            public const string System = "";
            public const string EcmaPublicKeyFull = "";
            public const string SystemDrawing = "";
            public const string SystemSecurity = "";
            public const string MicrosoftPublicKeyToken = "";
        public const string MicrosoftPublicKeyFull = "";
        public const string EcmaPublicKeyToken = "";
            public const string SystemRuntimeWindowsRuntime = "";
        public const string SystemRuntimeRemoting = "";
        public const string SystemCore = "";
        public const string SystemDesign = "";
        public const string SystemConfiguration = "";
        public const string SystemConfigurationInstall = "";
        public const string SystemWindowsForms = "";

    }

    internal static class ThisAssembly
    {
        public const string Version = "";
        public const int DailyBuildNumber = 0;

    }
}
