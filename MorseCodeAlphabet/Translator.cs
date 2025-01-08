namespace MorseCodeAlphabet;

public static class Translator
{
    public static bool TryTranslateToMorseCode(char @char, out byte @byte)
    {
        @byte = 0b00000000;

        switch (@char)
        {
            case 'A':
            case 'a':
                @byte = 0b0011_0001;
                break;
            case 'B':
            case 'b':
                @byte = 0b1111_1110;
                break;
            case 'C':
            case 'c':
                @byte = 0b1111_1010;
                break;
            case 'D':
            case 'd':
                @byte = 0b0111_0110;
                break;
            case 'E':
            case 'e':
                @byte = 0b0001_0001;
                break;
            case 'F':
            case 'f':
                @byte = 0b1111_1011;
                break;
            case 'G':
            case 'g':
                @byte = 0b0111_0100;
                break;
            case 'H':
            case 'h':
                @byte = 0b1111_1111;
                break;
            case 'I':
            case 'i':
                @byte = 0b0011_0011;
                break;
            case 'J':
            case 'j':
                @byte = 0b1111_0001;
                break;
            case 'K':
            case 'k':
                @byte = 0b0111_0010;
                break;
            case 'L':
            case 'l':
                @byte = 0b1111_1101;
                break;
            case 'M':
            case 'm':
                @byte = 0b0011_0000;
                break;
            case 'N':
            case 'n':
                @byte = 0b0011_0010;
                break;
            case 'O':
            case 'o':
                @byte = 0b0111_0000;
                break;
            case 'P':
            case 'p':
                @byte = 0b1111_1001;
                break;
            case 'Q':
            case 'q':
                @byte = 0b1111_0100;
                break;
            case 'R':
            case 'r':
                @byte = 0b0111_0101;
                break;
            case 'S':
            case 's':
                @byte = 0b0111_0111;
                break;
            case 'T':
            case 't':
                @byte = 0b0001_0000;
                break;
            case 'U':
            case 'u':
                @byte = 0b0111_0011;
                break;
            case 'V':
            case 'v':
                @byte = 0b1111_0111;
                break;
            case 'W':
            case 'w':
                @byte = 0b0111_0001;
                break;
            case 'X':
            case 'x':
                @byte = 0b1111_0110;
                break;
            case 'Y':
            case 'y':
                @byte = 0b1111_0010;
                break;
            case 'Z':
            case 'z':
                @byte = 0b1111_1100;
                break;
            default:
                return false;
        }

        return true;
    }

    public static bool TryTranslateFromMorse(byte @byte, out char @char)
    {
        @char = ' ';

        switch (@byte)
        {
            case 0b0011_0001:
                @char = 'A';
                break;
            case 0b1111_1110:
                @char = 'B';
                break;
            case 0b1111_1010:
                @char = 'C';
                break;
            case 0b0111_0110:
                @char = 'D';
                break;
            case 0b0001_0001:
                @char = 'E';
                break;
            case 0b1111_1011:
                @char = 'F';
                break;
            case 0b0111_0100:
                @char = 'G';
                break;
            case 0b1111_1111:
                @char = 'H';
                break;
            case 0b0011_0011:
                @char = 'I';
                break;
            case 0b1111_0001:
                @char = 'J';
                break;
            case 0b0111_0010:
                @char = 'K';
                break;
            case 0b1111_1101:
                @char = 'L';
                break;
            case 0b0011_0000:
                @char = 'M';
                break;
            case 0b0011_0010:
                @char = 'N';
                break;
            case 0b0111_0000:
                @char = 'O';
                break;
            case 0b1111_1001:
                @char = 'P';
                break;
            case 0b1111_0100:
                @char = 'Q';
                break;
            case 0b0111_0101:
                @char = 'R';
                break;
            case 0b0111_0111:
                @char = 'S';
                break;
            case 0b0001_0000:
                @char = 'T';
                break;
            case 0b0111_0011:
                @char = 'U';
                break;
            case 0b1111_0111:
                @char = 'V';
                break;
            case 0b0111_0001:
                @char = 'W';
                break;
            case 0b1111_0110:
                @char = 'X';
                break;
            case 0b1111_0010:
                @char = 'Y';
                break;
            case 0b1111_1100:
                @char = 'Z';
                break;
            default:
                return false;
        }

        return true;
    }
}
