using System;
using Strategy.Behavior.Interface;

namespace Strategy.Model
{
  public abstract class DuckBase
  {
    protected string DisplayName;

    public void Swim()
    {
      Console.WriteLine("全ての鴨は浮かびます。おとりの鴨でも！");
    }

    public abstract void Display();

    private IFlyBehavior flyBehavior;
    private IQuackBehavior quackBehavior;

    public void PerformFly()
    {
      this.flyBehavior?.Fly();
    }

    public void PerformQuack()
    {
      this.quackBehavior?.Quack();
    }

    public void SetFlyBehavior(IFlyBehavior behavior)
    {
      this.flyBehavior = behavior;
    }

    public void SetQuackBehavior(IQuackBehavior behavior)
    {
      this.quackBehavior = behavior;
    }
  }
}
