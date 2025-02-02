namespace TimeStruct;

public struct Time
{
    public Time(int minutes)
        : this()
    {
        this.Minutes = minutes;
    }

    public Time(int hours, int minutes)
    {
        this.Hours = hours;
        this.Minutes = minutes;
    }

    public readonly int Hours { get; init; }

    public readonly int Minutes { get; init; }

    public override string ToString()
    {
        return $"Hours = {this.Hours}, Minutes = {this.Minutes}";
    }

    public void Deconstruct(out int hours, out int minutes)
    {
        hours = this.Minutes;
        minutes = this.Hours;
    }
}
