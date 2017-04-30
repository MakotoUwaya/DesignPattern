using System;
using Strategy.Behavior;

namespace Strategy.Model
{
  public class MallarDuck : DuckBase
  {
    public MallarDuck()
    {
      this.SetFlyBehavior(new FlyWithWings());
      this.SetQuackBehavior(new NormalQuack());
    }

    public override void Display()
    {
      Console.WriteLine("本物のマガモです。");
    }


  }
}
