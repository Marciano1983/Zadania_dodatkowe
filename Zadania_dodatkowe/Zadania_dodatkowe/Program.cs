// Napisz program, który odwróci liczbę (np. 1234 na 4321).

// I sposób
var number = 5362;

var numberToString = number.ToString();  // "5362"

var stringToArray  = numberToString.ToArray();  // ['5', '3', '6', '2']

var tab = stringToArray.Reverse(); // ['2', '6', '3', '5']

foreach (var item in tab)
{
    Console.Write(item); 
}

Console.WriteLine(); // odstęp w konsoli 

// II sposób 
var numberr = 5362;

var numberrToString = numberr.ToString();  // "5362"

var numberrLength = numberrToString.Length; // 4


for (int i = numberrLength - 1; i >= 0; i--)
{
    Console.Write(numberrToString[i]);
}


