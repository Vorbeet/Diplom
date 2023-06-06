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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Diplomnaya.MainPage
{
    /// <summary>
    /// Логика взаимодействия для AdminPage.xaml
    /// </summary>
    public partial class AdminPage : Page
    {
        private Student _currentStudent = new Student();
        public AdminPage(Student selectedStudent)
        {
            InitializeComponent();
            FrameAdmin.Navigate(new Test());
            if (selectedStudent != null)
                _currentStudent = selectedStudent;
            DataContext = _currentStudent;
        }

        private void Base_Click(object sender, RoutedEventArgs e)
        {
            {
                StringBuilder errors = new StringBuilder();

                if (_currentStudent.id == 0)
                {
                    _currentStudent.Name = "TestNameSt";
                    _currentStudent.Surname = "TestNameSurname";
                    _currentStudent.Patronymic = "TestNamePatronymic";
                    _currentStudent.Birth = DateTime.Now;
                    _currentStudent.Status = "TestStatus";
                    _currentStudent.Residence = "testResidence";
                    _currentStudent.Passport = 12312312;
                    _currentStudent.Telephone = "123123123";
                    _currentStudent.Adress = "testadress";
                    _currentStudent.Father = 1;
                    _currentStudent.Mother = 1;
                    _currentStudent.Group_id = 1;
                    Student_CountsEntities.GetContext().Students.Add(_currentStudent);
                    MessageBox.Show("Сохранение работает стабильно");
                    Student_CountsEntities.GetContext().Students.Remove(_currentStudent);
                    MessageBox.Show("Удаление работает стабильно");
                }
                try
                {
                    Student_CountsEntities.GetContext().SaveChanges();
                    MessageBox.Show("Связь с базой данных стабильна");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void App_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();
            try
            {
                FrameAdmin.Navigate(new SecretPage());
                FrameAdmin.Navigate(new Electro());
                FrameAdmin.Navigate(new Rod());
                FrameAdmin.Navigate(new InfoPage(null));
                FrameAdmin.Navigate(new InfoRodPageDouble(null));
                FrameAdmin.Navigate(new SecretPage());
                FrameAdmin.Navigate(new Electro());
                FrameAdmin.Navigate(new Rod());
                FrameAdmin.Navigate(new InfoPage(null));
                FrameAdmin.Navigate(new InfoRodPageDouble(null));
                FrameAdmin.Navigate(new Test());
                MessageBox.Show("Проверка прошла успешно, приложение работает стабильно");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
