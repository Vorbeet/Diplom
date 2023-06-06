using Diplomnaya.MainPage.RolesPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Diplomnaya.MainPage
{
    /// <summary>
    /// Логика взаимодействия для SecretPage.xaml
    /// </summary>
    public partial class SecretPage : Page
    {
        public SecretPage()
        {
            InitializeComponent();
            Navigation.FrameStudents = FrameStudents;
            FrameStudents.Navigate(new Electro());
        }

        private void Students_Click(object sender, RoutedEventArgs e)
        {
            FrameStudents.Navigate(new Electro());
        }

        private void Parrents_Click(object sender, RoutedEventArgs e)
        {
            FrameStudents.Navigate(new Rod());
        }
    }
}
