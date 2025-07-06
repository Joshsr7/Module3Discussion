class Rectangle
{
    public double Length;
    public double Width;
}

class Program
{
    static void Main()
    {
        Rectangle r = new Rectangle();
        r.Length = 5.8;
        r.Width = 3.4;

        double area = r.Length * r.Width;
        Console.WriteLine("Area as double: " + area);

        int areaAsInt = (int)area; // Type casting from double to int
        Console.WriteLine("Area as int (after casting): " + areaAsInt);
    }
}
