using System.Windows;
using System.Windows.Controls;
using WotGenC;
using WotGenC.Modes;

namespace GénérateurWot
{
    public partial class Parameters : Window
    {
        public Parameters()
        {
            InitializeComponent();
        }

        public Parameters(MainWindow mainWindow)
        {
            InitializeComponent();
            DataContext = mainWindow;
        }

        private void Selector_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ((MainWindow)DataContext).CurrentGameMode = (GameMode)((ComboBox)sender).SelectedValue;
        }

        private void ModeChanged(object sender, SelectionChangedEventArgs e)
        {
            ((MainWindow)DataContext).CurrentMode = ((MainWindow)DataContext).Modes[((ComboBox)sender).SelectedIndex];
            CategoryOptions.Visibility = ((MainWindow)DataContext).CurrentMode is CategoryMode ? Visibility.Visible : Visibility.Collapsed;
        }

        private void TankTypeChanged(object sender, SelectionChangedEventArgs e)
        {
            if (((MainWindow)DataContext).CurrentMode is CategoryMode cm)
            {
                cm.SelectedType = (TankType)((ComboBox)sender).SelectedValue;
            }
        }
    }
}