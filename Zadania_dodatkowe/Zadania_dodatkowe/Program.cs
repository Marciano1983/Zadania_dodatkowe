// Napisz program, który znajdzie maksymalną liczbę
// spośród trzech podanych liczb.

// Wersja 1 - działa dla liczb dodatnich.
var a1 = 1;
var b1 = 5;
var c1 = 3;

var max = 0;

if(a1 > max)
{
    max = a1;
}

if(b1 > max)
{
    max = b1;
}

if(c1 > max)
{
    max = c1;
}

Console.WriteLine("Maksymalna liczba spośród trzech podanych to {0}.", max);

// Wersja 2 - działa dla liczb ujemnych i dodatnich.
var a2 = -5;
var b2 = 2;
var c2 = 4;
var numbers = new List<int>() { a2, b2, c2};

var maxx = numbers.Max();
Console.WriteLine("Maksymalna liczba spośród trzech podanych to {0}.", maxx);