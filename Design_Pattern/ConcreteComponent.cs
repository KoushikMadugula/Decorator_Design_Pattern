namespace Design_Pattern
{
public class ConcreteComponent : IComponent<string>
{
    public string GetText()
    {
        return " I gave my G2 recently.";
    }
}
}