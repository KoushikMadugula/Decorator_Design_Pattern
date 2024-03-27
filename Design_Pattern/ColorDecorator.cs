namespace Design_Pattern
{
public class ColorDecorator : Decorator<string>
{
    public ColorDecorator(IComponent<string> component) : base(component) { }

    public override string GetText()
    {
        return $"\u001b[31m{base.GetText()}\u001b[0m"; // This adds red color to the text
    }
}
}