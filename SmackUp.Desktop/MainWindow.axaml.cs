using System.Runtime.InteropServices;
using Avalonia.Controls;
using Avalonia.Media;

namespace SmackUp.Desktop;
public partial class MainWindow : FluentAvalonia.UI.Windowing.AppWindow
{
    public MainWindow()
    {
        if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
        {
            Background = Brushes.Transparent;
            TransparencyLevelHint = new[] { WindowTransparencyLevel.Mica, };
        }
        InitializeComponent();
    }
}