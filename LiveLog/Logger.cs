using System.Diagnostics.CodeAnalysis;

namespace LiveLog; 

public interface Logger {
    public void debug([StringSyntax("CompositeFormat")] string log, params object?[]? arg);
    public void info([StringSyntax("CompositeFormat")] string log, params object?[]? arg);
    public void warn([StringSyntax("CompositeFormat")] string log, params object?[]? arg);
    public void error([StringSyntax("CompositeFormat")] string log, params object?[]? arg);
}