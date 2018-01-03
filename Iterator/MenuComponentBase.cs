using System;

namespace Iterator
{
    public abstract class MenuComponentBase
    {
        public abstract string Name { get; }
        public abstract string Description { get; }
        public abstract double Price { get; }
        public abstract bool Vegetarian { get; }

        public abstract void Print();
        public virtual void Add(MenuComponentBase menuComponent)
        {
            throw new NotSupportedException();
        }
        public virtual void Remove(MenuComponentBase menuComponent)
        {
            throw new NotSupportedException();
        }
        public virtual MenuComponentBase GetChild(int index)
        {
            throw new NotSupportedException();
        }
    }
}
