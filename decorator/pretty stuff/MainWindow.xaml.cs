using decorator;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace pretty_stuff;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    private ICoffee _coffee;
    public MainWindow()
    {
        InitializeComponent();
        _coffee = new Coffee();
    }

    private void Button_Click(object sender, RoutedEventArgs e)
    {
        if (sugar.IsChecked == true)
        {
            _coffee = new SugarDecorator(_coffee);
        }
        if (milk.IsChecked == true)
        {
            _coffee = new MilkDecorator(_coffee);
        }
        MessageBox.Show(_coffee.GetCoffeeType());
        _coffee = new Coffee();
    }

}