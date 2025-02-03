namespace TimeStruct;

public struct Time
{
    public Time(int minutes)
        : this(0, minutes)
    {
    }

    public Time(int hours, int minutes)
    {
        int totalMinutes = (hours * 60) + minutes;
        totalMinutes %= 1440;

        if (totalMinutes < 0)
        {
            totalMinutes += 1440;
        }

        this.Hours = totalMinutes / 60;
        this.Minutes = totalMinutes % 60;
    }

    public int Hours { get; }

    public int Minutes { get; }

    public new string ToString()
    {
        return $"{this.Hours:D2}:{this.Minutes:D2}";
    }

    public void Deconstruct(out int hours, out int minutes)
    {
        hours = this.Hours;
        minutes = this.Minutes;
    }
}
