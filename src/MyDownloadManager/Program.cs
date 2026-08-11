
using System;
using System.IO;
using Avalonia.Controls;
using Avalonia;

namespace MyDownloadManager
{
    class Program
    {
        // Initialization code. Don't use any Avalonia, third-party APIs or any
        // synchronization context-reliant code before AppMain is called: things aren't initialized yet and stuff might break.
        [STAThread]
        public static void Main(string[] args) => BuildAvaloniaApp().StartWithClassicDesktopLifetime(args);

        // Avalonia configuration, don't remove; also used by visual designer.
        public static AppBuilder BuildAvaloniaApp()
            => AppBuilder.Configure<App>()
                .UsePlatformDetect()
                .LogToTrace();
    }
}
