using Blocentra.Views;
using System.Windows;

namespace Blocentra
{
    public partial class App : PrismApplication
    {
        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {

        }
        protected override Window CreateShell()
        {
            return ContainerLocator.Container.Resolve<MainView>();
        }
    }
}