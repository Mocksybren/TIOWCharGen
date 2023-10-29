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
    /// Interaction logic for NewGenCharacteristicsView.xaml
    /// </summary>
    public partial class NewGenCharacteristicsView : UserControl
    {
        public NewGenCharacteristicsView()
        {
            InitializeComponent();
        }
        private void TextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!int.TryParse(e.Text, out int result) || result < 1 || result > 100)
            {
                e.Handled = true; // Prevent input
            }
        }
        private void TextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (sender is TextBox textBox)
            {
                if (!int.TryParse(textBox.Text, out int result))
                {
                    // Handle invalid input (e.g., reset to a default value)
                    textBox.Text = "50"; // Or any other default value
                }
                else
                {
                    // Enforce the range (1 to 100)
                    result = Math.Max(1, Math.Min(100, result));
                    textBox.Text = result.ToString();
                }
            }
        }
    }
}
