using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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
using System.IO;
namespace WpfAppMarathon.Pages.AdminPages.UserPages.RunnerControl
{
   public partial class ControlRunnerPage : Page, INotifyPropertyChanged
    {
   
        private CollectionViewSource _runnerViewSource;
        public ICollectionView RunnerView => _runnerViewSource.View;

      
        public ObservableCollection<string> StatusOptions { get; set; } = new ObservableCollection<string>() { "All", "Race Attended", "Race Kit Sent", "Payment Confirmed", "Registered" };
        public ObservableCollection<string> DistanceOptions { get; set; } = new ObservableCollection<string>() { "All" };

        private string _selectedStatus = "All";
        public string SelectedStatus
        {
            get { return _selectedStatus; }
            set
            {
                _selectedStatus = value;
                OnPropertyChanged(nameof(SelectedStatus));
                RunnerView.Refresh();
            }
        }

        private string _selectedDistance = "All";
        public string SelectedDistance
        {
            get { return _selectedDistance; }
            set
            {
                _selectedDistance = value;
                OnPropertyChanged(nameof(SelectedDistance));
                RunnerView.Refresh();
            }
        }

        public ObservableCollection<User> Users { get; private set; }

        public ControlRunnerPage()
        {
            InitializeComponent();
            DGRunner.ItemsSource = Core.DB.Registration.ToList();

            _runnerViewSource = new CollectionViewSource();
            _runnerViewSource.Source = Core.DB.Registration.Local;

    
            DataContext = this;
            DGRunner.ItemsSource = RunnerView;


            RunnerView.Filter = FilterRunner;
        }

        private bool FilterRunner(object obj)
        {
            if (!(obj is Entites.Registration runner)) 
            {
                return false;
            }

 
            bool statusMatch = string.IsNullOrEmpty(SelectedStatus) || SelectedStatus == "All" || runner.RegistrationStatus.Status == SelectedStatus;

      
            bool distanceMatch = string.IsNullOrEmpty(SelectedDistance) || SelectedDistance == "All";
          

            return statusMatch && distanceMatch;
        }

        private void BTNEdit_Click(object sender, RoutedEventArgs e)
        {
            Registration r = DGRunner.SelectedItem as Registration;
            this.NavigationService.Navigate(new RunnerControl.EditRunnerPage(r));
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           
        }


        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV files (*.csv)|*.csv";
            if (saveFileDialog.ShowDialog() == true)
            {
                try
                {
                    using (StreamWriter sw = new StreamWriter(saveFileDialog.FileName))
                    {
                      
                        sw.WriteLine("Имя,Фамилия,Email,Статус");

                   
                        foreach (var item in Core.DB.Registration.ToList()) 
                        {
                            string firstName = item.Runner?.User?.FirstName ?? ""; 
                            string lastName = item.Runner?.User?.LastName ?? "";   
                            string email = item.Runner?.User?.Email ?? "";       
                            string status = item.RegistrationStatus?.Status ?? "";   

                          
                            firstName = firstName.Replace(",", "[,]");
                            lastName = lastName.Replace(",", "[,]");
                            email = email.Replace(",", "[,]");
                            status = status.Replace(",", "[,]");

                            sw.WriteLine($"{firstName},{lastName},{email},{status}");
                        }
                    }
                    MessageBox.Show("Данные успешно экспортированы в CSV!", "Экспорт завершен", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при экспорте в CSV: {ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }


        private string EscapeCsvField(string field)
        {
            if (string.IsNullOrEmpty(field))
            {
                return "";
            }

       
            if (field.Contains(",") || field.Contains("\"") || field.Contains("\n"))
            {
              
                field = field.Replace("\"", "\"\"");
                return $"\"{field}\"";
            }

            return field;
        }
    }
}
