namespace SHAPES;

//CLASE ABSTRACTA SHAPE
public abstract class Shape
{
    protected double Ancho { get; set; }
    protected double Alto { get; set; }

    public Shape(double ancho, double alto)
    {
        Ancho = ancho;
        Alto = alto;
    }

    public abstract double CalculateSurface();
}
