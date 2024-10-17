/*
This code is converting the string into char array then reverse it and counting o's amount.
After this it will pring the amount of o's in that string.
*/
string originalMessage = "The quick brown fox jumps over the lazy dog.";

char[] message = originalMessage.ToCharArray();
Array.Reverse(message);

int letterCount = 0;

foreach (char letter in message)
{
    if (letter == 'o')
    {
        letterCount++;
    }
}

string new_message = new String(message);

Console.WriteLine(new_message);
Console.WriteLine($"'o' appears {letterCount} times.");