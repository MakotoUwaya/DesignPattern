using System;

namespace State
{
    public class HasQuarterState : IState
    {
        private GumballMachine gumballMachine;
        private Random randomWinner = new Random(Environment.TickCount);

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
            var winner = this.randomWinner.Next(10).Equals(0);
            if (winner && 1 < this.gumballMachine.BallCount)
            {
                this.gumballMachine.SetState(this.gumballMachine.WinnerState);
                return;
            }
            this.gumballMachine.SetState(this.gumballMachine.SoldState);
        }

        public void Dispense()
        {
            Console.WriteLine("販売するガムボールはありません");
        }
    }
}
