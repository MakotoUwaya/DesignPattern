using System;
using Strategy.Behavior.Interface;

namespace Strategy.Behavior
{
  public class Squack : IQuackBehavior
  {
    public void Quack()
    {
      Console.WriteLine("きゅーきゅー");
    }
  }
}
