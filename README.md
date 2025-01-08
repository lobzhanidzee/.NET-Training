# Morse Code Alphabet

Beginner level task for practicing branching switch statements and binary literals.

The task is to implement two methods that should return Morse code sequence for Latin characters (A-Z, a-z). Use [International Morse Code](https://en.wikipedia.org/wiki/Morse_code) table.

Estimated time to complete the task - 1h.

The task requires .NET 8 SDK installed.


## Task Description

1. Implement the [TryTranslateToMorseCode](MorseCodeAlphabet/Translator.cs#L5) method using the `switch` statement.
    * If the `@char` parameter is a letter, the method should return `true` and set the `@byte` parameter to the binary representation of the relevant Morse code.
    * If the `@char` parameter is not a letter, the method should return `false` and set the `@byte` parameter to `0`.
    * In `case` blocks use literals in the *binary* form.

2. Implement the [TryTranslateFromMorse](MorseCodeAlphabet/Translator.cs#L22) method using the `switch` statement.
    * If the `@byte` parameter is a valid Morse code, the method should return `true` and set the `@char` parameter to the relevant uppercase character.
    * If the `@byte` parameter is not a valid Morse code, the method should return `false` and set the `@char` parameter to the white-space character.
    * In `case` blocks use literals in the *binary* form.

Read more about hexadecimal and binary numbers first!

[Byte is C#](https://docs.microsoft.com/en-us/dotnet/api/system.byte) is a data structure that can store 8-bit unsigned integer. Each bit in byte has its own position that starts with 0. The first bit has position 0, the last bit has position 7. Usually, we put the first bit on the right side, and the last bit on the left side.

An example of a 1 number in binary form.

| Bit position  | 7 | 6 | 5 | 4 | 3 | 2 | 1 | 0 |
|---------------|---|---|---|---|---|---|---|---|
| Bit           | 0 | 0 | 0 | 0 | 0 | 0 | 0 | 1 |

Each bit can be set to 1 or 0. Here's an example of decimal number `15`. In binary form the literal looks like `0b0000_1111` and it is equals to `0x0F` in hex form.

| Bit position  | 7 | 6 | 5 | 4 | 3 | 2 | 1 | 0 |
|---------------|---|---|---|---|---|---|---|---|
| Bit           | 0 | 0 | 0 | 0 | 1 | 1 | 1 | 1 |

For storing an information about a Morse code letter we will divide the bit into two parts - the high 4 bits (positions 4-7) and the low 4 bits (positions 0-3). The high part will contain a mask that should represents how many symbols a Morse code has. The low part will contain the value that should represent a Morse code.

Here's an example for "A" character. The Morse code is ".-". The first symbol is "dot" (.), and the second is "dash" (-).

Let's put the Morse code for "A" character to the table for both high (mask) and low (value) parts (beginning from lower bits).

| Bit position  | 7 | 6 | 5 | 4 | 3 | 2 | 1 | 0 |
|---------------|---|---|---|---|---|---|---|---|
| Morse code    |   |   | - | . |   |   | - | . |
| Mask          |   |   | 1 | 1 |   |   |   |   |
| Value         |   |   |   |   |   |   | 0 | 1 |
| Result byte   | 0 | 0 | 1 | 1 | 0 | 0 | 0 | 1 |

The code has two characters that means we put 1 in the mask part on positions 4 and 5. "Dot" in the value part is represented by 1 (position 0), and "dash" is represented by 0 (position 1).

The result literal in binary form is `0b0011_0001` and it is equal to `0x31` in hex form.


Another example - 'X' character. The Morse code is "-..-", 4 symbols. That means all bits in mask part should be set to 1. There are two "dots" in the value part on 1 and 2 positions.

| Bit position  | 7 | 6 | 5 | 4 | 3 | 2 | 1 | 0 |
|---------------|---|---|---|---|---|---|---|---|
| Morse code    | - | . | . | - | - | . | . | - |
| Mask          | 1 | 1 | 1 | 1 |   |   |   |   |
| Value         |   |   |   |   | 0 | 1 | 1 | 0 |
| Result byte   | 1 | 1 | 1 | 1 | 0 | 1 | 1 | 0 |

The result literal in binary form is `0b1111_0110` and it is equal to `0xF6` in hex form.


## See also

* [Morse code](https://en.wikipedia.org/wiki/Morse_code)
* [Hexadecimal](https://en.wikipedia.org/wiki/Hexadecimal)
* [Binary number](https://en.wikipedia.org/wiki/Binary_number)
* C# Reference
  * [switch](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/switch)
