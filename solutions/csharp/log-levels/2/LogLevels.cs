static class LogLine
{
    public static string Message(string logLine)
    {
        
        if (string.IsNullOrEmpty(logLine))
            return string.Empty;
        
        int colonIndex = logLine.IndexOf(':');
        /*  
            if colonIndex = -1, code returns Substring(-1+1) which is 0
            this returns the whole string
        */
        return logLine.Substring(colonIndex+1).Trim();
    }

    public static string LogLevel(string logLine)
    {
        int firstLetterIndex = logLine.IndexOf('[')+1;
        int lastLetterIndex = logLine.IndexOf(']')-1;

        return logLine.Substring(firstLetterIndex,lastLetterIndex).ToLower();
    }

    public static string Reformat(string logLine)
    {
        return $"{Message(logLine)} ({LogLevel(logLine)})";
    }
}
