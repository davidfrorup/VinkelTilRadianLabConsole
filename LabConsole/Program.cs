

Console.WriteLine("Indtast en vinkel i grader:");

string input = Console.ReadLine();


if (Int32.TryParse(input, out int grader))
{
    double radians = DegreesToRadians(grader);

    Console.WriteLine($"{grader} grader er {radians} radianer.");
}
else
{
    Console.WriteLine("Ugyldigt input. Indtast venligst et heltal.");
}
        
        static double DegreesToRadians(int grader)
{
    return grader * Math.PI / 180.0;
}