using MvvmCross.Core;
using MvvmCross.Platforms.Wpf.Core;
   
namespace Mvx.WPF
{
    public partial class App
    {
        protected override void RegisterSetup()
        {
            this.RegisterSetupType<MvxWpfSetup<MvxBase.Core.App>>();
        }
    }
}
