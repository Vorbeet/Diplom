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
    /// Логика взаимодействия для InfoPage.xaml
    /// </summary>
    public partial class InfoPage : Page
    {
        private Student _currentStudent = new Student();
        public InfoPage(Student selectedStudent)
        {
            InitializeComponent();
            if (MainWindow.Globals.UserRole == 2)
            {
                SaveBTN.Visibility = Visibility.Hidden;
            }
            if (selectedStudent != null)
                _currentStudent = selectedStudent;

            DataContext = _currentStudent;
        }
        private void SaveBTN_Click(object sender, RoutedEventArgs e)
        {
            {
                StringBuilder errors = new StringBuilder();
                if (string.IsNullOrWhiteSpace(_currentStudent.Name))
                    errors.AppendLine("Укажите имя.");
                if (string.IsNullOrWhiteSpace(_currentStudent.Surname))
                    errors.AppendLine("Укажите фамилию.");
                if (_currentStudent.Mother < 1)
                    errors.AppendLine("Укажите личный идентификатор матери.");
                if (_currentStudent.Father < 1)
                    errors.AppendLine("Укажите личный идентификатор отца.");
                if (string.IsNullOrWhiteSpace(_currentStudent.Residence))
                    errors.AppendLine("Укажите место проживания.");
                if (string.IsNullOrWhiteSpace(_currentStudent.Adress))
                    errors.AppendLine("Укажите место прописки.");
                if (_currentStudent.Passport < 1)
                    errors.AppendLine("Укажите серию и номер пасспорта.");
                if (string.IsNullOrWhiteSpace(_currentStudent.Telephone))
                    errors.AppendLine("Укажите номер телефона.");
                if (errors.Length > 0)
                // проверка на ввод правильных данных
                {
                    MessageBox.Show(errors.ToString());
                    return;
                }

                if (_currentStudent.Group_id == 0)
                {
                    _currentStudent.Group_id = Electro.Globals.GroupNum;
                    Student_CountsEntities.GetContext().Students.Add(_currentStudent);
                }
                try
                {
                    Student_CountsEntities.GetContext().SaveChanges();
                    MessageBox.Show("Информация сохранена!");
                    Navigation.FrameStudents.Navigate(new Electro());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            Navigation.FrameStudents.Navigate(new Electro());
        }
    }
}
