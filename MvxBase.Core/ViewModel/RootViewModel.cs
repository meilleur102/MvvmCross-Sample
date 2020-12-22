using MvvmCross.Commands;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;

namespace MvxBase.Core.ViewModel
{

    public class RootViewModel : MvxViewModel
    {
        private readonly IMvxNavigationService _navigationService;

        public RootViewModel(IMvxNavigationService navigationService)
        {
            _navigationService = navigationService;

            NavigateCommand = new MvxCommand(Navigate);
            OpenDialogCommand = new MvxCommand(OpenDialog);
        }

        public IMvxCommand NavigateCommand { get; }
        public IMvxCommand OpenDialogCommand { get; }

        private void Navigate()
        {
            _navigationService.Navigate<DialogViewModel>();
        }

        private void OpenDialog()
        {
            // TODO: Implement
        }
    }
}
