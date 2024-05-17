namespace LiveLog; 

public static class LoggerFactory {
    public static Logger createLogger(LoggingLevel level) {
        return level == LoggingLevel.None ? new NoOpLogger() : new ConsoleLogger(level);
    }
}