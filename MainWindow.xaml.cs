using System.Text;
using System.Text.RegularExpressions;
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
      double sum = 0;
      if (IsValid(tbx_ess.Text))
      {
        double esMl = double.Parse(tbx_ess.Text);
        sum += Math.Round(CoffeeCalculator.EsMl2Mg(esMl));
      }
      if (IsValid(tbx_V60.Text))
      {
        double vMl = double.Parse(tbx_V60.Text);
        sum += Math.Round(CoffeeCalculator.V60Ml2Mg(vMl));
      }

      lbl_CafCon.Content = sum + " mg of Caffeine";

    }

    private void tbx_ess_MouseDoubleClick(object sender, MouseButtonEventArgs e)
    {
      tbx_ess.Text = string.Empty;
    }

    private void tbx_V60_MouseDoubleClick(object sender, MouseButtonEventArgs e)
    {
      tbx_V60.Text = string.Empty;

    }
    private bool IsValid(string input)
    {
      if (input == "" || input.EndsWith("(ml)"))
        return false;

      return true;
    }

    private void tbx_ess_PreviewTextInput(object sender, TextCompositionEventArgs e)
    {
      Regex regex = new Regex("[^0-9]+");
      e.Handled = regex.IsMatch(e.Text);
    }

    private void tbx_V60_PreviewTextInput(object sender, TextCompositionEventArgs e)
    {
      Regex regex = new Regex("[^0-9]+");
      e.Handled = regex.IsMatch(e.Text);
    }
  }
}