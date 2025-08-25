using Blocentra.Services;

namespace Blocentra.ViewModels
{
    public class HeaderViewModel : BindableBase
    {
        private readonly IWindowService _windowService;
        public DelegateCommand CloseCommand { get; }

        public DelegateCommand MaximizeCommand { get; }

        public DelegateCommand MinimizeCommand { get; }


        public HeaderViewModel(IWindowService WindowService)
        {
            _windowService = WindowService;

            CloseCommand = new DelegateCommand(() => _windowService.CloseWindowCommand());
            MaximizeCommand = new DelegateCommand(() => _windowService.MaximizeRestoreCommand());
            MinimizeCommand = new DelegateCommand(() => _windowService.MinimizeRestoreCommand());
        }

    }
}
