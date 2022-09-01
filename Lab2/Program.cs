Question1();
Question2();

// #1: Print the output of adding two numbers from user input
static void Question1()
{
    Console.WriteLine("Enter a number: ");
    int num1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Enter a number to add to {num1}: ");
    int num2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"{num1} + {num2} = {(num1 + num2)}");
}

// #2: Take a user’s input number and input its multiplication table.
// The user can choose how high to multiply by.
static void Question2()
{
    Console.WriteLine("Enter a number: ");
    int num1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Multiply {num1} by: ");
    int num2 = Convert.ToInt32(Console.ReadLine());

    for (int i = 0; i <= num2; i++)
    {
        Console.WriteLine($"{num1} * {i} = {(num1 * i)}");
    }
}
