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
    /// Interaction logic for WorldSelecView.xaml
    /// </summary>
    public partial class NewWorldSelecView : UserControl
    {
        public NewWorldSelecView()
        {
            InitializeComponent();
            WorldComboBox.SelectedIndex = 0;
        }
        private Dictionary<string, (string Text, string ImagePath)> regimentInfoMap = new Dictionary<string, (string Text, string ImagePath)>
        {
            { "Death World", ("Text for Death World", "pack://application:,,,/TIOWCharGen;component/Images/World/DeathWorld.png") },
        };
        private void WorldComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (WorldComboBox.SelectedItem != null)
            {
                string selectedRegiment = (WorldComboBox.SelectedItem as ComboBoxItem).Content.ToString();

                if (regimentInfoMap.TryGetValue(selectedRegiment, out var info))
                {
                    // Set the TextBlock text and Image source
                    WorldInformationBox.Text = info.Text;
                    WorldImage.Source = new BitmapImage(new Uri(info.ImagePath));
                }
            }
        }
    }
}
