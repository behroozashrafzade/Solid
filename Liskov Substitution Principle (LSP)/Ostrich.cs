namespace Solid.Liskov_Substitution_Principle__LSP_;

public class Ostrich :Bird
{
    public override void Fly()
    {
        throw new NotImplementedException("این پرنده نمی تواند پرواز کن ");

    }
}