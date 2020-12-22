using System;
using System.ComponentModel;
using System.Reflection;
using MvvmDialogs.DialogTypeLocators;

namespace MvxBase.Core
{
    class DialogTypeLocator : IDialogTypeLocator
    {
        private readonly Lazy<Assembly> _viewAssembly;

        public DialogTypeLocator()
        {
            _viewAssembly = new Lazy<Assembly>(() => Assembly.Load("Mvx.WPF"));
        }
        
        public Type Locate(INotifyPropertyChanged viewModel)
        {
            var viewModelType = viewModel.GetType();

            var viewName = viewModelType.Name.Replace("ViewModel", "View");
            var viewFullName = $"Mvx.WPF.Views.{viewName}";

            return _viewAssembly.Value.GetType(viewFullName);
        }
    }
}
