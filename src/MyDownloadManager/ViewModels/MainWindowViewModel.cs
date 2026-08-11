using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace MyDownloadManager.ViewModels
{
    public partial class MainWindowViewModel : ObservableObject
    {
        public ObservableCollection<DownloadItemViewModel> Downloads { get; } = new();

        public MainWindowViewModel()
        {
            // sample
            Downloads.Add(new DownloadItemViewModel { FileName = "example.zip", Progress = 0, Status = "Idle" });
        }

        [RelayCommand]
        private void Add()
        {
            Downloads.Add(new DownloadItemViewModel { FileName = "newfile.bin", Progress = 0, Status = "Queued" });
        }

        [RelayCommand]
        private void Pause()
        {
            // TODO: wire to service
        }

        [RelayCommand]
        private void Resume()
        {
            // TODO: wire to service
        }
    }
}

