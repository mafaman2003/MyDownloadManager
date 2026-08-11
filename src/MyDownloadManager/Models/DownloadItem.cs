using System;
using System.Collections.Generic;

namespace MyDownloadManager.Core.Models
{
    public class DownloadItem
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Url { get; set; } = string.Empty;
        public string FileName { get; set; } = string.Empty;
        public long TotalBytes { get; set; }
        public long DownloadedBytes { get; set; }
        public List<DownloadSegment> Segments { get; set; } = new();
        public DownloadStatus Status { get; set; } = DownloadStatus.Queued;
    }

    public class DownloadSegment
    {
        public int Index { get; set; }
        public long Start { get; set; }
        public long End { get; set; }
        public long Downloaded { get; set; }
    }

    public enum DownloadStatus
    {
        Queued,
        Downloading,
        Paused,
        Completed,
        Error,
        Canceled
    }
}
