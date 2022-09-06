using Windows.UI.Xaml.Controls;

namespace JsonViewer.Sample
{
    public sealed partial class MainPage : Page
    {
        public MainPageViewModel ViewModel { get; set; }
        public MainPage()
        {
            this.InitializeComponent();
            ViewModel = new MainPageViewModel();
            DataContext = ViewModel;
        }
    }
}
