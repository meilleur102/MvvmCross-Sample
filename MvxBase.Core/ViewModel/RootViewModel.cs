using MvvmCross.Commands;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace MvxBase.Core.ViewModel
{

    public class RootViewModel : MvxViewModel
    {
        public IMvxCommand OpenDialogCommand { get; set; }
        private readonly IMvxNavigationService _navigationService;
        public RootViewModel(IMvxNavigationService navigationService)
        {
            _navigationService = navigationService;
            OpenDialogCommand = new MvxCommand(OpenDialog);
        }

        private void OpenDialog()
        {
            //Use MvvmDialog to show DialogViewModel 
            //If you dont want to use the navigation service 
            //just remove it from the RootViewModelConstructor (IMvxNavigationService navigationService)
            //You can pass a object to the new ViewModel if you need to by adding a async to the OpenDialog()
            //and calling the navigationService like this
            // await _navigationService.Navigate<DialogViewModel, MyObject>(new MyObject());
            //and having the Object on a Prepare() Method on the DialogViewModel class.
            //See link for the MvvmCross Doc
            //https://www.mvvmcross.com/documentation/fundamentals/navigation
            //The problem I have is to implement the IoC from Mvvm


            _navigationService.Navigate<DialogViewModel>();

        }
    }
}
