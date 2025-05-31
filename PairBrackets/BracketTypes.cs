namespace PairBrackets;

/// <summary>
/// Represents the types of brackets.
/// </summary>
/// [Flags]
public enum BracketTypes
{
    /// <summary>
    /// All types of brackets.
    /// </summary>
    All = 0,

    /// <summary>
    /// Round brackets.
    /// </summary>
    RoundBrackets = 1,

    /// <summary>
    /// Square brackets.
    /// </summary>
    SquareBrackets = 2,

    /// <summary>
    /// Curly brackets.
    /// </summary>
    CurlyBrackets = 3,

    /// <summary>
    /// Angle brackets.
    /// </summary>
    AngleBrackets = 4,
}
