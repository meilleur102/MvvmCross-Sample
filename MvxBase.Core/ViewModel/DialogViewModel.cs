using MvvmCross.ViewModels;
using MvvmDialogs;

namespace MvxBase.Core.ViewModel
{
    public class DialogViewModel : MvxViewModel, IModalDialogViewModel
    {
        public DialogViewModel()
        {
        }

        public bool? DialogResult { get; }
    }
}