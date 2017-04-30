using System;
using Strategy.Behavior.Interface;

namespace Strategy.Behavior
{
  public class NormalQuack : IQuackBehavior
  {
    public void Quack()
    {
      Console.WriteLine("がーがー");
    }
  }
}
