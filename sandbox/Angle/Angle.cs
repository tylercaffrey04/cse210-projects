class Angle
{
    private double _radians;

    public Angle()
    {
        _radians = 0;
    }
    public Angle(double radians)
    {
        _radians = radians; 
    }
    public Angle(int degrees)
    {
        _radians = ToRadians(degrees);
    }

    public void SetRadians(double radian)
    {
        _radians = radian;
    }
    public double GetRadians()
    {
        return _radians;
    }
    private double ToRadians(int degrees)
    {
        return degrees / 180.0 * Math.PI;

    }
}