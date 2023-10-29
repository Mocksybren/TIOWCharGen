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
using TIOWCharGen.MVVM.ViewModel;
using TIOWCharGen.Popup;
using TIOWCharGen.Popup.View;
using TIOWCharGen.Popup.ViewModel;

namespace TIOWCharGen.MVVM.View
{
    public partial class HomeView : UserControl
    {
        private HashSet<string> campaignNamesSet = new HashSet<string>();
        public HomeView()
        {
            DataContext = new HomeViewModel();
            InitializeComponent();
            string roamingFolderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string subfolder = "TIOWCharGen";
            string folderPath = System.IO.Path.Combine(roamingFolderPath, subfolder);

            if (Directory.Exists(folderPath))
            {
                characters.Items.Clear();
                string[] characterFiles = Directory.GetFiles(folderPath, "*.json");

                foreach (string filePath in characterFiles)
                {
                    string jsonContent = File.ReadAllText(filePath);

                    TIOWcharacter character = TIOWcharacter.FromJson(jsonContent);

                    characters.Items.Add(
                        $"{character.CharacterName}, {character.PlayerName}, {character.CampaignName}");

                    if (!campaignNamesSet.Contains(character.CampaignName))
                    {
                        CampaignsComboBox.Items.Add(character.CampaignName);
                        campaignNamesSet.Add(character.CampaignName);
                    }
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

            if (Directory.Exists(folderPath))
            {
                characters.Items.Clear();

                string[] characterFiles = Directory.GetFiles(folderPath, "*.json");

                foreach (string filePath in characterFiles)
                {
                    string jsonContent = File.ReadAllText(filePath);

                    TIOWcharacter character = TIOWcharacter.FromJson(jsonContent);

                    characters.Items.Add(
                        $"{character.CharacterName}, {character.PlayerName}, {character.CampaignName}");

                    if (!campaignNamesSet.Contains(character.CampaignName))
                    {
                        CampaignsComboBox.Items.Add(character.CampaignName);
                        campaignNamesSet.Add(character.CampaignName);
                    }
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
                    characterInfoTextBlock.Text = $"Character Name: {character.CharacterName}\n" +
                                         $"Player Name: {character.PlayerName}\n" +
                                         $"Regiment: {character.Regiment}\n" +
                                         $"Speciality: {character.Speciality}\n" +
                                         $"Demeanor: {character.Demeanor}\n" +
                                         $"Description: {character.Description}\n" +
                                         $"Campaign Name: {character.CampaignName}";
                }
            }
        }
        private void CampaignsComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string selectedCampaignName = CampaignsComboBox.SelectedItem as string;

            characters.Items.Clear();

            string roamingFolderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string subfolder = "TIOWCharGen";
            string folderPath = System.IO.Path.Combine(roamingFolderPath, subfolder);

            if (Directory.Exists(folderPath))
            {
                string[] characterFiles = Directory.GetFiles(folderPath, "*.json");

                foreach (string filePath in characterFiles)
                {
                    string jsonContent = File.ReadAllText(filePath);

                    TIOWcharacter character = TIOWcharacter.FromJson(jsonContent);

                    if (selectedCampaignName == null || character.CampaignName == selectedCampaignName)
                    {
                        characters.Items.Add(
                            $"{character.CharacterName}, {character.PlayerName}, {character.CampaignName}");
                    }
                }
            }
        }
        private void RemoveButton_Click(object sender, RoutedEventArgs e)
        {
            if (characters.SelectedItem != null)
            {
                // Save the index of the currently selected item
                int selectedIndex = characters.SelectedIndex;

                string selectedCharacterName = characters.SelectedItem.ToString().Split(',')[0].Trim();
                MessageBoxResult result = MessageBox.Show($"Are you sure you want to remove the character: {selectedCharacterName}?", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question);

                if (result == MessageBoxResult.Yes)
                {
                    string selectedCampaignName = CampaignsComboBox.SelectedItem as string;

                    // Proceed with character removal
                    string roamingFolderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                    string subfolder = "TIOWCharGen";
                    string folderPath = System.IO.Path.Combine(roamingFolderPath, subfolder);
                    string filePath = System.IO.Path.Combine(folderPath, $"{selectedCharacterName}_data.json");

                    if (File.Exists(filePath))
                    {
                        File.Delete(filePath);

                        // Remove the character from the listbox
                        characters.Items.Remove(characters.SelectedItem);

                        // Check if the removed character was the last one associated with the campaign
                        bool isLastCharacterForCampaign = true;

                        foreach (var item in characters.Items)
                        {
                            string campaign = item.ToString().Split(',')[2].Trim();
                            if (campaign == selectedCampaignName)
                            {
                                isLastCharacterForCampaign = false;
                                break;
                            }
                        }

                        // If it was the last character, remove the campaign name from the ComboBox
                        if (isLastCharacterForCampaign && selectedCampaignName != "All Campaings")
                        {
                            CampaignsComboBox.Items.Remove(selectedCampaignName);
                        }

                        // Reset the ComboBox to "All Campaings"
                        CampaignsComboBox.SelectedIndex = 0;

                        // Set the selection to the original first item
                        if (characters.Items.Count > 0)
                        {
                            characters.SelectedIndex = Math.Min(selectedIndex, characters.Items.Count - 1);
                        }
                    }
                }
            }
            else {
                MessageBox.Show("Make sure to select a character in the list");
            }
        }


        private void CopyButton_Click(object sender, RoutedEventArgs e)
        {
            if (characters.SelectedItem != null)
            {
                string selectedCharacterName = characters.SelectedItem.ToString().Split(',')[0].Trim();

                MessageBoxResult result = MessageBox.Show($"Are you sure you want to copy '{selectedCharacterName}'?", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question);

                if (result == MessageBoxResult.Yes)
                {
                    string selectedCampaignName = CampaignsComboBox.SelectedItem as string;

                    string roamingFolderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                    string subfolder = "TIOWCharGen";
                    string folderPath = System.IO.Path.Combine(roamingFolderPath, subfolder);
                    string sourceFilePath = System.IO.Path.Combine(folderPath, $"{selectedCharacterName}_data.json");

                    if (File.Exists(sourceFilePath))
                    {
                        string copiedCharacterName = "Copy_" + selectedCharacterName;
                        string destinationFilePath = System.IO.Path.Combine(folderPath, $"{copiedCharacterName}_data.json");

                        if (!File.Exists(destinationFilePath))
                        {
                            File.Copy(sourceFilePath, destinationFilePath);

                            characters.Items.Add(
                                $"{copiedCharacterName}, {selectedCharacterName}, {selectedCampaignName}");
                        }
                        else
                        {
                            MessageBox.Show("A copied character with the same name already exists.");
                        }
                    }
                }
            }
        }
        private void WIPButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is Work In Progress");
        }
    }
}

