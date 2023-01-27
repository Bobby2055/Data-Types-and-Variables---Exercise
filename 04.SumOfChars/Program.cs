int count = int.Parse(Console.ReadLine());
int sum = 0;
for(int i = 0;i < count; i++)
{
    char n = char.Parse(Console.ReadLine());
    sum += n;
}
Console.WriteLine($"The sum equals: {sum}");