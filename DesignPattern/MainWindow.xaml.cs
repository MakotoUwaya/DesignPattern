using Strategy.Model;
using System.Windows;

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
  }
}
