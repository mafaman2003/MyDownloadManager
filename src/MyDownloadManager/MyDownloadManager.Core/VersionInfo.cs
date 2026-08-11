using System;
using MyDownloadManager.Core.Models;

namespace MyDownloadManager.Core
{
    public static class VersionInfo
    {
        public const string Version = "0.1.0";
        public static string GetInfo() => $"MyDownloadManager {Version} (Core)";
    }
}
