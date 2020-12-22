using MvvmCross.Commands;
using MvvmCross.ViewModels;
using MvvmDialogs;

namespace MvxBase.Core.ViewModel
{
    public class DialogViewModel : MvxViewModel, IModalDialogViewModel
    {
        private int _value;

        public DialogViewModel()
        {
            IncreaseCommand = new MvxCommand(Increase);
            DecreaseCommand = new MvxCommand(Decrease);
        }

        public IMvxCommand IncreaseCommand { get; }
        public IMvxCommand DecreaseCommand { get; }

        public int Value
        {
            get => _value;
            set
            {
                _value = value;
                RaisePropertyChanged(() => Value);
            }
        }

        public bool? DialogResult { get; }
        
        private void Increase()
        {
            Value++;
        }

        private void Decrease()
        {
            Value--;
        }
    }
}