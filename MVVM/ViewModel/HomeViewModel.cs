using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TIOWCharGen.MVVM.ViewModel
{
    class HomeViewModel : INotifyPropertyChanged
    {
        private string characterInformation;

        public string CharacterInformation
        {
            get { return characterInformation; }
            set
            {
                if (characterInformation != value)
                {
                    characterInformation = value;
                    OnPropertyChanged(nameof(CharacterInformation));
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
