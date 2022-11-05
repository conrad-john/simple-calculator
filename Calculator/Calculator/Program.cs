// Declare variables and then initialize to zero -- who wrote this, they're ints... they'll instantiate to 0 the moment we declare them since that's the default value
// can't critique too much... I am still doing this tutorial
int num1 = 0;
int num2 = 0;

// Display title as the C# console calculator app.
Console.WriteLine("Console Calculator in C#\r");
Console.WriteLine("------------------------\n");

// Ask the user to type the first number...
Console.WriteLine("Type a number, and then press Enter");
num1 = Convert.ToInt32(Console.ReadLine());

// Ask the user to type the second number...
Console.WriteLine("Type another number, and then press Enter");
num2 = Convert.ToInt32(Console.ReadLine());

// Ask the user to chose an option...
Console.WriteLine("Choose an option from the following list:");
Console.WriteLine("\ta - Add");
Console.WriteLine("\ts - Subtract");
Console.WriteLine("\tm - Multiply");
Console.WriteLine("\td - Divide");
Console.WriteLine("Your option? ");

// Use a switch statement to do the math...
switch(Console.ReadLine())
{
    case "a":
        Console.WriteLine($"Your result: {num1} + {num2} = {num1 + num2}");
        break;
    case "s":
        Console.WriteLine($"Your result: {num1} - {num2} = {num1 - num2}");
        break;
    case "m":
        Console.WriteLine($"Your result: {num1} * {num2} = {num1 * num2}");
        break;
    case "d":
        Console.WriteLine($"Your result: {num1} / {num2} = {num1 / num2}");
        break;
}

// Wait for the user to respond before closing...
Console.WriteLine("Press any key to close the Calculator console app...");
Console.ReadKey();