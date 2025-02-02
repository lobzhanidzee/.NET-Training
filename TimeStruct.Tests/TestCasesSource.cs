using NUnit.Framework;

namespace TimeStruct.Tests;

public sealed class TestCasesSource
{
    public static IEnumerable<TestCaseData> TestCasesForToString
    {
        get
        {
            yield return new TestCaseData(new Time(8, 0), "08:00");
            yield return new TestCaseData(new Time(11, 9), "11:09");
            yield return new TestCaseData(new Time(24, 0), "00:00");
            yield return new TestCaseData(new Time(25, 0), "01:00");
            yield return new TestCaseData(new Time(100, 0), "04:00");
            yield return new TestCaseData(new Time(1, 60), "02:00");
            yield return new TestCaseData(new Time(0, 160), "02:40");
            yield return new TestCaseData(new Time(0, 1723), "04:43");
            yield return new TestCaseData(new Time(25, 160), "03:40");
            yield return new TestCaseData(new Time(201, 3001), "11:01");
            yield return new TestCaseData(new Time(72, 8640), "00:00");
            yield return new TestCaseData(new Time(-1, 15), "23:15");
            yield return new TestCaseData(new Time(-25, 0), "23:00");
            yield return new TestCaseData(new Time(-91, 0), "05:00");
            yield return new TestCaseData(new Time(1, -40), "00:20");
            yield return new TestCaseData(new Time(1, -160), "22:20");
            yield return new TestCaseData(new Time(1, -4820), "16:40");
            yield return new TestCaseData(new Time(2, -60), "01:00");
            yield return new TestCaseData(new Time(-25, -160), "20:20");
            yield return new TestCaseData(new Time(-121, -58100), "14:40");
        }
    }

    public static IEnumerable<TestCaseData> TestCasesForToStringThroughObject
    {
        get
        {
            yield return new TestCaseData(new Time(24, 0));
            yield return new TestCaseData(new Time(25, 0));
            yield return new TestCaseData(new Time(100, 0));
            yield return new TestCaseData(new Time(1, 60));
            yield return new TestCaseData(new Time(72, 8640));
            yield return new TestCaseData(new Time(-1, 15));
            yield return new TestCaseData(new Time(-25, 0));
        }
    }

    public static IEnumerable<TestCaseData> TestCasesForHoursProperty
    {
        get
        {
            yield return new TestCaseData(new Time(8, 0), 8);
            yield return new TestCaseData(new Time(11, 9), 11);
            yield return new TestCaseData(new Time(24, 0), 0);
            yield return new TestCaseData(new Time(25, 0), 1);
            yield return new TestCaseData(new Time(100, 0), 4);
            yield return new TestCaseData(new Time(1, 60), 2);
            yield return new TestCaseData(new Time(0, 160), 2);
            yield return new TestCaseData(new Time(0, 1723), 4);
            yield return new TestCaseData(new Time(25, 160), 3);
            yield return new TestCaseData(new Time(201, 3001), 11);
            yield return new TestCaseData(new Time(72, 8640), 0);
            yield return new TestCaseData(new Time(-1, 15), 23);
            yield return new TestCaseData(new Time(-25, 0), 23);
            yield return new TestCaseData(new Time(-91, 0), 5);
            yield return new TestCaseData(new Time(1, -40), 0);
            yield return new TestCaseData(new Time(1, -160), 22);
            yield return new TestCaseData(new Time(1, -4820), 16);
            yield return new TestCaseData(new Time(2, -60), 1);
            yield return new TestCaseData(new Time(-25, -160), 20);
            yield return new TestCaseData(new Time(-121, -58100), 14);
        }
    }

    public static IEnumerable<TestCaseData> TestCasesForMinutesProperty
    {
        get
        {
            yield return new TestCaseData(new Time(8, 0), 0);
            yield return new TestCaseData(new Time(11, 9), 9);
            yield return new TestCaseData(new Time(24, 0), 0);
            yield return new TestCaseData(new Time(25, 0), 0);
            yield return new TestCaseData(new Time(100, 0), 0);
            yield return new TestCaseData(new Time(1, 60), 0);
            yield return new TestCaseData(new Time(0, 160), 40);
            yield return new TestCaseData(new Time(0, 1723), 43);
            yield return new TestCaseData(new Time(25, 160), 40);
            yield return new TestCaseData(new Time(201, 3001), 1);
            yield return new TestCaseData(new Time(72, 8640), 0);
            yield return new TestCaseData(new Time(-1, 15), 15);
            yield return new TestCaseData(new Time(-25, 0), 0);
            yield return new TestCaseData(new Time(-91, 0), 0);
            yield return new TestCaseData(new Time(1, -40), 20);
            yield return new TestCaseData(new Time(1, -160), 20);
            yield return new TestCaseData(new Time(1, -4820), 40);
            yield return new TestCaseData(new Time(2, -60), 0);
            yield return new TestCaseData(new Time(-25, -160), 20);
            yield return new TestCaseData(new Time(-121, -58100), 40);
        }
    }

    public static IEnumerable<TestCaseData> TestCasesForTwoParametersCtor
    {
        get
        {
            yield return new TestCaseData(new Time(8, 0), 8, 0);
            yield return new TestCaseData(new Time(11, 9), 11, 9);
            yield return new TestCaseData(new Time(24, 0), 0, 0);
            yield return new TestCaseData(new Time(25, 0), 1, 0);
            yield return new TestCaseData(new Time(100, 0), 4, 0);
            yield return new TestCaseData(new Time(1, 60), 2, 0);
            yield return new TestCaseData(new Time(0, 160), 2, 40);
            yield return new TestCaseData(new Time(0, 1723), 4, 43);
            yield return new TestCaseData(new Time(25, 160), 3, 40);
            yield return new TestCaseData(new Time(201, 3001), 11, 1);
            yield return new TestCaseData(new Time(72, 8640), 0, 0);
            yield return new TestCaseData(new Time(-1, 15), 23, 15);
            yield return new TestCaseData(new Time(-25, 0), 23, 0);
            yield return new TestCaseData(new Time(-91, 0), 5, 0);
            yield return new TestCaseData(new Time(1, -40), 0, 20);
            yield return new TestCaseData(new Time(1, -160), 22, 20);
            yield return new TestCaseData(new Time(1, -4820), 16, 40);
            yield return new TestCaseData(new Time(2, -60), 1, 0);
            yield return new TestCaseData(new Time(-25, -160), 20, 20);
            yield return new TestCaseData(new Time(-121, -58100), 14, 40);
        }
    }

    public static IEnumerable<TestCaseData> TestCasesForOneParameterCtor
    {
        get
        {
            yield return new TestCaseData(new Time(160), 2, 40);
            yield return new TestCaseData(new Time(1723), 4, 43);
            yield return new TestCaseData(new Time(160), 2, 40);
            yield return new TestCaseData(new Time(3001), 2, 1);
            yield return new TestCaseData(new Time(8640), 0, 0);
            yield return new TestCaseData(new Time(15), 0, 15);
            yield return new TestCaseData(new Time(0), 0, 0);
            yield return new TestCaseData(new Time(-40), 23, 20);
            yield return new TestCaseData(new Time(-160), 21, 20);
            yield return new TestCaseData(new Time(-60), 23, 0);
            yield return new TestCaseData(new Time(-58100), 15, 40);
        }
    }
}
