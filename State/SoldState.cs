using System;

namespace State
{
    public class SoldState : IState
    {
        private GumballMachine gumballMachine;

        public SoldState(GumballMachine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }

        public void InsertQuater()
        {
            Console.WriteLine("お待ちください。すでにガムボールを出しています");
        }

        public void EjectQuater()
        {
            Console.WriteLine("申し訳ありません。すでにクランクを回しています");
        }

        public void TurnCrank()
        {
            Console.WriteLine("2回回してもガムボールをもう1つ手に入れることはできません！");
        }

        public void Dispense()
        {
            this.gumballMachine.ReleaseBall();
            if (0 < this.gumballMachine.BallCount)
            {
                this.gumballMachine.SetState(this.gumballMachine.NoQuarterState);
                return;
            }

            Console.WriteLine("おっと、ガムボールが無くなりました！");
            this.gumballMachine.SetState(this.gumballMachine.SoldOutState);
        }
    }
}
