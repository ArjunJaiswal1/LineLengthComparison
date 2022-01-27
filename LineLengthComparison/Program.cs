using LineLengthComparison;
class program
{
    static void Main(string[] args)
    {
        LineLengthComputation lineLength = new LineLengthComputation();
        double length = lineLength.CalculateLength(5, 8, 9, 10);
        Console.WriteLine(length);
        int a1 = 4, b1 = 4,
          c1 = 3, a2 = -6,
          b2 = 2, c2 = 9;
        lineLength.Compare(a1, b1, c1, a2, b2, c2);


    }
}
    
