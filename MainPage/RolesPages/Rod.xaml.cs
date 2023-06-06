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
    /// Логика взаимодействия для Rod.xaml
    /// </summary>
    public partial class Rod : Page
    {
        public Rod()
        {
            InitializeComponent();
            if (MainWindow.Globals.UserRole == 2)
            {
                BtnDel.Visibility = Visibility.Hidden;
                BtnAdd.Visibility = Visibility.Hidden;
            }
            DGridStudents.ItemsSource = Student_CountsEntities.GetContext().Mothers.ToList();
            DGridStudents.ItemsSource = Student_CountsEntities.GetContext().Fathers.ToList();
            Rod.Globals.MothFath = 1;
            UpdateClients();
        }
        public static class Globals
        {
            public static int MothFath;
        }
        public void UpdateClients()
        {
            var currentUsers = Student_CountsEntities.GetContext().Mothers.ToList();
            DGridStudents.ItemsSource = Student_CountsEntities.GetContext().Mothers.ToList();
            currentUsers = currentUsers.Where(p => p.Surname.ToLower().Contains(TBoxSearch1.Text.ToLower())).ToList();
            DGridStudents.ItemsSource = currentUsers.OrderBy(p => p.Name).ToList();
            DGridStudents.ItemsSource = currentUsers;
        }
        public void UpdateClients1()
        {
            var currentUsers = Student_CountsEntities.GetContext().Fathers.ToList();
            DGridStudents.ItemsSource = Student_CountsEntities.GetContext().Fathers.ToList();
            currentUsers = currentUsers.Where(p => p.Surname.ToLower().Contains(TBoxSearch1.Text.ToLower())).ToList();
            DGridStudents.ItemsSource = currentUsers.OrderBy(p => p.Name).ToList();
            DGridStudents.ItemsSource = currentUsers;
        }
        private void BtnDel_Click(object sender, RoutedEventArgs e)
        {
            if (Rod.Globals.MothFath == 1)
            {
                var MothersForRemoving = DGridStudents.SelectedItems.Cast<Mother>().ToList();
                if (MessageBox.Show($"Чел ты точно хочешь стереть с лица земли {MothersForRemoving.Count()} мам?", "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    try
                    {
                        Student_CountsEntities.GetContext().Mothers.RemoveRange(MothersForRemoving);
                        Student_CountsEntities.GetContext().SaveChanges();
                        UpdateClients();
                        MessageBox.Show("Да ладно, одним больше, одним меньше");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, ToString());
                        DGridStudents.ItemsSource = Student_CountsEntities.GetContext().Mothers.ToList();
                    }
                }
            }
            else
            {
                var FathersForRemoving = DGridStudents.SelectedItems.Cast<Father>().ToList();
                if (MessageBox.Show($"Чел ты точно хочешь стереть с лица земли {FathersForRemoving.Count()} мам?", "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    try
                    {
                        Student_CountsEntities.GetContext().Fathers.RemoveRange(FathersForRemoving);
                        Student_CountsEntities.GetContext().SaveChanges();
                        UpdateClients();
                        MessageBox.Show("Да ладно, одним больше, одним меньше");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, ToString());
                        DGridStudents.ItemsSource = Student_CountsEntities.GetContext().Fathers.ToList();
                    }
                }
            }
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            if (Rod.Globals.MothFath == 1)
                Navigation.FrameStudents.Navigate(new InfoRodPage(null));
            else if (Rod.Globals.MothFath == 2)
                Navigation.FrameStudents.Navigate(new InfoRodPageDouble(null));
        }

        private void Mother_Click(object sender, RoutedEventArgs e)
        {
            Rod.Globals.MothFath = 1;
            UpdateClients();
        }

        private void Father_Click(object sender, RoutedEventArgs e)
        {
            Rod.Globals.MothFath = 2;
            UpdateClients1();
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            if (Rod.Globals.MothFath == 1)
                Navigation.FrameStudents.Navigate(new InfoRodPage((sender as Button).DataContext as Mother));
            else if (Rod.Globals.MothFath == 2)
                Navigation.FrameStudents.Navigate(new InfoRodPageDouble((sender as Button).DataContext as Father));
        }

        private void TBoxSearch1_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Rod.Globals.MothFath == 1) 
            {
                UpdateClients();
            }
            else
            { 
                UpdateClients1();
            }
        }

        private void BtnOtchet_Click(object sender, RoutedEventArgs e)
        {
            if (Rod.Globals.MothFath == 1)
            { 
                this.DGridStudents.SelectAllCells();
                this.DGridStudents.ClipboardCopyMode = DataGridClipboardCopyMode.IncludeHeader;
                ApplicationCommands.Copy.Execute(null, this.DGridStudents);
                this.DGridStudents.UnselectAllCells();
                String result = Clipboard.GetData(DataFormats.CommaSeparatedValue).ToString();
                try
                {
                    //StreamWriter sw = new StreamWriter("Sells.csv");
                    StreamWriter sw = new StreamWriter(new FileStream("Mothers.csv", FileMode.OpenOrCreate), Encoding.UTF32);
                    sw.WriteLine(result);
                    sw.Close();
                    Process.Start("Mothers.csv");
                }
                catch (Exception ex)
                { }
            }
            else if (Rod.Globals.MothFath == 2)
            {
                this.DGridStudents.SelectAllCells();
                this.DGridStudents.ClipboardCopyMode = DataGridClipboardCopyMode.IncludeHeader;
                ApplicationCommands.Copy.Execute(null, this.DGridStudents);
                this.DGridStudents.UnselectAllCells();
                String result = Clipboard.GetData(DataFormats.CommaSeparatedValue).ToString();
                try
                {
                    //StreamWriter sw = new StreamWriter("Sells.csv");
                    StreamWriter sw = new StreamWriter(new FileStream("Fathers.csv", FileMode.OpenOrCreate), Encoding.UTF32);
                    sw.WriteLine(result);
                    sw.Close();
                    Process.Start("Fathers.csv");
                }
                catch (Exception ex)
                { }
            }
        }
    }
}
