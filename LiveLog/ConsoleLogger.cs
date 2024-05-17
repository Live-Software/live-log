using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace LiveLog; 

public class ConsoleLogger(LoggingLevel level) : TextWriter, Logger {

    public void debug([StringSyntax("CompositeFormat")]string log, params object?[]? arg) {
        if (level > LoggingLevel.Debug) {
            return;
        }
        var logMessage = arg == null ? log : string.Format(log, arg);
        Console.WriteLine("[{0}] DEBUG: {1}", DateTime.Now.ToString("yyyy-M-d HH:mm:ss.ffff"), logMessage);
    }

    public void info([StringSyntax("CompositeFormat")]string log, params object?[]? arg) {
        if (level > LoggingLevel.Info) {
            return;
        }
        var logMessage = arg == null ? log : string.Format(log, arg);
        Console.WriteLine("[{0}] INFO: {1}", DateTime.Now.ToString("yyyy-M-d HH:mm:ss.ffff"), logMessage);
    }

    public void warn(string log, params object?[]? arg) {
        if (level > LoggingLevel.Warning) {
            return;
        }
        var logMessage = arg == null ? log : string.Format(log, arg);
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("[{0}] WARN: {1}", DateTime.Now.ToString("yyyy-M-d HH:mm:ss.ffff"), logMessage);
        Console.ResetColor();
    }

    public void error(string log, params object?[]? arg) {
        if (level > LoggingLevel.Error) {
            return;
        }
        var logMessage = arg == null ? log : string.Format(log, arg);
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Error.WriteLine("[{0}] ERROR: {1}", DateTime.Now.ToString("yyyy-M-d HH:mm:ss.ffff"), logMessage);
        Console.ResetColor();
    }

    public override Encoding Encoding => Console.Out.Encoding;
}