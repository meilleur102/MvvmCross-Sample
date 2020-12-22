using MvvmCross;
using MvvmCross.ViewModels;
using MvvmDialogs;
using MvxBase.Core.ViewModel;

namespace MvxBase.Core
{
    public class App :MvxApplication
    {
        public override void Initialize()
        {
            Mvx.IoCProvider.RegisterSingleton(
                typeof(IDialogService),
                () => new DialogService(dialogTypeLocator: new DialogTypeLocator()));

            RegisterAppStart<RootViewModel>();
        }
    }
}
