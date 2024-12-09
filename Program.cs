// double float1 = 3000.0;
// double float2 = 0.0;
// int number1 = 3000;
// int number2 = 0;

// try
// {
//     Console.WriteLine(float1 / float2);
//     Console.WriteLine(number1 / number2);
// }
// catch
// {
//     Console.WriteLine("An exception has been caught");
// }

// Console.WriteLine("Exit program");

// try
// {
//     Process1();
// }
// catch
// {
//     Console.WriteLine("An exception has occurred");
// }

// Console.WriteLine("Exit program");

// static void Process1()
// {
//     WriteMessage();
// }

// static void WriteMessage()
// {
//     double float1 = 3000.0;
//     double float2 = 0.0;
//     int number1 = 3000;
//     int number2 = 0;

//     Console.WriteLine(float1 / float2);
//     Console.WriteLine(number1 / number2);
// }

// try
// {
//     Process1();
// }
// catch
// {
//     Console.WriteLine("An exception has occurred");
// }

// Console.WriteLine("Exit program");

// static void Process1()
// {
//     try
//     {
//         WriteMessage();

//     }
//     catch (DivideByZeroException ex)
//     {
//         Console.WriteLine($"Exception caught in Process1: {ex.Message}");
//     }
// }

// static void WriteMessage()
// {
//     double float1 = 3000.0;
//     double float2 = 0.0;
//     int number1 = 3000;
//     int number2 = 0;
//     byte smallNumber;

//     try
//     {
//         Console.WriteLine(float1 / float2);
//         Console.WriteLine(number1 / number2);
//     }
//     catch (DivideByZeroException ex)
//     {
//         Console.WriteLine($"Exception caught in WriteMessage: {ex.Message}");
//     }
//     checked
//     {
//         try
//         {
//             smallNumber = (byte)number1;
//         }
//         catch (OverflowException ex)
//         {
//             Console.WriteLine($"Exception caught in WriteMessage: {ex.Message}");
//         }
//     }
// }

// inputValues is used to store numeric values entered by a user
// string[] inputValues = new string[] { "three", "9999999999", "0", "2" };

// foreach (string inputValue in inputValues)
// {
//     int numValue = 0;
//     try
//     {
//         numValue = int.Parse(inputValue);
//     }
//     catch (FormatException)
//     {
//         Console.WriteLine("Invalid readResult. Please enter a valid number.");
//     }
//     catch (OverflowException)
//     {
//         Console.WriteLine("The number you entered is too large or too small.");
//     }
//     catch (Exception ex)
//     {
//         Console.WriteLine(ex.Message);
//     }
// }

try
{
    checked
    {
        try
        {
            int num1 = int.MaxValue;
            int num2 = int.MaxValue;
            int result = num1 + num2;
            Console.WriteLine("Result: " + result);
        }
        catch (OverflowException ex)
        {
            Console.WriteLine("Error: The number is too large to be represented as an integer. " + ex.Message);
        }
    }
    try
    {
        string str = null;

        int length = str.Length;
        Console.WriteLine("String Length: " + length);

    }
    catch (NullReferenceException ex)
    {
        Console.WriteLine("Error: The reference is null. " + ex.Message);
    }
    try
    {
        int[] numbers = new int[5];
        numbers[5] = 10;
        Console.WriteLine("Number at index 5: " + numbers[5]);

    }
    catch (IndexOutOfRangeException ex)
    {
        Console.WriteLine("Error: Index out of range. " + ex.Message);
    }
    try
    {
        int num3 = 10;
        int num4 = 0;
        int result2 = num3 / num4;
        Console.WriteLine("Result: " + result2);

    }
    catch (DivideByZeroException ex)
    {
        Console.WriteLine("Error: Cannot divide by zero. " + ex.Message);
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}


Console.WriteLine("Exiting program.");