using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TIOWCharGen.Core;
using TIOWCharGen.Popup.ViewModel;

namespace TIOWCharGen.Popup
{
    class New_CharachterViewModel : ObservableObject
    {

        public RelayCommand NewBaseInfoViewCommand { get; set; }
        public RelayCommand NewGenCharacteristicsViewCommand { get; set; }
        public RelayCommand NewRegimentCreationViewCommand { get; set; }
        public RelayCommand NewDoctrineSelecViewCommand { get; set; }
        public RelayCommand NewWorldSelecViewCommand { get; set; }
        public RelayCommand NewGearViewCommand { get; set; }
        public RelayCommand NewComradeViewCommand { get; set; }

        private NewBaseInfoViewModel BaseInfVM { get; set; }
        private NewGenCharacteristicsViewModel NewGenCharaVM { get; set; }
        private NewRegimentCreationViewModel NewRegimentVM { get; set; }
        private NewDoctrineSelecViewModel NewDoctrineVM { get; set; }
        private NewWorldSelecViewModel NewWorldVM { get; set; }
        private NewGearViewModel NewGearVM { get; set; }
        private NewComradeViewModel NewComradeVM { get; set; }

        private object _NewcurrentView;

        public object NewCurrentView
        {
            get { return _NewcurrentView; }
            set
            {
                _NewcurrentView = value;
                OnPropertyChanged();
            }
        }
        public New_CharachterViewModel()
        {
            BaseInfVM = new NewBaseInfoViewModel();
            NewGenCharaVM = new NewGenCharacteristicsViewModel();
            NewRegimentVM = new NewRegimentCreationViewModel();
            NewDoctrineVM = new NewDoctrineSelecViewModel();
            NewWorldVM = new NewWorldSelecViewModel();
            NewGearVM = new NewGearViewModel();
            NewComradeVM = new NewComradeViewModel();

            NewCurrentView = BaseInfVM;

            NewBaseInfoViewCommand = new RelayCommand(o =>
            {
                NewCurrentView = BaseInfVM;
            });

            NewGenCharacteristicsViewCommand = new RelayCommand(o =>
            {
                NewCurrentView = NewGenCharaVM;
            });

            NewRegimentCreationViewCommand = new RelayCommand(o =>
            {
                NewCurrentView = NewRegimentVM;
            });

            NewDoctrineSelecViewCommand = new RelayCommand(o =>
            {
                NewCurrentView = NewDoctrineVM;
            });

            NewWorldSelecViewCommand = new RelayCommand(o =>
            {
                NewCurrentView = NewWorldVM;
            });

            NewGearViewCommand = new RelayCommand(o =>
            {
                NewCurrentView = NewGearVM;
            });

            NewComradeViewCommand = new RelayCommand(o =>
            {
                NewCurrentView = NewComradeVM;
            });
        }
    }
}
