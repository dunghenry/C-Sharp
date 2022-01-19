using TranVanDung_537.Models;
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
using System.Windows.Shapes;

namespace TranVanDung_537
{
    /// <summary>
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        NhanvienDBContext li = new NhanvienDBContext();
        public Window2()
        {
            InitializeComponent();

            var query = from nhanvien in li.Nhanviens
                        group nhanvien by nhanvien.MaPhong into groups
                        select new
                        {
                            Maphong = groups.Key,
                            SoLuong= groups.Count(),
                            Tong = (from x in groups
                                    select x.Luong).Sum()
                        };
            var query2 = from a in li.PhongBans
                         join b in query
                         on a.MaPhong equals b.Maphong into groups
                         from b in groups.DefaultIfEmpty()
                         select new
                         {
                             MaPhong = a.MaPhong,
                             TenPhong = a.TenPhong,
                             SoLuong= b.SoLuong,
                             TongLuong = b != null ? b.Tong.GetValueOrDefault(0) : default
                         };
            dgList.ItemsSource = query2.ToList();
        }
    }
}
