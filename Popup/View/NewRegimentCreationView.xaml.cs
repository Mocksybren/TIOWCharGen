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

namespace TIOWCharGen.Popup.View
{
    /// <summary>
    /// Interaction logic for RegimentCreationView.xaml
    /// </summary>
    public partial class NewRegimentCreationView : UserControl
    {
        public NewRegimentCreationView()
        {
            InitializeComponent();
        }
        private Dictionary<string, (string Text, string ImagePath)> regimentInfoMap = new Dictionary<string, (string Text, string ImagePath)>
        {
            { "CADIANS SHOCK TROOPS", ("Text for Cadians Shock Troops", "pack://application:,,,/TIOWCharGen;component/Images/CadianShockTrooper.png") },
            { "CATACHAN JUNGLE FIGHTERS", ("Text for Catachan Jungle Fighters", "pack://application:,,,/TIOWCharGen;component/Images/CatachanJungleFighter.png") },
            { "THE DEATH KORPS OF KRIEG", ("Text for the death korps of krieg", "pack://application:,,,/TIOWCharGen;component/Images/KriegGren.png") },
            { "ELYSIAN DROP TROOPS",("Text for Elysian Drop Troops", "pack://application:,,,/TIOWCharGen;component/Images/ElysianDropTrooper.jpg") },
            { "MACCABIAN JANISSARIES",("Text for Maccabian Janissaries", "pack://application:,,,/TIOWCharGen;component/Images/Maccabian_Janissaries.png") },
            { "MORDIAN IRON GUARD",("Text for Mordian Iron Guard", "pack://application:,,,/TIOWCharGen;component/Images/Mordian_Iron_Guard_female_trooper_2.png") },
            { "TALLARN DESERT RAIDERS",("Text for Tallarn Desert Raiders", "pack://application:,,,/TIOWCharGen;component/Images/Tallarn_Brawler.png") },
            { "VOSTROYAN FIRSTBORN",("Text for Vostroyan Firstborn", "pack://application:,,,/TIOWCharGen;component/Images/Vostroyan_Firstborn_Sgt.png") },
        };
        private void RegimentComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (RegimentComboBox.SelectedItem != null)
            {
                string selectedRegiment = (RegimentComboBox.SelectedItem as ComboBoxItem).Content.ToString();

                if (regimentInfoMap.TryGetValue(selectedRegiment, out var info))
                {
                    // Set the TextBlock text and Image source
                    InformationBox.Text = info.Text;
                    RegiImage.Source = new BitmapImage(new Uri(info.ImagePath));
                }
            }
        }

    }
}
