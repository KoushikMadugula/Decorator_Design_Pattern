namespace Design_Pattern
{
public class PlainDecorator : Decorator<string>
{
    string? _decorator = "Hey Krishna, Did you give your driving test ?";
    public PlainDecorator(IComponent<string> component, string decorator) : base(component) { 
         _decorator = decorator;
    }

    public override string GetText()
    {
        return _decorator + base.GetText();
    }
}
}
