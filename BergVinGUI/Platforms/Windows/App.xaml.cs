#if WINDOWS
using Microsoft.UI.Xaml;
#endif

namespace BergVinGUI.WinUI
{
#if WINDOWS
    public partial class App : MauiWinUIApplication
    {
        public App()
        {
            this.InitializeComponent();
        }

        protected MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();
    }
#endif
}