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

namespace Diplomnaya
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        public static class Globals
        {
            public static int UserRole;
            public static bool UserAdd;
            public static User userinfo { get; set; }
        }

        private void EnterBtn_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();
            using (var db = new Student_CountsEntities())
            {
                var user = db.Users.AsNoTracking().FirstOrDefault(u => u.Login == Log.Text && u.Password == Pass.Password);
                var logi = db.Users.AsNoTracking().FirstOrDefault(u => u.Login == Log.Text);
                if (logi == null)
                {
                    errors.AppendLine("Пользователь не найден ");
                }

                if (user == null)
                {
                    errors.AppendLine("Неверный пароль");
                }

                if (errors.Length > 0)
                    MessageBox.Show(errors.ToString());
                if (errors.Length == 0)
                {
                    Globals.UserRole = user.Roleid;
                    Globals.userinfo = user;
                    GlavWindow glavpage = new GlavWindow();
                    glavpage.Show();
                    this.Close();
                }
            }
        }
    }
}
