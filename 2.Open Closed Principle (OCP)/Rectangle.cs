namespace Solid.Single_Responsibility_Principle__SRP_.Open_Closed_Principle__OCP_;

public class Rectangle : Shape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public override double Area()
    {
        return Width * Height;

    }
}
