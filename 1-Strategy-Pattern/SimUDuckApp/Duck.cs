namespace SimUDuckApp;

public abstract class Duck
{
    protected IFlyBehavior FlyBehavior;
    protected IQuackBehavior QuackBehavior;

    public Duck()
    {
    }

    public abstract void Display();

    public void PerformFly()
    {
        FlyBehavior.Fly();
    }

    public void PerformQuack()
    {
        QuackBehavior.Quack();
    }

    public void Swing()
    {
        Console.WriteLine("All ducks float, even decoys!");
    }


    public void SetFlyBehavior(IFlyBehavior fb)
    {
        FlyBehavior = fb;
    }

    public void SetQuackBehavior(IQuackBehavior qb)
    {
        QuackBehavior = qb;
    }
}