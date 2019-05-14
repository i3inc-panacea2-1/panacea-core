using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Panacea.Core.Mvvm
{
    public abstract class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public virtual void Activate()
        {

        }

        public virtual void Deactivate()
        {

        }

        public virtual FrameworkElement GetView()
        {
            var type = GetViewType();
            var view = Activator.CreateInstance(type) as FrameworkElement;
            view.DataContext = this;
            view.SetValue(LifeCycleBehaviors.AutoWireEventsProperty, true);
            return view;
        }

        public virtual Type GetViewType()
        {
            var type = GetType();
            var attr = type.GetCustomAttributes(false).FirstOrDefault(a => a is ViewAttribute);
            if (attr == null) throw new Exception($"No view found for type '{type.FullName}'.");
            return (attr as ViewAttribute).Type;
        }

        protected virtual void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
