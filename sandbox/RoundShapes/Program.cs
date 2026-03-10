namespace RoundShapes;

class Program
{
    static void Main(string[] args)
    {
        List<RoundShape> rolling_stones = new List<RoundShape>();
        rolling_stones.Add( new Circle(2.0));
        rolling_stones.Add( new Cylinder(10.0, 2.0));
        rolling_stones.Add( new Sphere(500));
        foreach (RoundShape shape in rolling_stones)
        {
            Console.WriteLine($"Area of shape: {shape.Area()}");
        }

        // Circle steve = new Circle(2.0);
        // Cylinder mike = new Cylinder(10.0, 2.0);
        // Sphere sully = new Sphere(500);
        // Console.WriteLine($"Area of steve: {steve.Area()}");
        // Console.WriteLine($"Area of mike: {mike.Area()}");
        // Console.WriteLine($"Area of sully: {sully.Area()}");
    }
}
