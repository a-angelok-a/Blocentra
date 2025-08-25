using Blocentra.Views;

namespace Blocentra.ViewModels
{
    public class MainViewModel : BindableBase
    {
        private readonly IRegionManager _regionManager;

        public MainViewModel(IRegionManager regionManager)
        {
            _regionManager = regionManager;
            InitializeApp();
        }

        private async void InitializeApp()
        {
            await Task.Delay(3000);

            var splashScreenRegion = _regionManager.Regions["SplashScreenRegion"];
            splashScreenRegion.RemoveAll();


            _regionManager.RequestNavigate("HeaderRegion", nameof(HeaderView));
        }
    }
}
