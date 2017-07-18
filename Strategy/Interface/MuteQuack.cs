using System;
using Strategy.Behavior.Interface;

namespace Strategy.Behavior
{
  public class MuteQuack : IQuackBehavior
  {
    public void Quack()
    {
      Console.WriteLine("何もしない。鳴けない！");
    }
  }
}
