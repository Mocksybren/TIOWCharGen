using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using TIOWCharGen.Core;
using TIOWCharGen.MVVM.View;
using TIOWCharGen.Popup.View;
using TIOWCharGen.Popup.ViewModel;

namespace TIOWCharGen.Popup
{
    /// <summary>
    /// Interaction logic for New_character.xaml
    /// </summary>
    public partial class New_character : Window
    {
        private TIOWcharacter character;
        private HomeView homeView;
        public New_character(HomeView homeView)
        {
            this.homeView = homeView;
            character = new TIOWcharacter();
            InitializeComponent();
        }
        public async void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            //databinding
            New_characterViewModel viewModel = (New_characterViewModel)this.DataContext;
            NewBaseInfoViewModel baseInfoViewModel = viewModel.BaseInfVM;
            NewGenCharacteristicsViewModel genCharaViewModel = viewModel.NewGenCharaVM;
            NewRegimentCreationViewModel regitalCreationViewModel = viewModel.NewRegimentVM;
            NewWorldSelecViewModel worldSelecViewModel = viewModel.NewWorldVM;
            NewDoctrineSelecViewModel newDoctrineSelecViewModel = viewModel.NewDoctrineVM;
            NewGearViewModel newGearViewModel = viewModel.NewGearVM;
            NewComradeViewModel newComradeViewModel = viewModel.NewComradeVM;

            //BaseInfo
            character.CharacterName = baseInfoViewModel.CharacterName;
            character.PlayerName = baseInfoViewModel.PlayerName;
            character.Regiment = baseInfoViewModel.Regiment;
            character.Description = baseInfoViewModel.Description;
            character.Demeanor = baseInfoViewModel.Demeanor;
            character.CampaignName = baseInfoViewModel.CampaignName;
            character.Speciality = baseInfoViewModel.Speciality;

            //CharacteristicsInfo
            character.WeaponSkill = genCharaViewModel.WeaponSkill;
            character.BallisticSkill = genCharaViewModel.BallisticSkill;
            character.Strength = genCharaViewModel.Strength;
            character.Toughness = genCharaViewModel.Toughness;
            character.Agility = genCharaViewModel.Agility;
            character.Intellegence = genCharaViewModel.Intellegence;
            character.Perception = genCharaViewModel.Perception;
            character.Willpower = genCharaViewModel.Willpower;
            character.Fellowship = genCharaViewModel.Fellowship;

            //

            await Task.Delay(1);

            string json = character.ToJson();
            string roamingFolderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string subfolder = "TIOWCharGen";


            string fileName = $"{character.CharacterName}_data.json";
            string filePath = System.IO.Path.Combine(roamingFolderPath, subfolder, fileName);
            System.IO.Directory.CreateDirectory(System.IO.Path.Combine(roamingFolderPath, subfolder));
            System.IO.File.WriteAllText(filePath, json);

            //Console.WriteLine($"JSON Data: {json}");

            //Debug MessageBox.Show("Character data saved to: " + filePath);
            homeView.Main_Load(this, EventArgs.Empty);
            this.Close();
        }
    }
}
