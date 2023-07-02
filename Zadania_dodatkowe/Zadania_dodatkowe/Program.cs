Console.WriteLine("**********************");
Console.WriteLine("***** Calculator *****");
Console.WriteLine("**********************");
Console.WriteLine("*****    MENU    *****");
Console.WriteLine("**********************");
Console.WriteLine("* 1 - Addition       *");
Console.WriteLine("* 2 - Subtraction    *");
Console.WriteLine("* 3 - Multiplication *");
Console.WriteLine("* 4 - Division       *");
Console.WriteLine("**********************");
Console.WriteLine();

var number1Correct = false;
var number2Correct = false;
var operationCorrect = false;

var number1 = 0f;
var number2 = 0f;
var operationNumber = 0;

while (!(number1Correct && number2Correct && operationCorrect))  
{
    if (!number1Correct)  
    {
        Console.WriteLine("Enter the first number: ");
        if (float.TryParse(Console.ReadLine(), out float result1))
        {
            number1 = result1;
            number1Correct = true;
        }
        else
        {
            Console.WriteLine("You must enter the number!");
            continue;
        }
    }
    if (!number2Correct)
    {
        Console.WriteLine("Enter the second number: ");
        if (float.TryParse(Console.ReadLine(), out float result2))
        {
            number2 = result2;
            number2Correct = true;
        }
        else
        {
            Console.WriteLine("You must enter the number!");
            continue;
        }
    }
    if (!operationCorrect)
    {
        Console.WriteLine("Enter the operation number from the MENU: ");
        if(int.TryParse(Console.ReadLine(), out int result3))
        {
            operationNumber = result3;
            operationCorrect = true;
        }
        else
        {
            Console.WriteLine("You must enter the number!");
            continue;
        }

        switch (operationNumber) 
        {
            case 1:
                {
                    var additionScore = number1 + number2;
                    Console.WriteLine($"The result of adding is {additionScore}");
                    break;
                }
            case 2:
                {
                    var subtractionScore = number1 - number2;
                    Console.WriteLine($"The result of subtraction is {subtractionScore}");
                    break;
                }
            case 3:
                {
                    var multiplicationScore = number1 * number2;
                    Console.WriteLine($"The result of multiplication is {multiplicationScore}");
                    break;
                }
            case 4:
                {
                    if (number2 != 0)
                    {
                        var divisionScore = number1 / number2;
                        Console.WriteLine($"The result of division is {divisionScore:N2}");
                    }
                    else
                    {
                        Console.WriteLine("Division by zero is not allowed!");
                    }
                    break;
                }
            default: 
                {
                    Console.WriteLine("No such option in the Menu!");
                    break;
                }


        }
    }
}


