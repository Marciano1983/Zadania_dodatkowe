// Gra w zgadywanie liczby

Random random = new Random();
var random_number = random.Next(0, 101);
var attemts_number = 1;

while (true)
{
    Console.Write("Guess the drawn number: ");
    var guessed_number = int.Parse(Console.ReadLine());

    if (guessed_number == random_number)
    {
        Console.WriteLine("Congratulations! You guessed it {0} times!", attemts_number);
        break;
    }
    else if (guessed_number > random_number)
    {
        Console.WriteLine("Enter a lower number...");
        attemts_number++;
    }
    else if (guessed_number < random_number)
    {
        Console.WriteLine("Enter a higher number...");
        attemts_number++;
    }
};
