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

namespace Lenovodisplay
{   
    public partial class MainWindow : Window
    {
        LenovoDbEntities db = new LenovoDbEntities();
        List<Lenovo> lenov = new List<Lenovo>();
        public MainWindow()
        {
            InitializeComponent();
            // ShowDataOnGrid();
            lenov = db.Lenovoes.ToList();
            grdlenovo.ItemsSource = lenov;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (cmbtype.Text != "")
            {
                lenov = db.Lenovoes.Where(l => l.DeviceType == cmbtype.Text).Select(l => l).ToList();
                ShowDataOnGrid();
                grdlenovo.Items.Refresh();
            }
        }
        public void ShowDataOnGrid()
        {
           // lenov = db.Lenovoes.ToList();
            grdlenovo.ItemsSource = lenov;
        }
    }
}
