using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
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
    /// Логика взаимодействия для UserEditPage.xaml
    /// </summary>
    public partial class UserEditPage : Page
    {
        public UserEditPage(User u)
        {
            InitializeComponent();
            RoleCmb.ItemsSource = Core.DB.Role.ToList();
            Curr = u;
            DataContext = this;
        }
        public User Curr { get; set; }

        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {
            var name = NameTxb.Text;
            var family = LastNameTxb.Text;
            var pass1 = Pass1.Password;
            var pass2 = Pass2.Password;

            if (name == null || family == null || !(RoleCmb.SelectedItem is Role))
            {
                MessageBox.Show("Заполните поля");
                return;
            }
            try
            {
                Core.DB.SaveChanges();
                MessageBox.Show("Сохранено");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void CancelBtn_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.GoBack();
        }

        private void NameTxb_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
