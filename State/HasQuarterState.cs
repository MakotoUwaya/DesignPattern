using System;

namespace State
{
    public class HasQuarterState : IState
    {
        private GumballMachine gumballMachine;

        public HasQuarterState(GumballMachine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }

        public void InsertQuater()
        {
            Console.WriteLine("もう一度25セントを投入することはできません");
        }

        public void EjectQuater()
        {
            Console.WriteLine("25セントを返却しました");
            this.gumballMachine.SetState(this.gumballMachine.NoQuarterState);
        }

        public void TurnCrank()
        {
            Console.WriteLine("クランクを回しました......");
            this.gumballMachine.SetState(this.gumballMachine.SoldState);
        }

        public void Dispense()
        {
            Console.WriteLine("販売するガムボールはありません");
        }
    }
}
