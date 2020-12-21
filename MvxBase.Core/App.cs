using MvvmCross.ViewModels;
using MvxBase.Core.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

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
