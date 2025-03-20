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

namespace WpfAppMarathon.Pages.AdminPages.UserPages.UserControl
{
    /// <summary>
    /// Логика взаимодействия для ControlUserPage.xaml
    /// </summary>
    public partial class ControlUserPage : Page, INotifyPropertyChanged
    {
        private CollectionViewSource _userViewSource;
        public ICollectionView UserView => _userViewSource.View;

     
        public ObservableCollection<Entites.Role> RoleOptions { get; set; }

        private Entites.Role _selectedRole;
        public Entites.Role SelectedRole
        {
            get { return _selectedRole; }
            set
            {
                _selectedRole = value;
                OnPropertyChanged(nameof(SelectedRole));
                UserView.Refresh();
            }
        }


        private string _searchText = "";
        public string SearchText
        {
            get { return _searchText; }
            set
            {
                _searchText = value;
                OnPropertyChanged(nameof(SearchText));
                UserView.Refresh();
            }
        }


        private string _selectedSort = "Фамилия";
        public string SelectedSort
        {
            get { return _selectedSort; }
            set
            {
                _selectedSort = value;
                OnPropertyChanged(nameof(SelectedSort));
                ApplySorting(); 
            }
        }

        public ControlUserPage()
        {
            InitializeComponent();

            _userViewSource = new CollectionViewSource();
            _userViewSource.Source = WpfAppMarathon.Core.DB.User.Local;


 
            RoleOptions = new ObservableCollection<Entites.Role>(WpfAppMarathon.Core.DB.Role.ToList());

            RoleOptions.Insert(0, new Entites.Role { RoleName = "Все роли" });

         
            SortCombo.ItemsSource = new ObservableCollection<string>() { "Имя", "Фамилия", "Email" };
            SelectedSort = "Фамилия"; 


            DataContext = this;
            DGUser.ItemsSource = UserView;
            RoleCombo.ItemsSource = RoleOptions;
            SortCombo.SelectedItem = SelectedSort;  
       
            UserView.Filter = FilterUser;

            ApplySorting();
        }

        private bool FilterUser(object obj)
        {
            if (!(obj is Entites.User user))
            {
                return false;
            }

            bool roleMatch = SelectedRole == null || SelectedRole.RoleName == "Все роли" || user.RoleId == SelectedRole.RoleId;

            bool searchMatch = string.IsNullOrEmpty(SearchText) ||
                                user.FirstName.ToLower().Contains(SearchText.ToLower()) ||
                                user.LastName.ToLower().Contains(SearchText.ToLower()) ||
                                user.Email.ToLower().Contains(SearchText.ToLower());


            return roleMatch && searchMatch;
        }
        private void ApplySorting()
        {
           
            UserView.SortDescriptions.Clear();


            if (SelectedSort == "Фамилия")
            {
                UserView.SortDescriptions.Add(new SortDescription("LastName", ListSortDirection.Ascending));
            }
            else if (SelectedSort == "Имя")
            {
                UserView.SortDescriptions.Add(new SortDescription("FirstName", ListSortDirection.Ascending));
            }
            else if (SelectedSort == "Email")
            {
                UserView.SortDescriptions.Add(new SortDescription("Email", ListSortDirection.Ascending));
            }
        }

        private void AddNewUser_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new UserControl.AddUserPage());
        }

        private void UpdateBtn_Click(object sender, RoutedEventArgs e)
        {
          
            UserView.Refresh();
        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            Entites.User u = DGUser.SelectedItem as Entites.User;
            this.NavigationService.Navigate(new UserControl.UserEditPage(u));
        }
        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility == Visibility.Visible)
            {
                UserView.Refresh();
                DGUser.ItemsSource = Core.DB.User.ToList();
            }
        }

  
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
