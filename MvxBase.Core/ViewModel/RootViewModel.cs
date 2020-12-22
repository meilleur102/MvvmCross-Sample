using MvvmCross.Commands;
using MvvmCross.ViewModels;
using MvvmDialogs;

namespace MvxBase.Core.ViewModel
{
    public class RootViewModel : MvxViewModel
    {
        private readonly IDialogService _dialogService;

        public RootViewModel(IDialogService dialogService)
        {
            _dialogService = dialogService;

            OpenDialogCommand = new MvxCommand(OpenDialog);
        }

        public IMvxCommand OpenDialogCommand { get; }

        private void OpenDialog()
        {
            _dialogService.ShowDialog(this, new DialogViewModel());
        }
    }
}
