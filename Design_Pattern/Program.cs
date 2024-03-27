using System;
using System.Collections.Generic;
using Design_Pattern;

IComponent<string> component = new ConcreteComponent();
Console.WriteLine(component.GetText());

IComponent<string> plainDecorator = new PlainDecorator(component, "Hey Krishna, Did you give your driving test ?");
Console.WriteLine(plainDecorator.GetText());

IComponent<string> colorDecorator = new ColorDecorator(component);
Console.WriteLine(colorDecorator.GetText());

IComponent<string> upperCaseDecorator = new UpperCaseDecorator(component);
Console.WriteLine(upperCaseDecorator.GetText());
