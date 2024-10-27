// THIRD - TASK
string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
int stringsCount = myStrings.Length;

string myString = "";
int periodLocation = 0;

for (int i = 0; i < stringsCount; i++)
{
    myString = myStrings[i];
    periodLocation = myString.IndexOf(".");

    string mySentence;

    while (periodLocation != -1)
    {
        mySentence = myString.Remove(periodLocation);

        myString = myString.Substring(periodLocation + 1).TrimStart();

        periodLocation = myString.IndexOf(".");

        Console.WriteLine(mySentence);
    }

    mySentence = myString.Trim();
    Console.WriteLine(mySentence);
}


// SECOND - TASK
// string? readResult;
// bool validEntry = false;

// Console.WriteLine("Enter your role name (Administrator, Manager, or User)");

// do
// {
//     readResult = Console.ReadLine();

//     if (readResult != null)
//     {
//         string validResult = readResult.ToLower().Trim();
//         switch (validResult)
//         {
//             case "administrator":
//                 Console.WriteLine("Your input value (Administrator) has been accepted.");
//                 validEntry = true;
//                 break;
//             case "manager":
//                 Console.WriteLine("Your input value (Manager) has been accepted.");
//                 validEntry = true;
//                 break;
//             case "user":
//                 Console.WriteLine("Your input value (User) has been accepted.");
//                 validEntry = true;
//                 break;

//             default:
//                 Console.WriteLine($"The role name that you entered, {readResult} is not valid. Enter your role name (Administrator, Manager, or User)");
//                 break;
//         }
//     }
// } while (!validEntry);

// FIRST - TASK
// string? readResult;
// int numericValue = 0;
// bool validEntry = false;
// bool validNumber = false;

// Console.WriteLine("Enter an integer value between 5 and 10");

// do
// {
//     readResult = Console.ReadLine();

//     if (readResult != null)
//     {
//         validNumber = int.TryParse(readResult, out numericValue);
//         if (!validNumber)
//         {
//             Console.WriteLine("Sorry, you entered an invalid number, please try again");
//         }
//         else if (numericValue < 5 || numericValue > 10)
//         {
//             Console.WriteLine($"You entered {numericValue}. Please enter a number between 5 and 10.");
//         }
//         else
//         {
//             Console.WriteLine($"Your input value ({numericValue}) has been accepted.");
//             validEntry = true;
//         }
//     }

// } while (!validEntry);

// string? readResult;
// bool validEntry = false;
// Console.WriteLine("Enter a string containing at least three characters:");
// do
// {
//     readResult = Console.ReadLine();
//     if (readResult != null)
//     {
//         if (readResult.Length >= 3)
//         {
//             validEntry = true;
//         }
//         else
//         {
//             Console.WriteLine("Your input is invalid, please try again.");
//         }
//     }
// } while (validEntry == false);


// int hero = 10;
// int monster = 10;

// Random dice = new Random();

// do
// {
//     int roll = dice.Next(1, 11);
//     monster -= roll;
//     Console.WriteLine($"Monster was damaged and lost {roll} health and now has {monster} health.");

//     if (monster <= 0) continue;

//     roll = dice.Next(1, 11);
//     hero -= roll;
//     Console.WriteLine($"Hero was damaged and lost {roll} health and now has {hero} health.");

// } while (hero > 0 && monster > 0);

// Console.WriteLine(hero > monster ? "Hero wins!" : "Monster wins!");


// do
// {
//     current = random.Next(1, 11);

//     if (current >= 8) continue;

//     Console.WriteLine(current);
// } while (current != 7);

// do
// {
//     current = random.Next(1, 11);
//     Console.WriteLine(current);
// } while (current != 7);

// while (current >= 3)
// {
//     Console.WriteLine(current);
//     current = random.Next(1, 11);
// }
// Console.WriteLine($"Last number: {current}");