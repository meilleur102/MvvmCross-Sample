using MvvmCross.ViewModels;
using MvxBase.Core.ViewModel;

namespace MvxBase.Core
{
    public class App :MvxApplication
    {
        public override void Initialize()
        {
            RegisterAppStart<RootViewModel>();
        }
    }
}
