

using Microsoft.UI.Xaml.Controls;

namespace WinUI_TestApp.Presentation.Navigation;
public interface INavigationService
{
    bool CanGoBack();
    void Initialize(Frame frame);
    void Navigate(AppPage page, string? parameter = null);
    void GoBack();
}
