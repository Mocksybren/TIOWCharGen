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
using System.Windows.Navigation;
using System.Windows.Shapes;
using TIOWCharGen.Core;

namespace TIOWCharGen.Popup.View
{
    /// <summary>
    /// Interaction logic for NewBaseInfoView.xaml
    /// </summary>
    public partial class NewBaseInfoView : UserControl
    {
        private TIOWCharachter character;
        public NewBaseInfoView()
        {
            character = new TIOWCharachter();
            InitializeComponent();
        }
        public async void Save_Button_Click(object sender, RoutedEventArgs e)
        {
            character.CharachterName = CharachterName.Text;
            character.PlayerName = PlayerName.Text;
            character.Regiment = RegimentName.Text;
            character.Description = Description.Text;
            character.Demeanor = Demeanor.Text;
            character.CampaignName = CampaignName.Text;
            character.Speciality = Speciality.Text;


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

