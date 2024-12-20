using AntiCheater;
using NUnit.Framework;
using NUnit.Framework.Legacy;

namespace GenericSequenceGenerator.Tests;

[TestFixture]
public class CharSequenceGeneratorTests() : AntiCheatingTest(CheatingDetectionParams.All)
{
    [Test]
    public void FourthSequenceGenerator_Should_Generate_Correct_Sequence()
    {
        var generator = new CharSequenceGenerator('A', 'B');
        var expectedSequence = new List<char>
        {
            'A',
            'B',
            'B',
            'C',
            'D',
            'F',
            'I',
            'N',
            'V',
            'I'
        };

        var actualSequence = new List<char> { generator.Previous, generator.Current };
        for (int i = 0; i < 8; i++)
        {
            actualSequence.Add(generator.Next);
        }

        CollectionAssert.AreEqual(expectedSequence, actualSequence);
    }

    [Test]
    public void FourthSequenceGenerator_Should_Generate_Correct_Sequence_With_Wrap_Around()
    {
        var generator = new CharSequenceGenerator('Y', 'Z');
        var expectedSequence = new List<char>
        {
            'Y',
            'Z',
            'X',
            'W',
            'T',
            'P',
            'I',
            'X',
            'F',
            'C'
        };

        var actualSequence = new List<char> { generator.Previous, generator.Current };
        for (int i = 0; i < 8; i++)
        {
            actualSequence.Add(generator.Next);
        }

        CollectionAssert.AreEqual(expectedSequence, actualSequence);
    }

    [Test]
    public void FourthSequenceGenerator_Should_Behave_Polymorphically()
    {
        var charSequenceGenerator = new CharSequenceGenerator('K', 'L');
        var expectedSequence = new List<char>
        {
            'K',
            'L',
            'V',
            'G',
            'B',
            'H',
            'I'
        };

        var actualSequence = new List<char> { ((ISequenceGenerator<char>)charSequenceGenerator).Previous, ((ISequenceGenerator<char>)charSequenceGenerator).Current };
        for (int i = 0; i < 5; i++)
        {
            actualSequence.Add(((ISequenceGenerator<char>)charSequenceGenerator).Next);
        }

        CollectionAssert.AreEqual(expectedSequence, actualSequence);
    }
}
