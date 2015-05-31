using System.Windows;

namespace Wizard
{
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow
  {
    public MainWindow()
    {
      InitializeComponent();
    }

    private void OnClickToBasket(object sender, RoutedEventArgs e)
    {
      CheckoutTabControl.SelectedIndex = 0;
    }

    private void OnClickToBillingInformation(object sender, RoutedEventArgs e)
    {
      CheckoutTabControl.SelectedIndex = 1;
    }

    private void OnClickToPaymentDetails(object sender, RoutedEventArgs e)
    {
      CheckoutTabControl.SelectedIndex = 2;
    }

    private void OnClickToBuy(object sender, RoutedEventArgs e)
    {
      CheckoutTabControl.SelectedIndex = 3;
    }
  }
}
