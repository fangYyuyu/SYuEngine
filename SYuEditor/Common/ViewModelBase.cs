using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace SYuEditor
{
    public class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string properName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(properName));
        }
    }
}
