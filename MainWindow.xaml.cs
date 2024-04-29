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

namespace CoffeeCounter
{
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window
  {
    public MainWindow()
    {
      InitializeComponent();
    }

    private void Button_Click(object sender, RoutedEventArgs e)
    {
      double esMl = double.Parse(tbx_ess.Text);
      double vMl = double.Parse(tbx_V60.Text);
      lbl_CafCon.Content = Math.Round(CoffeeCalculator.CalculateCaffeine(esMl, vMl)) + " mg of Caffeine";
    }

    private void tbx_ess_MouseDoubleClick(object sender, MouseButtonEventArgs e)
    {
      tbx_ess.Text = string.Empty;
    }

    private void tbx_V60_MouseDoubleClick(object sender, MouseButtonEventArgs e)
    {
      tbx_V60.Text = string.Empty;

    }
  }
}