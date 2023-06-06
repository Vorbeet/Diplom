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

namespace Diplomnaya.MainPage.RolesPages
{
    /// <summary>
    /// Логика взаимодействия для InfoRodPage.xaml
    /// </summary>
    public partial class InfoRodPage : Page
    {
        private Mother _currentMother = new Mother();
        public InfoRodPage(Mother selectedMother)
        {
            InitializeComponent();
            if (MainWindow.Globals.UserRole == 2)
            {
                SaveBTN.Visibility = Visibility.Hidden;
            }
            if (selectedMother != null)
                _currentMother = selectedMother;

            DataContext = _currentMother;
        }

        private void SaveBTN_Click(object sender, RoutedEventArgs e)
        {
            {
                StringBuilder errors = new StringBuilder();
                if (string.IsNullOrWhiteSpace(_currentMother.Name))
                    errors.AppendLine("Укажите имя.");
                if (string.IsNullOrWhiteSpace(_currentMother.Surname))
                    errors.AppendLine("Укажите фамилию.");
                if (errors.Length > 0)
                // проверка на ввод правильных данных
                {
                    MessageBox.Show(errors.ToString());
                    return;
                }
                if (_currentMother.id == 0)
                {
                    Student_CountsEntities.GetContext().Mothers.Add(_currentMother);
                }
                try
                {
                    Student_CountsEntities.GetContext().SaveChanges();
                    MessageBox.Show("Информация сохранена!");
                    Navigation.FrameStudents.Navigate(new Rod());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            Navigation.FrameStudents.Navigate(new Rod());
        }
    }
}
