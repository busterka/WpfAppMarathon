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

namespace WpfAppMarathon.Pages.AdminPages.UserPages.RunnerControl
{
    /// <summary>
    /// Логика взаимодействия для EditRunnerPage.xaml
    /// </summary>
    public partial class EditRunnerPage : Page
    {
        

        public EditRunnerPage(Registration r)
        {
            InitializeComponent();
            CMBGender.ItemsSource = Core.DB.Gender.ToList();
            CMBCountry.ItemsSource = Core.DB.Country.ToList();
            CMBStatus.ItemsSource = Core.DB.RegistrationStatus.ToList();

            Curr = r;
            DataContext = this;
        }
        public Registration Curr { get; set; }
        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {
            var name = TxtName.Text;
            var family = TxtLName.Text;
            var gender = CMBGender.Text;
            var piker = Convert.ToDateTime(DPDate.Text);
            var country = CMBCountry.Text;
            var status = CMBStatus.Text;
            var pass1 = Pass1.Password;
            var pass2 = Pass2.Password;

            if (name == null || family == null || gender == null || piker == null || country == null || status == null)
            {
                MessageBox.Show("Заполните поля");
                return;
            }
            try
            {
                Core.DB.SaveChanges();
                MessageBox.Show("Сохранено");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void CancelBtn_Click(object sender, RoutedEventArgs e)
        {

        }

    }
}
