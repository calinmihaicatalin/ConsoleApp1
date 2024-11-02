
double num1;
double num2;
double result;
bool play = true;
Console.WriteLine("------------------");
Console.WriteLine("CALCULATOR PROGRAM");
Console.WriteLine("------------------");

do
{
    Console.Write("Enter number1: ");
    num1 = Convert.ToDouble(Console.ReadLine());

    Console.Write("Enter number2: ");
    num2 = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Enter an option: ");
    Console.WriteLine("\t+ : Add");
    Console.WriteLine("\t- : Substract");
    Console.WriteLine("\t* : Mutliplty");
    Console.WriteLine("\t/ : Divide");
    Console.Write("Enter an option: ");


    switch (Console.ReadLine())
    {
        case "+":
            result = num1 + num2;
            Console.WriteLine($"Your result: {num1} + {num2} = " + result);
            break;
        case "-":
            result = num1 - num2;
            Console.WriteLine($"Your result: {num1} - {num2} = " + result);
            break;
        case "*":
            result = num1 * num2;
            Console.WriteLine($"Your result: {num1} * {num2} = " + result);
            break;
        case "/":
            result = num1 / num2;
            Console.WriteLine($"Your result: {num1} / {num2} = " + result);
            break;
        default:
            Console.WriteLine("That was not a valid option!");
            break;
    }
    Console.Write("Continue? y/n: ");
} while (Console.ReadLine().ToLower() == "y");
Console.WriteLine("Thanks for using the calculator!");
Console.ReadKey();