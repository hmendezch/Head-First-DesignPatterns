namespace SimUDuckApp;

public class MallardDuck: Duck
{
    public MallardDuck()
    {
        QuackBehavior = new RealQuack();
        FlyBehavior = new FlyWithWings();
    }
    public override void Display()
    {
        Console.WriteLine("I'm a real Mallard duck");
    }
}