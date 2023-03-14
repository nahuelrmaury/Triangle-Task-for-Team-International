using System.ComponentModel.Design;

Console.WriteLine("Enter coordinate x of dot A:");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter coordinate y of dot A:");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter coordinate x of dot B:");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter coordinate y of dot B:");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter coordinate x of dot C:");
double x3 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter coordinate y of dot C:");
double y3 = Convert.ToDouble(Console.ReadLine());
Console.Write(System.Environment.NewLine);


double distanceAB = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
double distanceBC = Math.Sqrt(Math.Pow((x3 - x2), 2) + Math.Pow((y3 - y2), 2));
double distanceAC = Math.Sqrt(Math.Pow((x3 - x1), 2) + Math.Pow((y3 - y1), 2));
double perimeter = distanceAB + distanceBC + distanceAC;

Console.WriteLine("Length of AB is: " + distanceAB);
Console.WriteLine("Length of BC is: " + distanceBC);
Console.WriteLine("Length of AC is: " + distanceAC);
Console.Write(System.Environment.NewLine);

if (distanceAB == distanceBC && distanceBC == distanceAC && distanceAB == distanceAC)
{
    Console.WriteLine("Triangle IS NOT 'Isosceles'");
    Console.WriteLine("Triangle IS 'Equilateral'");
}
else if (distanceAB == distanceBC || distanceBC == distanceAC || distanceAB == distanceAC)
{
    Console.WriteLine("Triangle IS NOT 'Equilateral'");
    Console.WriteLine("Triangle IS 'Isosceles'");
}
else
{
    Console.WriteLine("Triangle IS NOT 'Equilateral'");
    Console.WriteLine("Triangle IS NOT 'Isosceles'");
}


double hypotenuse = Math.Pow(distanceBC, 2) - (Math.Pow(distanceAB, 2) + Math.Pow(distanceAC, 2));

if (hypotenuse <= 0.0000000001 && hypotenuse >= -0.0000000001)
{
    Console.WriteLine("Triangle IS 'Right'");
}
else
{
    Console.WriteLine("Triangle IS NOT 'Right'");
}

Console.Write(System.Environment.NewLine);

Console.WriteLine("Perimeter: " + perimeter);

Console.Write(System.Environment.NewLine);

for (int i = 0; i <= perimeter; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(i);
    }
}