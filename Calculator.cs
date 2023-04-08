/*
Developer info :
Name : Galih Panji Hanindito
Team : GameDev 9
*/

// Variables
bool repeatProgram = true;


do
{
    double inputValue1;
    double inputValue2 = 0, calculationResult = 0;
    bool inputValue1IsValid, inputValue2IsValid;

    Console.WriteLine(" ");
    Console.WriteLine("|---------Simple Math Operation!---------|");
    Console.WriteLine("|---------------How to use---------------|");
    Console.WriteLine("Step 1 = Input Value 1");
    Console.WriteLine("Step 2 = Input Math Operation");
    Console.WriteLine("Step 3 = Input Value 2");
    Console.WriteLine("Step 4 = Get Result");
    Console.WriteLine("For Decimal input use coma ( , )");
    Console.WriteLine("Enjoy Your Program :D \n");

    // Input Value1
    do
    {
        Console.Write("Value 1 : ");
        inputValue1IsValid = double.TryParse(Console.ReadLine(), out inputValue1);

        if (!inputValue1IsValid)
        {
            Console.WriteLine("Invalid input.");
        }

    } while (!inputValue1IsValid);

    // Input Math Operation and Check Validation
    string? mathOperation;
    do
    {
        Console.Write("Operator (+ - x /) : ");
        mathOperation = Console.ReadLine();

        switch (mathOperation)
        {
            case "+" or "-" or "*" or "x" or "/":

                // Input Value2
                do
                {
                    Console.Write("Value 2 : ");
                    inputValue2IsValid = double.TryParse(Console.ReadLine(), out inputValue2);

                    if (!inputValue2IsValid)
                    {
                        Console.WriteLine("Invalid input.");
                    }

                } while (!inputValue2IsValid);

                // switch method based on operation input
                switch (mathOperation)
                {
                    case "+":
                        calculationResult = Addition(inputValue1, inputValue2);
                        break;

                    case "-":
                        calculationResult = Subtraction(inputValue1, inputValue2);
                        break;

                    case "x" or "*":
                        calculationResult = Multiplication(inputValue1, inputValue2);
                        break;

                    case "/":
                        calculationResult = Division(inputValue1, inputValue2);
                        break;
                }
                break;

            // Repeat if input is invalid
            default:
                Console.WriteLine("Invalid Input");
                mathOperation = null;
                break;
        }

    } while (mathOperation is null);

    // Print Out result
    Console.WriteLine(" ");
    Console.WriteLine("Problem = " + inputValue1 + " " + mathOperation + " " + inputValue2);
    Console.Write("Result = " + calculationResult);
    Console.WriteLine("\n");

    // Function To Repeat The Program
    string? wantToRepeatProgram;
    do
    {
        Console.Write("Calculate Again? (Y/N) :");

        wantToRepeatProgram = Console.ReadLine();

        switch (wantToRepeatProgram)
        {
            case "Y" or "y" or "yes" or "Yes" or "YES":
                repeatProgram = true;
                break;

            case "N" or "n" or "no" or "No" or "NO":
                repeatProgram = false;
                break;

            default:
                Console.WriteLine("Invalid Input");
                wantToRepeatProgram = null;
                break;
        }

    } while (wantToRepeatProgram is null);

} while (repeatProgram);


// Math Method
double Addition (double value1, double value2)
{
    return value1 + value2;
}

double Subtraction (double value1, double value2)
{
    return value1 - value2;
}

double Multiplication (double value1, double value2)
{
    return value1 * value2;
}

double Division (double value1, double value2)
{
    return value1 / value2;
}
