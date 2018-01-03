using System;

namespace State
{
    public class SoldOutState : IState
    {
        private GumballMachine gumballMachine;

        public SoldOutState(GumballMachine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }

        public void InsertQuater()
        {
            Console.WriteLine("販売できるガムボールが無いので25セントを投入できません");
        }

        public void EjectQuater()
        {
            Console.WriteLine("25セントを投入していません");
        }

        public void TurnCrank()
        {
            Console.WriteLine("クランクを回しましたが、販売できるガムボールがありません");
        }

        public void Dispense()
        {
            Console.WriteLine("販売できるガムボールがありません");
        }
    }
}
