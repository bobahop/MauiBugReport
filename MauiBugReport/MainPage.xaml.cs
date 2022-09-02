using MauiBugReport.ViewModels;

namespace MauiBugReport;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
        BindingContext = new MainPageViewModel();
    }

	private void WebView_Navigating(object sender, WebNavigatingEventArgs e)
	{
        if (e.NavigationEvent == WebNavigationEvent.Back || e.NavigationEvent == WebNavigationEvent.Forward)
            e.Cancel = true;
    }
}

