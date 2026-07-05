static class LogLine
{
    public static string Message(string logLine)
    {
        var x = logLine.IndexOf(":");
        return logLine.Substring(x+1).Trim();  
    }

    public static string LogLevel(string logLine)
    {
       var x = logLine.IndexOf("]");
        return logLine.Substring(1,x-1).Trim().ToLower();
    }

    public static string Reformat(string logLine)
    {
        var x = logLine.IndexOf("]");
        var str1 = logLine.Substring(1,x-1).Trim().ToLower();
        var y = logLine.IndexOf(":");
        var str2 = logLine.Substring(y+1).Trim();
        return $"{str2} ({str1})";
    }
}
