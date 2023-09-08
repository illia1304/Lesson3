//first task
Console.WriteLine("Enter number x:");
int x;
bool NumberX = int.TryParse(Console.ReadLine(), out x);
Console.WriteLine("Enter number y:");
int y;
bool NumberY = int.TryParse(Console.ReadLine(), out y);

if(!NumberX || !NumberY)
{
    Console.WriteLine("You didn't enter a number");
    Console.WriteLine("I refuse to work!!!");
    return;
}

int sum = 0, temp = x;

if (x == y)
    sum = x;

if (y < x)
{
    temp = y;
}

for (int i = 0; i < temp; i++)
    sum += i;

Console.WriteLine(sum);

//second task

int sumO = 0;
int sumE = 0;
if (x == y)
{
    if (x % 2 == 0)
        Console.WriteLine($"sum of even numbers = {x}");
    else
        Console.WriteLine($"sum of odd numbers = {x}");
}
    
else if (x > y)
{
    for (int i = y; i <= x; i++)
    {
        if (i % 2 == 0)
            sumE += i;
        else
            sumO += i;
    }
}
else
{
    for (int i = x; i <= y; i++)
    {
        if (i % 2 == 0)
            sumE += i;
        else
            sumO += i;
    }
}

Console.WriteLine($"sum of even numbers = {sumE}");
Console.WriteLine($"sum of odd numbers = {sumO}");


