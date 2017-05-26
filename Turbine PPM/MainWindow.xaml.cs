using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Turbine_PPM
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow(MyPage.wd_login frmlogin)
        {
            
            this.Show();
            frmlogin.Close();
        }

        public MainWindow()
        {
            
            InitializeComponent();
            this.Hide();
            MyPage.wd_login frmlogin = new MyPage.wd_login(this );
            frmlogin.ShowDialog();
           
           
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
        
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            MyPage.wd_login newlogin = new MyPage.wd_login();
            MeansClass.MeansLogin rrr = new MeansClass.MeansLogin(newlogin, this);
            rrr.ShowLoginWindow();
        }

 
    }
}
