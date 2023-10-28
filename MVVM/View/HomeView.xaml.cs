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
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void New_Char(object sender, RoutedEventArgs e)
        {
            New_character Newcharacter = new New_character();
            Newcharacter.Show();

        }
    }
}
