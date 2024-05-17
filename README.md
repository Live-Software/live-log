# LiveSoftwareLog

The goal is an easy to use logging library.

The `Logger` interface provides a simple logger specification.  
Currently, a basic console logger implementation exists. You can either construct this directly, or use the `LoggerFactory`
provided. Like so:  
`LoggerFactory.createLogger(LoggingLevel.Info)` for only logging info logs.
> **_NOTE:_**  Using `LoggingLevel.None` will create a no-op logger instead, which will eat every log instead of
> publishing it.

To use the created logger, simply call the method with the appropriate log level. Example usage:
```csharp
var logger = LoggerFactory.createLogger(LoggingLevel.Info); // Creates a logger which will pring logs of level INFO or higher
logger.error("Some error {0}", error); // Will print and error message
logger.debug("Some debug message {0}", "for you"); // Will not print the message, because DEBUG is of lower level than INFO
```

### Available logging levels:
 * Debug
 * Info
 * Warning
 * Error
 * None