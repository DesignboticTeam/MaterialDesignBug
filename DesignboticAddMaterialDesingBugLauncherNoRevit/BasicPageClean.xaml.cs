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

namespace DesignboticAddMaterialDesingBugLauncher { 
    /// <summary>
    /// Interaction logic for BasicPageClean.xaml
    /// </summary>
    public partial class BasicPageClean : Page
    {
        public BasicPageClean()
        {
            InitializeComponent();
            DataContext = new BasicWindowViewModel();
        }
    }
}
