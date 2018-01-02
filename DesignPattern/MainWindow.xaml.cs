using System;
using System.Windows;

using Strategy.Model;

using Observer.Model;

using Decorator;
using Decorator.Drink;
using Decorator.Topping;

using Factory;
using Factory.Model.Ingredient;
using Singleton;
using Command;

namespace DesignPattern
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void StrategyTest_Click(object sender, RoutedEventArgs e)
        {
            DuckBase[] ducks =
            {
        new MallarDuck(),
        new RubberDuck()
      };

            foreach (var duck in ducks)
            {
                duck.Swim();
                duck.PerformFly();
                duck.PerformQuack();
            }

        }

        private void ObserverTest_Click(object sender, RoutedEventArgs e)
        {
            var subject = new Subject();
            var unsbscriber1 = subject.Subscribe(new Observer.Model.Observer("Kongo"));
            var unsbscriber2 = subject.Subscribe(new Observer.Model.Observer("Hiei"));
            var unsbscriber3 = subject.Subscribe(new Observer.Model.Observer("Haruna"));
            var unsbscriber4 = subject.Subscribe(new Observer.Model.Observer("Kirishima"));

            subject.Deliver("資材を発見しました！");
            unsbscriber1.Dispose();
            subject.Deliver(null);
            subject.Deliver("新たな海域に出撃できます。");
            unsbscriber2.Dispose();
            subject.StopDelivering();
            subject.Deliver("これは通知されないニュース");
            unsbscriber3.Dispose();
            unsbscriber4.Dispose();
        }

        private void DecoratorTest_Click(object sender, RoutedEventArgs e)
        {
            Beverage beverage1 = new Espresso();
            PrintBeverage(beverage1);

            Beverage beverage2 = new DarkRoast();
            beverage2 = new Mocha(beverage2);
            beverage2 = new Mocha(beverage2);
            beverage2 = new Whip(beverage2);
            PrintBeverage(beverage2);

            Beverage beverage3 = new HouseBlend();
            beverage3 = new Soy(beverage3);
            beverage3 = new Mocha(beverage3);
            beverage3 = new Whip(beverage3);
            PrintBeverage(beverage3);
        }

        private void PrintBeverage(Beverage beverage)
        {
            Console.WriteLine($"{beverage.GetDescription()} ${beverage.Cost()}");
        }

        private void FactoryTest_Click(object sender, RoutedEventArgs e)
        {
            var nyPizzaIngredientFactory = new NYPizzaIngredientFactory();
            var nyPizzaStore = new NYStylePizzaStore(nyPizzaIngredientFactory);
            var chicagopizzaStore = new ChicagoStylePizzaStore(nyPizzaIngredientFactory);

            Console.WriteLine();
            var pizza1 = nyPizzaStore.OrderPizza("cheese");
            Console.WriteLine($"1つ目の注文は {pizza1.Name} です");

            Console.WriteLine();
            var pizza2 = chicagopizzaStore.OrderPizza("cheese");
            Console.WriteLine($"2つ目の注文は {pizza2.Name} です");
        }

        private void Singleton_Click(object sender, RoutedEventArgs e)
        {
            var instance1 = ChocolateBoiler.Instance;
            var instance2 = ChocolateBoiler.Instance;

            instance1.Fill();
            Console.WriteLine($"I1:{instance1.ToString()} I2:{instance2.ToString()}");
            instance2.Boil();
            Console.WriteLine($"I1:{instance1.ToString()} I2:{instance2.ToString()}");
            instance1.Drain();
            Console.WriteLine($"I1:{instance1.ToString()} I2:{instance2.ToString()}");
        }

        private void Command_Click(object sender, RoutedEventArgs e)
        {
            var remoteControl = new RemoteControl();
            var light = new Light();
            var garageDoor = new GarageDoor();
            var stereo = new Stereo();

            var lightOn = new LightOnCommand(light);
            var lightOff = new LightOffCommand(light);
            var garageOpen = new GarageDoorOpenCommand(garageDoor);
            var garageClose = new GarageDoorCloseCommand(garageDoor);
            var stereoOn = new StereoOnWithCdCommand(stereo);
            var stereoOff = new StereoOffWithCdCommand(stereo);

            remoteControl.SetCommand(0, lightOn, lightOff);
            remoteControl.SetCommand(1, garageOpen, garageClose);
            remoteControl.SetCommand(2, stereoOn, stereoOff);

            remoteControl.SetCommand(6, 
                new MacroCommand(new ICommand[] { lightOn, garageOpen, stereoOn }), 
                new MacroCommand(new ICommand[] { lightOff, garageClose, stereoOff }));

            Console.WriteLine(remoteControl.ToString());
        }

        private void Adapter_Click(object sender, RoutedEventArgs e)
        {
            var duck = new Adaptor.MallardDuck();
            var turkey = new Adaptor.WildTurkey();
            var turkeyAdapter = new Adaptor.TurkeyAdapter(turkey);

            Console.WriteLine("Duck の出力------");
            this.TestDuck(duck);

            Console.WriteLine("Turkey の出力------");
            this.TestDuck(turkeyAdapter);            
        }

        private void TestDuck(Adaptor.IDuck duck)
        {
            duck.Quack();
            duck.Fly();
        }
    }
}
