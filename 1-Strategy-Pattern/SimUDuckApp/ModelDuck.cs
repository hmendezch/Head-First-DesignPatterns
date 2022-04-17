namespace SimUDuckApp;

public class ModelDuck: Duck
{
    public ModelDuck()
    {
        FlyBehavior = new FlyNoWay();
        QuackBehavior = new RealQuack();
    }

    public override void Display()
    {
        Console.WriteLine("I'm a model duck");
    }
}