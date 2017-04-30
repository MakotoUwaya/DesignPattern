using System;
using Strategy.Behavior.Interface;

namespace Strategy.Behavior
{
  public class FlyNoWay : IFlyBehavior
  {
    public void Fly()
    {
      Console.WriteLine("何もしない。飛べません。");
    }
  }
}
