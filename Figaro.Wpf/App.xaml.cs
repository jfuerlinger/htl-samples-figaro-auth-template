using Figaro.Wpf.Common;
using Figaro.Wpf.ViewModels;
using System.Windows;

namespace Figaro.Wpf
{
  /// <summary>
  /// Interaction logic for App.xaml
  /// </summary>
  public partial class App : Application
  {
    private async void Application_Startup(object sender, StartupEventArgs e)
    {
      var controller = new WindowController();
      var viewModel = await MainWindowViewModel.Create(controller);
      controller.ShowWindow(viewModel);
    }
  }
}
