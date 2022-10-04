using static CommunityToolkit.Maui.Markup.GridRowsColumns;

namespace MauiPhoneLink.Pages;

public class MainPage : ContentPage
{
    void Build() => Content =
        new Grid
        {
            Background = Colors.Red
        };

    public MainPage()
    {
        Build();

#if DEBUG
        HotReloadService.UpdateApplicationEvent += (obj) =>
        {
            MainThread.BeginInvokeOnMainThread(() =>
            {
                Build();
            });

        };
#endif
    }
}
