using MauiPhoneLink.Pages;

namespace MauiPhoneLink;

public class App : Application
{
    public App()
    {
        Application.Current.UserAppTheme = AppTheme.Light;
        
        Application.Current.Resources = new ResourceDictionary();
        Application.Current.Resources.MergedDictionaries.Add(new Resources.Styles.Colors());
        Application.Current.Resources.MergedDictionaries.Add(new Resources.Styles.Styles());

        MainPage = new MainPage();
    }
}
