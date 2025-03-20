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

namespace WpfAppMarathon.Pages
{

    public partial class AutorizPage : Page
    {
        public AutorizPage()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {

            var email = EmailTexboxPag3.Text;
            var pass = PasswordPag3.Password;
            var db = new Entites.MarathonSkillsEntities2();
       
            var runner = Core.DB.Runner.Where(r => r.Email == email && r.User.Password == pass).FirstOrDefault();
            var admin = Core.DB.User.Where(a => a.Email == email && a.Password ==pass && a.RoleId == "A").FirstOrDefault();
           
            if (runner != null)
            {
                var p = new RannerPage(runner);
                this.NavigationService.Navigate(new RannerPage(runner));

            }
            else if (admin != null)
            {
                this.NavigationService.Navigate(new AdminPages.AdminMenuPage());
            }
            else
            {
                MessageBox.Show(" Не найден ");
            }
          
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.GoBack();
        }
    }

}
