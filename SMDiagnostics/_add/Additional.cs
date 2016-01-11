using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("System.Runtime.Serialization, PublicKey=00000000000000000400000000000000")]

namespace System.ServiceModel.Diagnostics
{
    internal sealed class TraceSR
    {
        internal const string ActivityBoundary = "ActivityBoundary";

        internal const string ThrowingException = "ThrowingException";

        internal const string TraceHandledException = "TraceHandledException";

        internal const string TraceCodeAppDomainUnload = "TraceCodeAppDomainUnload";

        internal const string TraceCodeEventLog = "TraceCodeEventLog";

        internal const string TraceCodeTraceTruncatedQuotaExceeded = "TraceCodeTraceTruncatedQuotaExceeded";

        internal const string UnhandledException = "UnhandledException";

        internal const string WriteCharsInvalidContent = "WriteCharsInvalidContent";

        internal const string GenericCallbackException = "GenericCallbackException";

        internal const string StringNullOrEmpty = "StringNullOrEmpty";

        public static string GetString(string name, params object[] args)
        {
            return name;
        }
    }
}