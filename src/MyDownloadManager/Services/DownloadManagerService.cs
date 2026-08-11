
using MyDownloadManager.Core.Models;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyDownloadManager.Core.Services
{
    public class DownloadManagerService
    {
        private readonly ConcurrentDictionary<Guid, DownloadItem> _items = new();

        public event Action<DownloadItem>? DownloadUpdated;

        public Task StartAsync(DownloadItem item)
        {
            _items[item.Id] = item;
            item.Status = DownloadStatus.Downloading;
            DownloadUpdated?.Invoke(item);
            return Task.CompletedTask;
        }

        public Task PauseAsync(Guid id)
        {
            if (_items.TryGetValue(id, out var item))
            {
                item.Status = DownloadStatus.Paused;
                DownloadUpdated?.Invoke(item);
            }
            return Task.CompletedTask;
        }

        public Task ResumeAsync(Guid id)
        {
            if (_items.TryGetValue(id, out var item))
            {
                item.Status = DownloadStatus.Downloading;
                DownloadUpdated?.Invoke(item);
            }
            return Task.CompletedTask;
        }
    }
}
