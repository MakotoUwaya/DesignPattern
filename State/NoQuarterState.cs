using System;

namespace State
{
    public class NoQuarterState : IState
    {
        private GumballMachine gumballMachine;

        public NoQuarterState(GumballMachine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }

        public void InsertQuater()
        {
            Console.WriteLine("25セントを投入しました");
            this.gumballMachine.SetState(this.gumballMachine.HasQuarterState);
        }

        public void EjectQuater()
        {
            Console.WriteLine("25セントを投入していません");
        }

        public void TurnCrank()
        {
            Console.WriteLine("クランクを回しましたが、25セントを投入していません");
        }

        public void Dispense()
        {
            Console.WriteLine("まず支払いをする必要があります");
        }
    }
}
