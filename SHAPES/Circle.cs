namespace SHAPES;

//CLASE CIRCLE QUE HEREDA DE SHAPE
public class Circle : Shape
{
    public Circle(double radio) : base(radio, radio) { }

    public override double CalculateSurface()
    {
        return Math.PI * Ancho * Ancho;
    }
}
