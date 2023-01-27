int iteration = int.Parse(Console.ReadLine());
int capacity = 255;
int sum = 0;

for (int i = 0;i < iteration; i++)
{
    int liters = int.Parse(Console.ReadLine());
	if (liters <= capacity - sum)
	{
		sum += liters;
	}
	else
	{
		Console.WriteLine("Insufficient capacity!");
	}
}
Console.WriteLine(sum);