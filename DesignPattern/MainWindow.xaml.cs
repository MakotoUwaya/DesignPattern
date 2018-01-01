﻿using System;
using System.Windows;

using Strategy.Model;

using Observer.Model;

using Decorator;
using Decorator.Drink;
using Decorator.Topping;

using Factory;
using Factory.Model.Ingredient;

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
    }
}
