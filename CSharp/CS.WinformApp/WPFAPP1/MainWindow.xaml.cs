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

namespace WPFAPP1
{
    /// <summary>
    //Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
      
        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            string gioiTinh, ketHon, soThich = " ";
            if (radioNam.IsChecked == true)
                gioiTinh = "Nam";
            else
            {
                gioiTinh = "Nữ";
            }
            ketHon = RadioDaKetHon.IsChecked == true ? ketHon = "Đã kết hôn" : ketHon = "Chưa kết hôn";

            if(chkBongda.IsChecked == true)
            {
                soThich = "Bóng đá";
            }
            if (chkBoiloi.IsChecked == true)
            {
                soThich += ", Bơi lội";
            }
            if (chkAmnhac.IsChecked == true)
            {
                soThich += ", Âm nhạc";
            }
            if (chkLeonui.IsChecked == true)
            {
                soThich += ", Leo núi";
            }

            if(soThich.Substring(0, 1) == ";")
            {
                soThich = soThich.Substring(2, soThich.Length - 2);
            }


            lstPerson.Items.Clear();
            lstPerson.Items.Add("Họ tên : " + txtName.Text);
            lstPerson.Items.Add("Giới tính : " + gioiTinh);
            lstPerson.Items.Add("Tình trạng kết hôn : " + ketHon);
           lstPerson.Items.Add("Sở thích : " + soThich);
        }

        private void btnOut_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
