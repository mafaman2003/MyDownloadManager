using MyDownloadManager.Core.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyDownloadManager.Core.Services
{
    public class InMemoryDownloadRepository : IDownloadRepository
    {
        private readonly Dictionary<Guid, DownloadItem> _store = new();

        public Task<DownloadItem?> GetAsync(Guid id)
        {
            _store.TryGetValue(id, out var item);
            return Task.FromResult(item);
        }

        public Task<IEnumerable<DownloadItem>> GetAllAsync()
        {
            return Task.FromResult<IEnumerable<DownloadItem>>(_store.Values);
        }

        public Task SaveAsync(DownloadItem item)
        {
            _store[item.Id] = item;
            return Task.CompletedTask;
        }
    }
}
