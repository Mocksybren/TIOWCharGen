using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TIOWCharGen.Core;

namespace TIOWCharGen.Popup.ViewModel
{
    public class NewBaseInfoViewModel : INotifyPropertyChanged
    {
        public TIOWcharacter TIOWcharacter { get; set; }
        private string characterName;
        private string playerName;
        private string campaignName;
        private string regiment;
        private string demeanor;
        private string description;
        private string speciality;


        public string CharacterName
        {
            get { return characterName; }
            set
            {
                if (characterName != value)
                {
                    characterName = value;
                    OnPropertyChanged(nameof(CharacterName));
                }
            }
        }

        public string PlayerName
        {
            get { return playerName; }
            set
            {
                if (playerName != value)
                {
                    playerName = value;
                    OnPropertyChanged(nameof(PlayerName));
                }
            }
        }

        public string CampaignName
        {
            get { return campaignName; }
            set
            {
                if (campaignName != value)
                {
                    campaignName = value;
                    OnPropertyChanged(nameof(CampaignName));
                }
            }
        }
        public string Regiment
        {
            get { return regiment; }
            set
            {
                if (regiment != value)
                {
                    regiment = value;
                    OnPropertyChanged(nameof(Regiment));
                }
            }
        }


        public string Demeanor
        {
            get { return demeanor; }
            set
            {
                if (demeanor != value)
                {
                    demeanor = value;
                    OnPropertyChanged(nameof(Demeanor));
                }
            }
        }

        public string Description
        {
            get { return description; }
            set
            {
                if (description != value)
                {
                    description = value;
                    OnPropertyChanged(nameof(Description));
                }
            }
        }
        public string Speciality
        {
            get { return speciality; }
            set
            {
                if (speciality != value)
                {
                    speciality = value;
                    OnPropertyChanged(nameof(Speciality));
                }
            }
        }

        public NewBaseInfoViewModel()
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
