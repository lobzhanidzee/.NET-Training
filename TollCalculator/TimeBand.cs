namespace TollCalculator;

/// <summary>
/// Represents time intervals.
/// </summary>
internal enum TimeBand
{
    /// <summary>
    /// Time interval from 6:00 to 10:00.
    /// </summary>
    MorningRush,

    /// <summary>
    /// Time interval from 10:00 to 16:00.
    /// </summary>
    Daytime,

    /// <summary>
    /// Time interval from 16:00 to 19:00.
    /// </summary>
    EveningRush,

    /// <summary>
    /// Time interval from 19:00 to 6:00.
    /// </summary>
    Overnight,
}
