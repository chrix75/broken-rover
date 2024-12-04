using BrokenRover;

internal class Program
{
    private static void Main(string[] args)
    {
        var r = new Rover();
        r.SetX(2);
        r.SetY(3);
        r.SetOrientation("NORTH");

        r.process("LFFLFFF");

        Console.WriteLine("Rover X: " + r.GetX());
        Console.WriteLine("Rover Y: " + r.GetY());
        Console.WriteLine("Rover Orientation: " + r.GetOrientation());
    }
}