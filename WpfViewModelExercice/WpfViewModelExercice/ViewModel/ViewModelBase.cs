using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace WpfViewModelExercice.ViewModel
{
    /// <summary>
    /// Base class Of ViewModel
    /// </summary>
    public class ViewModelBase : INotifyPropertyChanged
    {

        /// <summary>
        /// Mothod wich manage PropertyChanged event when a property modified
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        /// <summary>
        /// Mothod wich manage PropertyChanged event when a property modified
        /// </summary>
        /// <param name="propertyName">Name of the property to notify</param>
        private void NotifyPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = this.PropertyChanged;
            if (handler != null)
            {
                var e = new PropertyChangedEventArgs(propertyName);
                handler(this, e);
            }
        }

        /// <summary>
        /// Notfy the Property
        /// </summary>
        /// <param name="propertyName">Name of the property to notify</param>
        protected void Notify(string propertyName)
        {
            NotifyPropertyChanged(propertyName);
        }

        /// <summary>
        /// Notfy the Property
        /// </summary>
        /// <param name="propertyName">Name of the property to notify</param>
        protected void Notify<TValue>(Expression<Func<TValue>> propertySelector)
        {
            if (PropertyChanged != null)
            {
                var memberExpression = propertySelector.Body as MemberExpression;
                if (memberExpression != null)
                {
                    NotifyPropertyChanged(memberExpression.Member.Name);
                }
            }
        }

    }
}
