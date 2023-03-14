using System.ComponentModel.Design;

/* coordinate input values */
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

/* ensure that the input data does not form a dot or a line */
if (x1 == x2 && x2 == x3 || y1 == y2 && y2 == y3)
{
    Console.WriteLine("Invalid input");
}
else /* if the coordinates do not form a point or a line we continue */
{
    /* distance calculation for each side of the triangle */
    double distanceAB = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
    double distanceBC = Math.Sqrt(Math.Pow((x3 - x2), 2) + Math.Pow((y3 - y2), 2));
    double distanceAC = Math.Sqrt(Math.Pow((x3 - x1), 2) + Math.Pow((y3 - y1), 2));

    /* perimeter calculation */
    double perimeter = distanceAB + distanceBC + distanceAC;

    /* output data of the length of each side */
    Console.WriteLine("Length of AB is: " + distanceAB);
    Console.WriteLine("Length of BC is: " + distanceBC);
    Console.WriteLine("Length of AC is: " + distanceAC);
    Console.Write(System.Environment.NewLine);

    /* algorithm to know what kind of triangle it is */
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

    /* hypotenuse calculation of each side to compare with 0 */
    double hypotenuseBCSide = Math.Pow(distanceBC, 2) - (Math.Pow(distanceAB, 2) + Math.Pow(distanceAC, 2));
    double hypotenuseABSide = Math.Pow(distanceAB, 2) - (Math.Pow(distanceBC, 2) + Math.Pow(distanceAC, 2));
    double hypotenuseACSide = Math.Pow(distanceAC, 2) - (Math.Pow(distanceAB, 2) + Math.Pow(distanceBC, 2));

        /* precision to know if it is a right triangle */
    if (hypotenuseBCSide <= 0.0000000001 && hypotenuseBCSide >= -0.0000000001)
    {
        Console.WriteLine("Triangle IS 'Right'");
    }
    else if (hypotenuseABSide <= 0.0000000001 && hypotenuseABSide >= -0.0000000001)
    {
        Console.WriteLine("Triangle IS 'Right'");
    }
    else if (hypotenuseACSide <= 0.0000000001 && hypotenuseACSide >= -0.0000000001)
    {
        Console.WriteLine("Triangle IS 'Right'");
    }
    else
    {
        Console.WriteLine("Triangle IS NOT 'Right'");
    }

    Console.Write(System.Environment.NewLine);

    /* perimeter output */
    Console.WriteLine("Perimeter: " + perimeter);

    Console.Write(System.Environment.NewLine);

    /* even numbers output */
    for (int i = 0; i <= perimeter; i++)
    {
        if (i % 2 == 0)
        {
            Console.WriteLine(i);
        }
    }
}
