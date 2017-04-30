using System;
using Strategy.Behavior;

namespace Strategy.Model
{
  public class RubberDuck : DuckBase
  {
    public override void Display()
    {
      Console.WriteLine("ゴムのアヒルです！");
    }

    public RubberDuck()
    {
      this.SetFlyBehavior(new FlyNoWay());
      this.SetQuackBehavior(new Squack());
    }
  }
}
