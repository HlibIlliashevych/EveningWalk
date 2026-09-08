
Console.WriteLine("Введiть три числа через пробiл:");

string input = Console.ReadLine();

if (String.IsNullOrEmpty(input)) {
    Console.WriteLine("Данi не можуть бути порожнiми");
    return;
}

string[] variables = input.Split(' ');
long a = long.Parse(variables[0]);
long b = long.Parse(variables[1]);
long c = long.Parse(variables[2]);

if (a >= b)
{
    Console.WriteLine("Доллар повинен бути дешевше за євро");
    return;
}

long dollars;

if (c <= 0)
{
    dollars = 0;
}
else
{
    dollars = (b * (c - 1)) / (b - a) + 1;
}

long result = dollars * a;

Console.WriteLine(result);
Console.ReadLine();