namespace PairBrackets;

/// <summary>
/// Provides extension methods for working with strings and bracket pairs.
/// </summary>
public static class StringExtensions
{
    /// <summary>
    /// Returns the number of bracket pairs in the <see cref="text"/>.
    /// </summary>
    /// <param name="text">The source text.</param>
    /// <returns>The number of bracket pairs in the <see cref="text"/>.</returns>
    public static int CountBracketPairs(this string text)
    {
        ArgumentNullException.ThrowIfNull(text);

        int count = 0;
        List<char> symbols = [.. text];

        for (int i = 0; i < symbols.Count; i++)
        {
            char item = symbols[i];
            if (item == '(' || item == '[')
            {
                for (int j = 0; j < symbols.Count; j++)
                {
                    if (i == j)
                    {
                        continue;
                    }

                    char item2 = symbols[j];
                    if ((item == '(' && item2 == ')') || (item == '[' && item2 == ']'))
                    {
                        count++;
                        symbols.RemoveAt(j);
                        break;
                    }
                }
            }
        }

        return count;
    }

    /// <summary>
    /// Searches the <see cref="text"/> and returns the list of start and end positions of bracket pairs.
    /// </summary>
    /// <param name="text">The source text.</param>
    /// <returns>The list of start and end positions of bracket pairs.</returns>
    /// <exception cref="ArgumentNullException"><see cref="text"/> is null.</exception>
    public static IList<(int Start, int End)> GetBracketPairPositions(this string? text)
    {
        // TODO #2. Analyze the method unit tests and add the method implementation.
        throw new NotImplementedException();
    }

    /// <summary>
    /// Examines the <see cref="text"/> and returns true if the pairs and the orders of brackets are balanced; otherwise returns false.
    /// </summary>
    /// <param name="text">The source text.</param>
    /// <param name="bracketTypes">The bracket type option.</param>
    /// <returns>True if the pairs and the orders of brackets are balanced; otherwise returns false.</returns>
    /// <exception cref="ArgumentNullException"><see cref="text"/> is null.</exception>
    public static bool ValidateBrackets(this string? text, BracketTypes bracketTypes)
    {
        // TODO #3. Analyze the method unit tests and add the method implementation.
        throw new NotImplementedException();
    }
}
