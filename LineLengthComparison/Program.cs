using LineLengthComparison;
class program
{
    static void Main(string[] args)
    {
        LineLengthComputation lineLength = new LineLengthComputation();
        double length = lineLength.CalculateLength(5, 8, 9, 10);
        Console.WriteLine(length);
    }
}