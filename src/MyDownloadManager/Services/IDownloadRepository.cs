using MyDownloadManager.Core.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyDownloadManager.Core.Services
{
    public interface IDownloadRepository
    {
        Task SaveAsync(DownloadItem item);
        Task<DownloadItem?> GetAsync(Guid id);
        Task<IEnumerable<DownloadItem>> GetAllAsync();
    }
}
