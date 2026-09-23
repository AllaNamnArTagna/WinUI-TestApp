
using Microsoft.UI.Xaml.Controls;

namespace WinUI_TestApp.Presentation.Navigation;

public class NavigationService : INavigationService
{
    private Frame? _frame;


    //Det läraren först hade skrivit var en property på denna men jag fattade inte riktigt logiken så jag ändrade om till en metod med ifsatser istället.
    public bool CanGoBack()
    {
        if (_frame != null && _frame.CanGoBack)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public void GoBack()
    {
        //OM frame INTE är null och CanGoBack () returnerar true, då körs _frame.GoBack()

        //Vi skriver _frame.GoBack pga syntax. _frame är ett objekt. GoBack är en betod definierad inuti _frame objectets klass. Om _frame är ansvarig för sin egen "go back" logic så använder vi _frame.GoBack()

        //Fattar inte detta helt
        if (_frame != null && CanGoBack())
        {
            _frame.GoBack();
        }
    }

    public void Initialize(Frame frame)
    {
        throw new System.NotImplementedException();
    }

    public void Navigate(AppPage page, string? parameter = null)
    {
        throw new System.NotImplementedException();
    }
}
