namespace Solid.Single_Responsibility_Principle__SRP_.Open_Closed_Principle__OCP_;

public class Circle :Shape
{
    public double Radius { get; set; }

    public override double Area()
    {
        return Math.PI * Radius;
    }
}