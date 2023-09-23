using System;

static class LogLine
{
    public static string Message(string logLine)
    {
        string[] parts = logLine.Split(':');
        if (parts.Length > 1)
        {
        string result = parts[1].Trim();
        return result;
        }
        throw new NotImplementedException("Please implement the (static) LogLine.Message() method");
    }

    public static string LogLevel(string logLine)
    {
        int startIndex = logLine.IndexOf('[') + 1;
        int endIndex = logLine.IndexOf(']');
        if (startIndex > 0 && endIndex > 0)
        {
            string result = logLine.Substring(startIndex, endIndex - startIndex);
            return result.ToLower();
        }
        throw new NotImplementedException("Please implement the (static) LogLine.LogLevel() method");
    }

    public static string Reformat(string logLine)
    {
        string firstpart = Message(logLine);
        string secondPart = LogLevel(logLine);

        return firstpart + " ("+secondPart +")";
        throw new NotImplementedException("Please implement the (static) LogLine.Reformat() method");
    }
}