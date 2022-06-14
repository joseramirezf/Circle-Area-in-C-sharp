double pi = 3.14D;

int radius;
Console.WriteLine("Enter the radius of the circle");
radius = int.Parse(Console.ReadLine());

Console.WriteLine("The area of the circle is:");
Console.WriteLine((Math.Pow(radius, 2)) * pi);
