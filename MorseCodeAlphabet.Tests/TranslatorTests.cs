using NUnit.Framework;

namespace MorseCodeAlphabet.Tests;

[TestFixture]
public class TranslatorTests
{
    [TestCase('A', ExpectedResult = 0x31)]
    [TestCase('a', ExpectedResult = 0x31)]
    [TestCase('B', ExpectedResult = 0xFE)]
    [TestCase('b', ExpectedResult = 0xFE)]
    [TestCase('C', ExpectedResult = 0xFA)]
    [TestCase('c', ExpectedResult = 0xFA)]
    [TestCase('D', ExpectedResult = 0x76)]
    [TestCase('d', ExpectedResult = 0x76)]
    [TestCase('E', ExpectedResult = 0x11)]
    [TestCase('e', ExpectedResult = 0x11)]
    [TestCase('F', ExpectedResult = 0xFB)]
    [TestCase('f', ExpectedResult = 0xFB)]
    [TestCase('G', ExpectedResult = 0x74)]
    [TestCase('g', ExpectedResult = 0x74)]
    [TestCase('H', ExpectedResult = 0xFF)]
    [TestCase('h', ExpectedResult = 0xFF)]
    [TestCase('I', ExpectedResult = 0x33)]
    [TestCase('i', ExpectedResult = 0x33)]
    [TestCase('J', ExpectedResult = 0xF1)]
    [TestCase('j', ExpectedResult = 0xF1)]
    [TestCase('K', ExpectedResult = 0x72)]
    [TestCase('k', ExpectedResult = 0x72)]
    [TestCase('L', ExpectedResult = 0xFD)]
    [TestCase('l', ExpectedResult = 0xFD)]
    [TestCase('M', ExpectedResult = 0x30)]
    [TestCase('m', ExpectedResult = 0x30)]
    [TestCase('N', ExpectedResult = 0x32)]
    [TestCase('n', ExpectedResult = 0x32)]
    [TestCase('O', ExpectedResult = 0x70)]
    [TestCase('o', ExpectedResult = 0x70)]
    [TestCase('P', ExpectedResult = 0xF9)]
    [TestCase('p', ExpectedResult = 0xF9)]
    [TestCase('Q', ExpectedResult = 0xF4)]
    [TestCase('q', ExpectedResult = 0xF4)]
    [TestCase('R', ExpectedResult = 0x75)]
    [TestCase('r', ExpectedResult = 0x75)]
    [TestCase('S', ExpectedResult = 0x77)]
    [TestCase('s', ExpectedResult = 0x77)]
    [TestCase('T', ExpectedResult = 0x10)]
    [TestCase('t', ExpectedResult = 0x10)]
    [TestCase('U', ExpectedResult = 0x73)]
    [TestCase('u', ExpectedResult = 0x73)]
    [TestCase('V', ExpectedResult = 0xF7)]
    [TestCase('v', ExpectedResult = 0xF7)]
    [TestCase('W', ExpectedResult = 0x71)]
    [TestCase('w', ExpectedResult = 0x71)]
    [TestCase('X', ExpectedResult = 0xF6)]
    [TestCase('x', ExpectedResult = 0xF6)]
    [TestCase('Y', ExpectedResult = 0xF2)]
    [TestCase('y', ExpectedResult = 0xF2)]
    [TestCase('Z', ExpectedResult = 0xFC)]
    [TestCase('z', ExpectedResult = 0xFC)]
    public byte TryTranslateToMorseCode_ReturnsTrue(char @char)
    {
        // Act
        bool result = Translator.TryTranslateToMorseCode(@char, out byte @byte);

        // Assert
        Assert.That(result, Is.True);
        return @byte;
    }

    [TestCase(' ')]
    [TestCase('.')]
    [TestCase('+')]
    [TestCase('0')]
    [TestCase('9')]
    public void TryTranslateToMorseCode_ReturnsFalse(char @char)
    {
        // Act
        bool result = Translator.TryTranslateToMorseCode(@char, out byte @byte);

        // Assert
        Assert.That(result, Is.False);
        Assert.That(@byte, Is.EqualTo(0x00));
    }

    [TestCase(0x31, ExpectedResult = 'A')]
    [TestCase(0xFE, ExpectedResult = 'B')]
    [TestCase(0xFA, ExpectedResult = 'C')]
    [TestCase(0x76, ExpectedResult = 'D')]
    [TestCase(0x11, ExpectedResult = 'E')]
    [TestCase(0xFB, ExpectedResult = 'F')]
    [TestCase(0x74, ExpectedResult = 'G')]
    [TestCase(0xFF, ExpectedResult = 'H')]
    [TestCase(0x33, ExpectedResult = 'I')]
    [TestCase(0xF1, ExpectedResult = 'J')]
    [TestCase(0x72, ExpectedResult = 'K')]
    [TestCase(0xFD, ExpectedResult = 'L')]
    [TestCase(0x30, ExpectedResult = 'M')]
    [TestCase(0x32, ExpectedResult = 'N')]
    [TestCase(0x70, ExpectedResult = 'O')]
    [TestCase(0xF9, ExpectedResult = 'P')]
    [TestCase(0xF4, ExpectedResult = 'Q')]
    [TestCase(0x75, ExpectedResult = 'R')]
    [TestCase(0x77, ExpectedResult = 'S')]
    [TestCase(0x10, ExpectedResult = 'T')]
    [TestCase(0x73, ExpectedResult = 'U')]
    [TestCase(0xF7, ExpectedResult = 'V')]
    [TestCase(0x71, ExpectedResult = 'W')]
    [TestCase(0xF6, ExpectedResult = 'X')]
    [TestCase(0xF2, ExpectedResult = 'Y')]
    [TestCase(0xFC, ExpectedResult = 'Z')]
    public char TryTranslateFromMorse_ReturnsTrue(byte @byte)
    {
        // Act
        bool result = Translator.TryTranslateFromMorse(@byte, out char @char);

        // Assert
        Assert.That(result, Is.True);
        return @char;
    }

    [TestCase(0x00)]
    public void TryTranslateFromMorse_ReturnsFalse(byte @byte)
    {
        // Act
        bool result = Translator.TryTranslateFromMorse(@byte, out char @char);

        // Assert
        Assert.That(result, Is.False);
        Assert.That(@char, Is.EqualTo(' '));
    }
}
