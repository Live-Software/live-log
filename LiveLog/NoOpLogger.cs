namespace LiveLog; 

public class NoOpLogger : Logger {

    public void debug(string log, params object?[]? arg) {
    }

    public void info(string log, params object?[]? arg) {
    }

    public void warn(string log, params object?[]? arg) {
    }

    public void error(string log, params object?[]? arg) {
    }
}