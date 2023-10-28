using System;
using System.Collections.Generic;
using System.IO;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using TIOWCharGen.Core;
using TIOWCharGen.Popup;
using TIOWCharGen.Popup.View;
using TIOWCharGen.Popup.ViewModel;

namespace TIOWCharGen.MVVM.View
{
    /// <summary>
    /// Interaction logic for HomeView.xaml
    /// </summary>
    public partial class HomeView : UserControl
    {
        public HomeView()
        {
            InitializeComponent();
            string roamingFolderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string subfolder = "TIOWCharGen";
            string folderPath = System.IO.Path.Combine(roamingFolderPath, subfolder);

            // Check if the folder exists
            if (Directory.Exists(folderPath))
            {
                // Get a list of JSON files in the folder
                string[] characterFiles = Directory.GetFiles(folderPath, "*.json");

                // Loop through each JSON file
                foreach (string filePath in characterFiles)
                {
                    // Read the JSON content from the file
                    string jsonContent = File.ReadAllText(filePath);

                    // Deserialize JSON to a TIOWcharacter object
                    TIOWcharacter character = TIOWcharacter.FromJson(jsonContent);

                    // Add the character's information to the ListBox
                    characters.Items.Add(
                        $"{character.CharacterName}, {character.PlayerName}, {character.CampaignName}");
                }
            }
            else
            {
                MessageBox.Show("The specified folder does not exist.");
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void New_Char(object sender, RoutedEventArgs e)
        {
            New_character Newcharacter = new New_character(this);
            Newcharacter.Show();

        }

        public void Main_Load(object sender, EventArgs e)
        {
            string roamingFolderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string subfolder = "TIOWCharGen";
            string folderPath = System.IO.Path.Combine(roamingFolderPath, subfolder);

            // Check if the folder exists
            if (Directory.Exists(folderPath))
            {
                // Clear the ListBox to remove existing items
                characters.Items.Clear();

                // Get a list of JSON files in the folder
                string[] characterFiles = Directory.GetFiles(folderPath, "*.json");

                // Loop through each JSON file
                foreach (string filePath in characterFiles)
                {
                    // Read the JSON content from the file
                    string jsonContent = File.ReadAllText(filePath);

                    // Deserialize JSON to a TIOWcharacter object
                    TIOWcharacter character = TIOWcharacter.FromJson(jsonContent);

                    // Add the character's information to the ListBox
                    characters.Items.Add(
                        $"{character.CharacterName}, {character.PlayerName}, {character.CampaignName}");
                }
            }
            else
            {
                System.IO.Directory.CreateDirectory(System.IO.Path.Combine(roamingFolderPath, subfolder));
            }
        }
        private void CharacterSelected(object sender, SelectionChangedEventArgs e)
        {
            if (characters.SelectedItem != null)
            {
                string selectedCharacterName = characters.SelectedItem.ToString().Split(',')[0].Trim();

                string roamingFolderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                string subfolder = "TIOWCharGen";
                string folderPath = System.IO.Path.Combine(roamingFolderPath, subfolder);
                string filePath = System.IO.Path.Combine(folderPath, $"{selectedCharacterName}_data.json");

                if (File.Exists(filePath))
                {
                    string jsonContent = File.ReadAllText(filePath);
                    TIOWcharacter character = TIOWcharacter.FromJson(jsonContent);
                    Strength.Content = character.Strength.ToString();
                    Willpower.Content = character.Willpower.ToString();
                    WeaponSkill.Content = character.WeaponSkill.ToString();
                    BallisticSkill.Content = character.BallisticSkill.ToString();
                    Toughness.Content = character.Toughness.ToString();
                    Agility.Content = character.Agility.ToString();
                    Intellegence.Content = character.Intellegence.ToString();
                    Perception.Content = character.Perception.ToString();
                    Fellowship.Content = character.Fellowship.ToString();
                    ExpSpent.Content = character.XPSpended.ToString();
                    ExpGained.Content = character.XPGained.ToString();
                }
            }
        }
    }
}

