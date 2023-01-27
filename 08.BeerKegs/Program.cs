int numberOfKegs = int.Parse(Console.ReadLine());
string bestmodel = default;
double biggestVolume = 0;

for(int i = 0;i < numberOfKegs; i++)
{
    string model = Console.ReadLine();
    double radius = double.Parse(Console.ReadLine());
    int height = int.Parse(Console.ReadLine());

    double volume = Math.PI * Math.Pow(radius,2) * height;
    if (volume > biggestVolume)
    {
        biggestVolume = volume;
        bestmodel = model;
    }
}
Console.WriteLine(bestmodel);