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

        public RelayCommand HomeViewCommand { get; set; }
        public RelayCommand CharachterViewCommand { get; set; }
        public RelayCommand RegimentViewCommand { get; set; }
        public RelayCommand ClassViewCommand { get; set; }
        public RelayCommand EquipmentViewCommand { get; set; }
        public RelayCommand SkillsViewCommand { get; set; }

        private HomeViewModel HomeVM { get; set; }
        private CharachterViewModel CharachterVM { get; set; }
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
            CharachterVM = new CharachterViewModel();
            RegimentVM = new RegimentViewModel();
            ClassVM = new ClassViewModel();
            EquipmentVM = new EquipmentViewModel();
            SkillsVM = new SkillsViewModel();


            CurrentView = HomeVM;

            HomeViewCommand = new RelayCommand(o =>
            {
                CurrentView = HomeVM;
            });

            CharachterViewCommand = new RelayCommand(o =>
            {
                CurrentView = CharachterVM;
            });

            RegimentViewCommand = new RelayCommand(o =>
            {
                CurrentView = RegimentVM;
            });

            ClassViewCommand = new RelayCommand(o =>
            {
                CurrentView = ClassVM;
            });

            EquipmentViewCommand = new RelayCommand(o =>
            {
                CurrentView = EquipmentVM;
            });

            SkillsViewCommand = new RelayCommand(o =>
            {
                CurrentView = SkillsVM;
            });
        }
    }
}
