using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Panacea.Core.Mvvm
{
    public abstract class UserControlWithViewModel<T>:UserControl, IContainsViewModel where T:ViewModelBase
    {
        public UserControlWithViewModel()
        {

        }

        public UserControlWithViewModel(T viewModel)
        {
            ViewModel = viewModel;
        }

        public T ViewModel
        {
            get { return (T)GetValue(ViewModelProperty); }
            set { SetValue(ViewModelProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ViewModelProperty =
            DependencyProperty.Register("ViewModel", typeof(ViewModelBase), 
                typeof(UserControlWithViewModel<>), new PropertyMetadata(null));

        public ViewModelBase GetViewModel()
        {
            return ViewModel;
        }
    }

    internal interface IContainsViewModel
    {
        ViewModelBase GetViewModel();
    }
}
