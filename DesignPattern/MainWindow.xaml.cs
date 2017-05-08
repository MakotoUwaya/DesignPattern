using System.Windows;
using Strategy.Model;
using Observer.Model;

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
    }
}
