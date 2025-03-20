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

namespace WpfAppMarathon.Pages
{
 
    public partial class RegPage : Page
    {
        public RegPage()
        {
            InitializeComponent();
            var countr = Core.DB.Country.ToList();
            ComboCountry.ItemsSource = countr;

            var gen = Core.DB.Gender.ToList();
            PolBox.ItemsSource = gen;
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.GoBack();
        }

        private void RegistrButton_Click(object sender, RoutedEventArgs e)
        {
            var email = EmailTextBox.Text;
            var pass = PasswBox2.Text;
            var pass2 = PasswBox22.Text;
            var name = ImTextBox.Text;
            var fam = FamTextBox.Text;
            var pol = PolBox.Text;
            var DateBirth = Convert.ToDateTime(DatePick.Text);
            var selectCountry = ComboCountry.SelectedItem as Country;
            
            if (selectCountry == null)
            {
                MessageBox.Show("Выберите страну");
                return;
            }
            var strana = selectCountry.CountryCode;
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
            if (pol == null)
            {
                MessageBox.Show("Введите пол");
                return;
            }

            var u = new User();
            u.Email = email;
            u.FirstName = name;
            u.LastName = fam;
            u.Password = pass;
            u.RoleId = "R";
            Core.DB.User.Add(u);
            Core.DB.SaveChanges();

            var r = new Runner();
            r.Email = email;
            r.Gender = pol;
            r.DateOfBirth = DateBirth;
            r.CountryCode = strana;

            if (r.RunnerId == 0)
            {
                Core.DB.Runner.Add(r);
                Core.DB.SaveChanges();
            }
            MessageBox.Show("Пользователь добавлен");
            this.NavigationService.GoBack();


        }
    }

}
