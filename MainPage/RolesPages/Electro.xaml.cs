using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
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
    /// Логика взаимодействия для Electro.xaml
    /// </summary>
    public partial class Electro : Page
    {
        public Electro()
        {
            InitializeComponent();
            if (MainWindow.Globals.UserRole == 2)
            { 
                BtnDel.Visibility = Visibility.Hidden;
                BtnAdd.Visibility = Visibility.Hidden;
            }
            DGridStudents.ItemsSource = Student_CountsEntities.GetContext().Students.ToList();
            UpdateClients();
            var allstudents = Student_CountsEntities.GetContext().Groupps.ToList();
            allstudents.Insert(0, new Groupp
            {
                NameGroup = "All students"
            });
            cb_students.SelectedIndex = 0;
            cb_students.ItemsSource = allstudents;
            UpdateClients();
        }
        public static class Globals
        {
            public static int GroupNum;
        }
        public void UpdateClients()
        {
            var currentUsers = Student_CountsEntities.GetContext().Students.ToList();
            if (cb_students.SelectedIndex > 0 && cb_students.SelectedIndex != 1) 
            {
                currentUsers = currentUsers.Where(p => p.Group_id == cb_students.SelectedIndex).ToList();
            }
            else if (cb_students.SelectedIndex == 1)
                currentUsers = currentUsers.Where(p => p.Groupp.NameGroup == "Электрик 1 курс").ToList();
            currentUsers = currentUsers.Where(p => p.Name.ToLower().Contains(TBoxSearch1.Text.ToLower())).ToList();
            DGridStudents.ItemsSource = currentUsers.OrderBy(p => p.Name).ToList();
            DGridStudents.ItemsSource = currentUsers;
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            Electro.Globals.GroupNum = cb_students.SelectedIndex;
            Navigation.FrameStudents.Navigate(new InfoPage((sender as Button).DataContext as Student));
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            Electro.Globals.GroupNum = cb_students.SelectedIndex;
            Navigation.FrameStudents.Navigate(new InfoPage(null));
        }

        private void BtnDel_Click(object sender, RoutedEventArgs e)
        {
            var StudentsForRemoving = DGridStudents.SelectedItems.Cast<Student>().ToList();
            if (MessageBox.Show($"Чел ты точно хочешь стереть с лица земли {StudentsForRemoving.Count()} людей?", "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    Student_CountsEntities.GetContext().Students.RemoveRange(StudentsForRemoving);
                    Student_CountsEntities.GetContext().SaveChanges();
                    UpdateClients();
                    MessageBox.Show("Да ладно, одним больше, одним меньше");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ToString());
                    DGridStudents.ItemsSource = Student_CountsEntities.GetContext().Students.ToList();
                }
            }
        }

        private void TBoxSearch1_TextChanged(object sender, TextChangedEventArgs e)
        {
            UpdateClients();
        }

        private void cb_students_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateClients();
        }

        private void BtnOtchet_Click(object sender, RoutedEventArgs e)
        {
            this.DGridStudents.SelectAllCells();
            this.DGridStudents.ClipboardCopyMode = DataGridClipboardCopyMode.IncludeHeader;
            ApplicationCommands.Copy.Execute(null, this.DGridStudents);
            this.DGridStudents.UnselectAllCells();
            String result = Clipboard.GetData(DataFormats.CommaSeparatedValue).ToString();
            try
            {
                //StreamWriter sw = new StreamWriter("Sells.csv");
                StreamWriter sw = new StreamWriter(new FileStream("Students.csv", FileMode.OpenOrCreate), Encoding.UTF32);
                sw.WriteLine(result);
                sw.Close();
                Process.Start("Students.csv");
            }
            catch (Exception ex)
            { }
        }
    }
}
