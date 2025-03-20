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
using WpfAppMarathon.Entites;

namespace WpfAppMarathon.Pages.AdminPages.UserPages.UserControl
{
    /// <summary>
    /// Логика взаимодействия для AddUserPage.xaml
    /// </summary>
    public partial class AddUserPage : Page
    {
        public AddUserPage()
        {
            InitializeComponent(); 
            RoleCmb.ItemsSource = Core.DB.Role.ToList();
        }

        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {
           

            var email = EmailTxb.Text;
            var name = NameTxb.Text;
            var family = LastNameTxb.Text;
            var pass = Pass1.Password;
            var pass2 = Pass2.Password;
            var Selrole = RoleCmb.SelectedItem as Role;
           

            if (Selrole == null)
            {
                MessageBox.Show("Выберите роль");
                return;
            }
            var role = Selrole.RoleId;
            if (pass != pass2)
            {
                MessageBox.Show("Введите одинаковые пароли");
                return;
            }
            if (pass.Length < 4)
            {
                MessageBox.Show("пароль меньше 4 символов");
                return;
            }
            if (!email.Contains("@"))
            {
                MessageBox.Show("нет @, введите корректный email");
                return;
            }
            var correctPass = false;
            for (var i = 0; i < pass.Length; i++)
            {
                if (char.IsLetter(pass[i]))
                {
                    correctPass = true;
                }
            }
            if (!correctPass)
            {
                MessageBox.Show("некорректный пароль нет буквы");
                return;
            }
            correctPass = false;
            for (var i = 0; i < pass.Length; i++)
            {
                if (char.IsDigit(pass[i]))
                {
                    correctPass = true;
                }
            }
            if (!correctPass)
            {
                MessageBox.Show("некорректный пароль нет числа");
                return;
            }

            correctPass = false;
            for (var i = 0; i < pass.Length; i++)
            {
                if (char.IsUpper(pass[i]))
                {
                    correctPass = true;
                }
            }
            if (!correctPass)
            {
                MessageBox.Show("некорректный пароль нет большой буквы");
                return;
            }

            var specialChars = "!@#$%^&*()_+-";
            foreach (var c in pass)
            {
                if (specialChars.Contains(c))
                {
                    correctPass = true;
                }
            }
            if (!correctPass)
            {
                MessageBox.Show("некорректный пароль нет спец символа");
                return;
            }

            if (name == null || family == null || RoleCmb.SelectedItem == null)
            {
                MessageBox.Show("Заполните поля");
            }

            var u = new User
            {
                Email = email,
                Password = pass,
                FirstName = name,
                LastName = family,
                RoleId = role,
            };

            try
            {
                Core.DB.User.Add(u);
                Core.DB.SaveChanges();
                MessageBox.Show("Пользователь добавлен");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void CancelBtn_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.GoBack();
        }
    }
}
