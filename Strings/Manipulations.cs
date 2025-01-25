namespace Strings;
public static class Manipulations
{
    /// <summary>
    /// Returns a greeting.
    /// </summary>
    public static string GetHelloGreeting1(string name)
    {
        const string template = "Hello, !";
        return template.Insert(7, name);
    }

    /// <summary>
    /// Returns a greeting.
    /// </summary>
    public static string GetGreeting1(string greeting, string name)
    {
        ArgumentNullException.ThrowIfNull(name);
        ArgumentNullException.ThrowIfNull(greeting);
        return greeting.Insert(greeting.Length, $", {name.ToUpperInvariant()}!");
    }

    /// <summary>
    /// Returns a greeting.
    /// </summary>
    public static string GetHelloGreeting2(string name)
    {
        ArgumentNullException.ThrowIfNull(name);
        const string template = "Hello, !";
        return template.Insert(7, name.Trim());
    }

    /// <summary>
    /// Returns a greeting.
    /// </summary>
    public static string GetGreeting2(string greeting, string name)
    {
        ArgumentNullException.ThrowIfNull(greeting);
        ArgumentNullException.ThrowIfNull(name);
        string template = greeting.Trim() + ", !";
        return template.Insert(greeting.Trim().Length + 2, name.ToLowerInvariant().Trim());
    }

    /// <summary>
    /// Returns a greeting.
    /// </summary>
    public static string GetHelloGreeting3(string template, string name)
    {
        ArgumentNullException.ThrowIfNull(template);
        return template.Replace("{name}", name, StringComparison.InvariantCulture);
    }

    /// <summary>
    /// Returns a greeting.
    /// </summary>
    public static string GetGreeting3(string template, string greeting, string name)
    {
        ArgumentNullException.ThrowIfNull(template);
        ArgumentNullException.ThrowIfNull(greeting);
        ArgumentNullException.ThrowIfNull(name);
        return template.Replace("{greeting}", greeting.ToLowerInvariant(), StringComparison.InvariantCulture).Replace("{name}", name.ToUpperInvariant(), StringComparison.InvariantCulture);
    }

    /// <summary>
    /// Returns refined code - without zero characters.
    /// </summary>
    public static string GetRefinedCode(string code)
    {
        ArgumentNullException.ThrowIfNull(code);
        return code.Remove(3, 3);
    }

    /// <summary>
    /// Returns refined date - without dash characters.
    /// </summary>
    public static string GetRefinedDate(string date)
    {
        ArgumentNullException.ThrowIfNull(date);
        return date.Replace("-", string.Empty, StringComparison.InvariantCulture);
    }
}
