Question1();

static void Question1()
{
    Console.WriteLine("Enter a number: ");
    int num1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Enter a number to add to {num1}: ");
    int num2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"{num1} + {num2} = {(num1 + num2)}");
}
