using Diplomnaya.MainPage;
using Diplomnaya.MainPage.RolesPages;
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

namespace Diplomnaya
{
    /// <summary>
    /// Логика взаимодействия для GlavWindow.xaml
    /// </summary>
    public partial class GlavWindow : Window
    {
        public GlavWindow()
        {
            InitializeComponent();
            //Navigation.MainFrame = MainFrame;
            if (MainWindow.Globals.UserRole == 3 || MainWindow.Globals.UserRole == 2)
            {
                MainFrame.Navigate(new SecretPage());
            }
            else
                MainFrame.Navigate(new AdminPage(null));
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            mw.Show();
            this.Close();
        }
    }
}
