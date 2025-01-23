// ReSharper disable StringLiteralTypo
// ReSharper disable CommentTypo
// ReSharper disable IdentifierTypo
namespace Strings;
public static class StringLiterals
{
    /// <summary>
    /// Returns a "abc" string.
    /// </summary>
    public static string ReturnAbcStringLiteral()
    {
        return "abc";
    }

    /// <summary>
    /// Returns a "ABCDEF" string.
    /// </summary>
    public static string ReturnAbcdefStringLiteral()
    {
        return "ABCDEF";
    }

    /// <summary>
    /// Returns an empty string.
    /// </summary>
    public static string ReturnEmptyString()
    {
        return string.Empty;
    }

    /// <summary>
    /// Returns a file path.
    /// </summary>
    public static string ReturnFilePathStringLiteral1()
    {
        return "c:\\documents\\files\\myfile0234.txt";
    }

    /// <summary>
    /// Returns a file path.
    /// </summary>
    public static string ReturnFilePathStringLiteral2()
    {
        // TODO #1-5. Implement the method - return "c:\users\myuser\documents\my-video-file.avi" string literal.
        return "c:\\users\\myuser\\documents\\my-video-file.avi";
    }

    /// <summary>
    /// Returns a file path.
    /// </summary>
    public static string ReturnFilePathVerbatimStringLiteral1()
    {
        return @"c:\documents\files\datafile0582.txt";
    }

    /// <summary>
    /// Returns a file path.
    /// </summary>
    public static string ReturnFilePathVerbatimStringLiteral2()
    {
        return @"c:\users\myuser\documents\my-audio-file.mp3";
    }
}
