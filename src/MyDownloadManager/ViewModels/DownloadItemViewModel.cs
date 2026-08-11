using CommunityToolkit.Mvvm.ComponentModel;

namespace MyDownloadManager.ViewModels
{
    public partial class DownloadItemViewModel : ObservableObject
    {
        [ObservableProperty]
        private string fileName = string.Empty;

        [ObservableProperty]
        private long progress;

        [ObservableProperty]
        private string status = string.Empty;

        public string ProgressText => $"{(progress * 100.0 / 100):F2}%"; // placeholder
    }
}
