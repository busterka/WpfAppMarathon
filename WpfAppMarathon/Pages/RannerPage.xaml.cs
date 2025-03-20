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
    
    public partial class RannerPage : Page
    {
        public RannerPage(Runner r)
        {
            CurrentRunner = r;
            DataContext = this;
        }
        public Runner CurrentRunner
        {
            get; set;
        }
    }
}
