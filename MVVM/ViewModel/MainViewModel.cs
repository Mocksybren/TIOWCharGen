using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TIOWCharGen.Core;
using TIOWCharGen.MVVM.View;
using System.Windows.Input;
using System.Xml;
using System.IO;

namespace TIOWCharGen.MVVM.ViewModel
{
     class MainViewModel : ObservableObject
    {
        private string _menuText;

        public string MenuText
        {
            get { return _menuText; }
            set
            {
                if (_menuText != value)
                {
                    _menuText = value;
                    OnPropertyChanged(nameof(MenuText));
                }
            }
        }
        public RelayCommand HomeViewCommand { get; set; }
        public RelayCommand characterViewCommand { get; set; }
        public RelayCommand RegimentViewCommand { get; set; }
        public RelayCommand ClassViewCommand { get; set; }
        public RelayCommand EquipmentViewCommand { get; set; }
        public RelayCommand SkillsViewCommand { get; set; }

        private HomeViewModel HomeVM { get; set; }
        private characterViewModel characterVM { get; set; }
        private RegimentViewModel RegimentVM { get; set; }
        private ClassViewModel ClassVM { get; set; }
        private EquipmentViewModel EquipmentVM { get; set; }
        private SkillsViewModel SkillsVM { get; set; }

        private object _currentView;

        public object CurrentView
        { get { return _currentView; } 
        set { _currentView = value; 
                OnPropertyChanged();
            }
        }
        public MainViewModel()
        {
            HomeVM = new HomeViewModel();
            characterVM = new characterViewModel();
            RegimentVM = new RegimentViewModel();
            ClassVM = new ClassViewModel();
            EquipmentVM = new EquipmentViewModel();
            SkillsVM = new SkillsViewModel();


            CurrentView = HomeVM;
            MenuText = "Home";

            HomeViewCommand = new RelayCommand(o =>
            {
                CurrentView = HomeVM;
                MenuText = "Home";
            });

            characterViewCommand = new RelayCommand(o =>
            {
                CurrentView = characterVM;
                MenuText = "character";
            });

            RegimentViewCommand = new RelayCommand(o =>
            {
                CurrentView = RegimentVM;
                MenuText = "Regiment";
            });

            ClassViewCommand = new RelayCommand(o =>
            {
                CurrentView = ClassVM;
                MenuText = "Class";
            });

            EquipmentViewCommand = new RelayCommand(o =>
            {
                CurrentView = EquipmentVM;
                MenuText = "Equipment";
            });

            SkillsViewCommand = new RelayCommand(o =>
            {
                CurrentView = SkillsVM;
                MenuText = "Skills";
            });
        }
    }
}
