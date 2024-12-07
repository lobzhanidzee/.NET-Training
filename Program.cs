/* 
This code uses a names array and corresponding methods to display
greeting messages
*/

// string[] names = new string[] { "Sophia", "Andrew", "AllGreetings" };

// string messageText = "";

// foreach (string name in names)
// {
//     if (name == "Sophia")
//         messageText = SophiaMessage();
//     else if (name == "Andrew")
//         messageText = AndrewMessage();
//     else if (name == "AllGreetings")
//         messageText = SophiaMessage() + "\n\r" + AndrewMessage();

//     Console.WriteLine(messageText + "\n\r");
// }

// bool pauseCode = true;
// while (pauseCode == true) ;

// static string SophiaMessage()
// {
//     return "Hello, my name is Sophia.";
// }

// static string AndrewMessage()
// {
//     return "Hi, my name is Andrew. Good to meet you.";
// }

// SECOND TASK
// int productCount = 2000;
// string[,] products = new string[productCount, 2];

// LoadProducts(products, productCount);

// for (int i = 0; i < productCount; i++)
// {
//     string result;
//     result = Process1(products, i);

//     if (result != "obsolete")
//     {
//         result = Process2(products, i);
//     }
// }

// bool pauseCode = true;
// while (pauseCode == true) ;

// static void LoadProducts(string[,] products, int productCount)
// {
//     Random rand = new Random();

//     for (int i = 0; i < productCount; i++)
//     {
//         int num1 = rand.Next(1, 10000) + 10000;
//         int num2 = rand.Next(1, 101);

//         string prodID = num1.ToString();

//         if (num2 < 91)
//         {
//             products[i, 1] = "existing";
//         }
//         else if (num2 == 91)
//         {
//             products[i, 1] = "new";
//             prodID = prodID + "-n";
//         }
//         else
//         {
//             products[i, 1] = "obsolete";
//             prodID = prodID + "-0";
//         }

//         products[i, 0] = prodID;
//     }
// }

// static string Process1(string[,] products, int item)
// {
//     Console.WriteLine($"Process1 message - working on {products[item, 1]} product");

//     return products[item, 1];
// }

// static string Process2(string[,] products, int item)
// {
//     Console.WriteLine($"Process2 message - working on product ID #: {products[item, 0]}");
//     if (products[item, 1] == "new")
//         Process3(products, item);

//     return "continue";
// }

// static void Process3(string[,] products, int item)
// {
//     Console.WriteLine($"Process3 message - processing product information for 'new' product");
// }

// THIRD TASK
// string? readResult;
// int startIndex = 0;
// bool goodEntry = false;

// int[] numbers = { 1, 2, 3, 4, 5 };

// // Display the array to the console.
// Console.Clear();
// Console.Write("\n\rThe 'numbers' array contains: { ");
// foreach (int number in numbers)
// {
//     Console.Write($"{number} ");
// }

// // To calculate a sum of array elements, 
// //  prompt the user for the starting element number.
// Console.WriteLine($"}}\n\r\n\rTo sum values 'n' through 5, enter a value for 'n':");
// while (goodEntry == false)
// {
//     readResult = Console.ReadLine();
//     goodEntry = int.TryParse(readResult, out startIndex);

//     if (startIndex > 5)
//     {
//         goodEntry = false;
//         Console.WriteLine("\n\rEnter an integer value between 1 and 5");
//     }
// }

// // Display the sum and then pause.
// Console.WriteLine($"\n\rThe sum of numbers {startIndex} through {numbers.Length} is: {SumValues(numbers, startIndex - 1)}");

// Console.WriteLine("press Enter to exit");
// readResult = Console.ReadLine();

// // This method returns the sum of elements n through 5
// static int SumValues(int[] numbers, int n)
// {
//     int sum = 0;
//     for (int i = n; i < numbers.Length; i++)
//     {
//         sum += numbers[i];
//     }
//     return sum;
// }
// FOURHT TASK
// bool exit = false;
// var rand = new Random();
// int num1 = 5;
// int num2 = 5;

// do
// {
//     num1 = rand.Next(1, 11);
//     num2 = num1 + rand.Next(1, 51);

// } while (exit == false);

/*  
This code instantiates a value and then calls the ChangeValue method
to update the value. The code then prints the updated value to the console.
*/
int x = 5;

x = ChangeValue(x);

Console.WriteLine(x);

int ChangeValue(int value)
{
    value = 10;
    return value;
}