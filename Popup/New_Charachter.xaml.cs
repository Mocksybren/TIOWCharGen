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
using TIOWCharGen.Popup.View;

namespace TIOWCharGen.Popup
{
    /// <summary>
    /// Interaction logic for New_Charachter.xaml
    /// </summary>
    public partial class New_Charachter : Window
    {
        private TIOWCharachter character;
        private NewBaseInfoView baseInfoView;
        public New_Charachter()
        {
            character = new TIOWCharachter();
            InitializeComponent();
        }
        public async void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            character.CharachterName = baseInfoView.CharachterName.Text;
            character.PlayerName = baseInfoView.PlayerName.Text;
            character.Regiment = baseInfoView.RegimentName.Text;
            character.Description = baseInfoView.Description.Text;
            character.Demeanor = baseInfoView.Demeanor.Text;
            character.CampaignName = baseInfoView.CampaignName.Text;
            character.Speciality = baseInfoView.Speciality.Text;


            await Task.Delay(1);

            string json = character.ToJson();
            string roamingFolderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string subfolder = "TIOWCharGen";


            string fileName = $"{character.CharachterName}_data.json";
            string filePath = System.IO.Path.Combine(roamingFolderPath, subfolder, fileName);
            System.IO.Directory.CreateDirectory(System.IO.Path.Combine(roamingFolderPath, subfolder));
            System.IO.File.WriteAllText(filePath, json);

            //Console.WriteLine($"JSON Data: {json}");

            //Debug MessageBox.Show("Character data saved to: " + filePath);
        }
    }
}
