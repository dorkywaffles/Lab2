using ConsoleTables;
Question1();
Question2();
Question3();
Question4();

// #1: Print the output of adding two numbers from user input.
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
    Console.WriteLine();
    Console.WriteLine("Enter a number: ");
    int num1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Multiply {num1} by: ");
    int num2 = Convert.ToInt32(Console.ReadLine());

    for (int i = 0; i <= num2; i++)
    {
        Console.WriteLine($"{num1} * {i} = {(num1 * i)}");
    }
}

// #3: Output the number of bytes in memory that each of the following
// number types uses and the minimum and maximum values they can have:
// sbyte, byte, short, ushort, int, uint, long, ulong, float, double, and decimal.
static void Question3()
{
    Console.WriteLine();
    Console.WriteLine("Byte Table");
    ConsoleTable table = new ConsoleTable("Type", "Byte(s) of memory", "Min", "Max");
    table.AddRow("sbyte", sizeof(sbyte), sbyte.MinValue, sbyte.MaxValue);
    table.AddRow("byte", sizeof(byte), byte.MinValue, byte.MaxValue);
    table.AddRow("short", sizeof(short), short.MinValue, short.MaxValue);
    table.AddRow("ushort", sizeof(ushort), ushort.MinValue, ushort.MaxValue);
    table.AddRow("int", sizeof(int), int.MinValue, int.MaxValue);
    table.AddRow("uint", sizeof(uint), uint.MinValue, uint.MaxValue);
    table.AddRow("long", sizeof(long), long.MinValue, long.MaxValue);
    table.AddRow("ulong", sizeof(ulong), ulong.MinValue, ulong.MaxValue);
    table.AddRow("float", sizeof(float), float.MinValue, float.MaxValue);
    table.AddRow("double", sizeof(double), double.MinValue, double.MaxValue);
    table.AddRow("decimal", sizeof(decimal), decimal.MinValue, decimal.MaxValue);
    Console.WriteLine(table);
}

// #4: Create a 5 function (+, -, *, /, and modulus) calculator. This calculator should
// loop until ‘esc’ is typed. For example, I should be asked for num 1, then some operation
// (+, -, *, /, and modulus) to another num 2. Provide the results, and then provide a way
// to esc the program or do another operation (+, -, *, /, and modulus) to the result.
static void Question4()
{
    string input;
    do
    {
        Console.WriteLine("Enter a number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Enter an operator(+, -, *, /, %): ");
        string symbol = Console.ReadLine();
        int num2;
        switch(symbol)
        {
            case "+":
                Console.WriteLine("Enter a number to add: ");
                num2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"{num1} + {num2} = {(num1 + num2)}");
                break;
            case "-":
                Console.WriteLine("Enter a number to subtract: ");
                num2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"{num1} - {num2} = {(num1 - num2)}");
                break;
            case "*":
                Console.WriteLine("Enter a number to multiply by: ");
                num2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"{num1} * {num2} = {(num1 * num2)}");
                break;
            case "/":
                Console.WriteLine("Enter a number to divide by: ");
                num2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"{num1} / {num2} = {(num1 / num2)}");
                break;
            case "%":
                Console.WriteLine("Enter a number to mod by: "); // honestly not sure if this is correct but whatever
                num2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"{num1} % {num2} = {(num1 % num2)}");
                break;
            default:
                Console.WriteLine("Invalid operator.");
                break;
        }
        Console.WriteLine("Escape or continue(esc, cont)? ");
        input = Console.ReadLine();
    } while (input == "cont");
}