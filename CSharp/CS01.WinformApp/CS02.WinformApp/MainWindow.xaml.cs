using DevExpress.Utils.CommonDialogs.Internal;
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

namespace CS02.WinformApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnOut_Click(object sender, RoutedEventArgs e)
        {
            DialogResult dlr = (DialogResult)MessageBox.Show("Bạn có thực sự muốn thoát không", "Thông báo", MessageBoxButton.YesNo);
            this.Close();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            if(gT.SelectedIndex > 0)
            {
                gT.SelectedIndex = gT.SelectedIndex - 1;
            }
            if(phong.SelectedIndex > 0)
            {
                phong.SelectedIndex = phong.SelectedIndex - 1;
            }
            string space = " - ";
            lstPerson.Items.Add(txtName.Text + space + gT.Text + space + phong.Text);
        }
    }
}
