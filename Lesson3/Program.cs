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

int sum = 0;

if (x == y)
    sum = x;
else if(x > y)
{
    for(int i = y; i <= x; i++)
    {
        sum += i;
    }
}
else
{
    for(int i = x; i <= y; i++)
    {
        sum += i;
    }
}

Console.WriteLine(sum);

