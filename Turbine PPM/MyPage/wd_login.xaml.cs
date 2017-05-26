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
using System.Windows.Shapes;

namespace Turbine_PPM.MyPage
{
    /// <summary>
    /// wd_login.xaml 的交互逻辑
    /// </summary>
    public partial class wd_login : Window
    {
        public wd_login()
        {
            InitializeComponent();
        }

        public wd_login(MainWindow theMainWindow)
        {
            InitializeComponent();
            ProgramMainWindow = theMainWindow;
        }

        static private Window ProgramMainWindow;

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            //Turbine_PPM.MainWindow frm = new MainWindow(this);
            MeansClass.MeansLogin ML = new MeansClass.MeansLogin(this, ProgramMainWindow);
            ML.HideLoginWindow();
            ML.ShowMainWindow();
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
