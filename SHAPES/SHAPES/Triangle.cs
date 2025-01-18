namespace SHAPES;

//CLASE TRIANGLE QUE HEREDA DE SHAPE
public class Triangle : Shape
{
    public Triangle(double ancho, double alto) : base(ancho, alto) { }

    public override double CalculateSurface()
    {
        return (Ancho * Alto) / 2;
    }
}
