using CommunityToolkit.Mvvm.ComponentModel;

namespace MauiBugReport.ViewModels
{
    public partial class MainPageViewModel: ObservableObject
    {
        private string status = "";

        [ObservableProperty]
        private HtmlWebViewSource htmlText = new();

        public string Status
        {
            get { return status; }
            set
            {
                status = value;
                if (status == "") return;
                HtmlText.Html = "<html><body>Hello. World!</body></html>";
            }
        }

    }
}
