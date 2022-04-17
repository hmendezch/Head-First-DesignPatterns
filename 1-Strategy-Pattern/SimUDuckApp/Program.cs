// See https://aka.ms/new-console-template for more information

using SimUDuckApp;

Duck mallard = new MallardDuck();
mallard.PerformQuack();
mallard.PerformFly();

Duck model = new ModelDuck();
model.PerformFly();
model.SetFlyBehavior(new FlyRocketPowered());//page 21
model.PerformFly();

Console.ReadLine();
