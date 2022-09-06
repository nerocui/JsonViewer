using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Text.Json.Viewer;

namespace JsonViewer.Sample
{
    public partial class MainPageViewModel : ObservableObject
    {
        [ObservableProperty]
        private JsonViewerConfig _config;
        [ObservableProperty]
        private string _text;

        [RelayCommand]
        private void OnSetConfig()
        {
            Config = new JsonViewerConfig(Text, true, true, true);
        }
    }
}
