using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TIOWCharGen.Core;

namespace TIOWCharGen.Popup.ViewModel
{
    public class NewGenCharacteristicsViewModel : INotifyPropertyChanged
    {
        public TIOWcharacter TIOWcharacter { get; set; }
        private int weaponSkill = 1;
        private int ballisticSkill = 1;
        private int strength = 1;
        private int toughness = 1;
        private int agility = 1;
        private int intellegence = 1;
        private int perception = 1;
        private int willpower = 1;
        private int fellowship = 1;


        public int WeaponSkill
        {
            get { return weaponSkill; }
            set
            {
                if (weaponSkill != value)
                {
                    weaponSkill = value;
                    OnPropertyChanged(nameof(WeaponSkill));
                }
            }
        }

        public int BallisticSkill
        {
            get { return ballisticSkill; }
            set
            {
                if (ballisticSkill != value)
                {
                    ballisticSkill = value;
                    OnPropertyChanged(nameof(BallisticSkill));
                }
            }
        }

        public int Strength
        {
            get { return strength; }
            set
            {
                if (strength != value)
                {
                    strength = value;
                    OnPropertyChanged(nameof(Strength));
                }
            }
        }
        public int Toughness
        {
            get { return toughness; }
            set
            {
                if (toughness != value)
                {
                    toughness = value;
                    OnPropertyChanged(nameof(Toughness));
                }
            }
        }


        public int Agility
        {
            get { return agility; }
            set
            {
                if (agility != value)
                {
                    agility = value;
                    OnPropertyChanged(nameof(Agility));
                }
            }
        }

        public int Intellegence
        {
            get { return intellegence; }
            set
            {
                if (intellegence != value)
                {
                    intellegence = value;
                    OnPropertyChanged(nameof(Intellegence));
                }
            }
        }
        public int Perception
        {
            get { return perception; }
            set
            {
                if (perception != value)
                {
                    perception = value;
                    OnPropertyChanged(nameof(Perception));
                }
            }
        }
        public int Willpower
        {
            get { return willpower; }
            set
            {
                if (willpower != value)
                {
                    willpower = value;
                    OnPropertyChanged(nameof(Willpower));
                }
            }
        }
        public int Fellowship
        {
            get { return fellowship; }
            set
            {
                if (fellowship != value)
                {
                    fellowship = value;
                    OnPropertyChanged(nameof(Fellowship));
                }
            }
        }

        public NewGenCharacteristicsViewModel()
        {
            // Initialize properties or perform any other setup here
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        // You can add methods or commands to handle user interactions here
    }
}
