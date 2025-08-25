using Blocentra.Services;
using Blocentra.ViewModels;
using Blocentra.Views;
using System.Windows;

namespace Blocentra
{
    public partial class App : PrismApplication
    {
        protected override Window CreateShell()
        {
            var window = Container.Resolve<MainView>();
            Container.GetContainer().RegisterInstance<IWindowService>(new WindowService(window));
            return window;
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<MainViewModel>();
            containerRegistry.Register<IWindowService, WindowService>();

            containerRegistry.RegisterForNavigation<SplashScreenView>();
            containerRegistry.RegisterForNavigation<HeaderView>();
        }

        protected override void OnInitialized()
        {
            base.OnInitialized();


            var regionManager = Container.Resolve<IRegionManager>();
            regionManager.RequestNavigate("SplashScreenRegion", nameof(SplashScreenView));
        }
    }
}
