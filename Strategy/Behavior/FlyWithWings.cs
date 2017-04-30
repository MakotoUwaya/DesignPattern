using System;
using Strategy.Behavior.Interface;

namespace Strategy.Behavior
{
  public class FlyWithWings : IFlyBehavior
  {
    public void Fly()
    {
      Console.WriteLine("飛んでいます！！");
    }
  }
}
