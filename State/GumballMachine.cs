using System;

namespace State
{
    public class GumballMachine
    {
        public string MachineNumber;

        public IState SoldOutState { get; private set; }
        public IState NoQuarterState { get; private set; }
        public IState HasQuarterState { get; private set; }
        public IState SoldState { get; private set; }
        public IState WinnerState { get; private set; }

        public IState CurrentState { get; private set; }
        public int BallCount { get; private set; } = 0;

        public GumballMachine(string machineNumber, int numberGumballs)
        {
            this.MachineNumber = machineNumber;
            this.SoldOutState = new SoldOutState(this);
            this.NoQuarterState = new NoQuarterState(this);
            this.HasQuarterState = new HasQuarterState(this);
            this.SoldState = new SoldState(this);
            this.WinnerState = new WinnerState(this);

            this.BallCount = numberGumballs;
            if (0 < this.BallCount)
            {
                this.CurrentState = this.NoQuarterState;
                return;
            }
            this.CurrentState = this.SoldState;
        }

        public void InsertQuarter()
        {
            this.CurrentState.InsertQuater();
        }

        public void EjectQuarter()
        {
            this.CurrentState.EjectQuater();
        }

        public void TurnCrank()
        {
            this.CurrentState.TurnCrank();
            this.CurrentState.Dispense();
        }

        public void SetState(IState state)
        {
            this.CurrentState = state;
        }

        public void ReleaseBall()
        {
            Console.WriteLine("ガムボールがスロットから転がり出てきます......");
            if (this.BallCount != 0)
            {
                this.BallCount--;
            }
        }

        public void Fill(int ballCount)
        {
            Console.WriteLine($"ガムボールを補充しました:{this.BallCount}→{this.BallCount + ballCount}");
            this.BallCount += ballCount;
            if (this.CurrentState is SoldOutState && 0 < this.BallCount)
            {
                this.CurrentState = this.NoQuarterState;
            }
        }

        public override string ToString()
        {
            return $"Mighty Gumball, Inc.\nC#対応据付型ガムボールマシン モデル#{this.MachineNumber}\n在庫:{this.BallCount}個のガムボール";
        }
    }
}
