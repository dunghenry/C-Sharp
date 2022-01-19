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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Text.RegularExpressions;
using System.Reflection;

namespace TranVanDung_537
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        NhanvienDBContext li = new NhanvienDBContext();
        public MainWindow()
        {
            InitializeComponent();
            var query = from nhanvien in li.Nhanviens
                        where nhanvien.Songaycong >= 25
                        orderby nhanvien.Songaycong ascending
                        select new
                        {
                            MaPhong = nhanvien.MaPhong,
                            MaNv = nhanvien.MaNv,
                            Hoten = nhanvien.Hoten,
                            Songaycong = nhanvien.Songaycong,
                            Luong = nhanvien.Luong,
                            Thuong = nhanvien.Songaycong >= 27 ? nhanvien.Luong * 0.1 : 0,
                        };
            dgList.ItemsSource = query.ToList();

            comboBoxItem();
        }

        private void dataGridItem()
        {
            var query = from nhanvien in li.Nhanviens
                        select new
                        {
                            MaPhong = nhanvien.MaPhong,
                            MaNv = nhanvien.MaNv,
                            Hoten = nhanvien.Hoten,
                            Songaycong = nhanvien.Songaycong,
                            Luong = nhanvien.Luong,
                            Thuong = nhanvien.Songaycong >= 27 ? nhanvien.Luong * 0.1 : 0,
                        };
            dgList.ItemsSource = query.ToList();
        }

        private void comboBoxItem()
        {
            var query = from phongban in li.PhongBans
                        select phongban;
            cbCategory.ItemsSource = query.ToList();
            cbCategory.SelectedValuePath = "MaPhong";
            cbCategory.DisplayMemberPath = "TenPhong";
            cbCategory.SelectedIndex = 0;
        }

        private bool DuLieuHopLe()
        {
            string ErrMsg = "";
            if (string.IsNullOrEmpty(tbID.Text) || string.IsNullOrEmpty(tbName.Text) || string.IsNullOrEmpty(tbDate.Text) || string.IsNullOrEmpty(tbSalary.Text))
            {
                ErrMsg += "Bạn chưa nhập đủ thông tin!";
            }

            if (!Regex.IsMatch(tbSalary.Text, @"\d+") || !Regex.IsMatch(tbDate.Text, @"\d+"))
            {
                ErrMsg += "Ngày công và lương phải là số!";
            }
            else
            {
                int salary = int.Parse(tbSalary.Text);
                int date = int.Parse(tbDate.Text);
                if (date < 20 || date > 30)
                {
                    ErrMsg += "Ngày công phải từ 20 đến 30!";
                }
                if (salary < 3000 || salary > 9000)
                {
                    ErrMsg += "Lương phải từ 3000 đến 9000";
                }
                if (tbName.Text.Length > 30)
                {
                    ErrMsg += "Họ tên phải ít hơn 30 ký tự!";
                }
            }

            if (ErrMsg != "")
            {
                MessageBox.Show(ErrMsg, "Thông báo");
                return false;
            }
            return true;
        }

        private void btAdd_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (DuLieuHopLe())
                {
                    var check = (from nhanvien in li.Nhanviens
                                 where nhanvien.MaNv.ToString() == tbID.Text
                                 select nhanvien).SingleOrDefault();
                    if (check != null)
                    {
                        MessageBox.Show("Đã tồn tại mã nhân viên!");
                    }
                    else
                    {
                        Nhanvien a = new Nhanvien();
                        a.MaNv = int.Parse(tbID.Text);
                        a.Hoten = tbName.Text;
                        a.Songaycong = int.Parse(tbDate.Text);
                        a.Luong = int.Parse(tbSalary.Text);
                        a.MaPhong = int.Parse(cbCategory.SelectedValue.ToString());

                        li.Nhanviens.Add(a);
                        li.SaveChanges();
                        dataGridItem();
                    }
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show("\nCó lỗi khi thêm: " + e1.Message, "Thông báo");
            }
        }

        private void btFix_Click(object sender, RoutedEventArgs e)
        {
            var select = dgList.SelectedItem;
            if (select == null)
            {
                MessageBox.Show("Chưa chọn thuốc để sửa!");
            }
            else
            {
                if (DuLieuHopLe())
                {
                    Type type = dgList.SelectedItem.GetType();
                    PropertyInfo[] propertyInfos = type.GetProperties();
                    string id = propertyInfos[1].GetValue(dgList.SelectedItem).ToString();
                    var query = (from nhanvien in li.Nhanviens
                                 where nhanvien.MaNv.ToString() == id
                                 select nhanvien).SingleOrDefault();
                    if (tbID.Text != id)
                    {
                        MessageBox.Show("Không được sửa mã nhân viên!");
                    }
                    else
                    {
                        query.Hoten = tbName.Text;
                        query.Songaycong = int.Parse(tbDate.Text);
                        query.Luong = int.Parse(tbSalary.Text);
                        query.MaPhong = int.Parse(cbCategory.SelectedValue.ToString());
                        li.SaveChanges();
                        dataGridItem();
                    }
                }
            }
        }

        private void btDelete_Click(object sender, RoutedEventArgs e)
        {
            var select = dgList.SelectedItem;
            if (select == null)
            {
                MessageBox.Show("Chưa chọn thuốc để xóa!");
            }
            else
            {
                Type type = dgList.SelectedItem.GetType();
                PropertyInfo[] propertyInfos = type.GetProperties();

                string id = propertyInfos[1].GetValue(dgList.SelectedItem).ToString();
                var query = (from nhanvien in li.Nhanviens
                             where nhanvien.MaNv.ToString() == id
                             select nhanvien).SingleOrDefault();
                
                var result = MessageBox.Show("Bạn có muốn xóa nhân viên " + tbID.Text, "Thông báo", MessageBoxButton.YesNo);
                if (result == MessageBoxResult.Yes)
                {
                    li.Nhanviens.Remove(query);
                    li.SaveChanges();
                    dataGridItem();
                }
            }
        }

        private void dgList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var seleted = dgList.SelectedItem;
            if (seleted != null)
            {
                Type itemselected = dgList.SelectedItem.GetType();
                PropertyInfo[] propertyInfo = itemselected.GetProperties();

                tbID.Text = propertyInfo[1].GetValue(dgList.SelectedItem).ToString();
                tbName.Text = propertyInfo[2].GetValue(dgList.SelectedItem).ToString();
                tbDate.Text = propertyInfo[3].GetValue(dgList.SelectedItem).ToString();
                tbSalary.Text = propertyInfo[4].GetValue(dgList.SelectedItem).ToString();
                cbCategory.SelectedValue = propertyInfo[0].GetValue(dgList.SelectedItem).ToString();
            }
        }

        private void btSearch_Click(object sender, RoutedEventArgs e)
        {
            Window2 t = new Window2();
            t.ShowDialog();
        }
    }
}
