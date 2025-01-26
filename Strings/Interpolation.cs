namespace Strings;

public static class Interpolation
{
    /// <summary>
    /// Returns a greeting that starts with "Hello".
    /// </summary>
    public static string GetHelloGreeting(string name)
    {
        return $"Hello, {name}!";
    }

    /// <summary>
    /// Returns a greeting that starts with a greeting argument.
    /// </summary>
    public static string GetGreeting(string greeting, string name)
    {
        return $"{greeting}, {name}!";
    }

    /// <summary>
    /// Returns a phrase that contains a square number.
    /// </summary>
    public static string GetSquareNumber(int i)
    {
        return $"The square number of {i} is {i * i}.";
    }

    /// <summary>
    /// Returns a phrase that contains a total price.
    /// </summary>
    public static string GetTotalPrice(double price, int items, double discount)
    {
        double totalPrice = discount < 1 ? price * discount * items : price * items;
        return $"The price of all items is {totalPrice:F2}.";
    }

    /// <summary>
    /// Returns a phrase that contains a sequence of numbers.
    /// </summary>
    public static string GetSequenceOfNumbers(int[] numbers)
    {
        return $"The sequence is {{{string.Join(',', numbers)}}}.";
    }

    /// <summary>
    /// Returns a phrase that contains the length of a sequence.
    /// </summary>
    public static string GetSequenceOfNumbersLength(string sequence)
    {
        ArgumentNullException.ThrowIfNull(sequence);
        string[] nums = sequence.Length > 0 ? sequence.Split(',') : Array.Empty<string>();
        return $"The sequence length is {nums.Length}.";
    }

    /// <summary>
    /// Returns a file path to a document.
    /// </summary>
    public static string GetDocumentPath(string username, string filename, string extension)
    {
        return $@"c:\users\{username}\Documents\{filename}.{extension}";
    }

    /// <summary>
    /// Returns a network path to document.
    /// </summary>
    public static string GetNetworkPath(string workstation, string userFolder, string filename, string extension)
    {
        return $@"\\{workstation}\users\{userFolder}\{filename}.{extension}";
    }
}
