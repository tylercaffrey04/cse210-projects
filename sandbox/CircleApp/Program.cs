using System.Formats.Asn1;

class Program
{
    public static void Main(string[] args)
    {
        Circle myCircle = new Circle();
        myCircle.SetRadius(10);
        double area = myCircle.GetArea();
        Console.WriteLine(area);

        Cylinder myCylinder = new Cylinder();
        myCylinder._circle = new Circle();
        myCylinder._circle._radius = 10;
        double volume = myCylinder.GetCylinderVolume();
        Console.WriteLine(volume);
    }

}