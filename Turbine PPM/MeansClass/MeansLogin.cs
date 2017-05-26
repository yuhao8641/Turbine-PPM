using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Turbine_PPM.Msdn5Codes;

using System.Windows;

namespace Turbine_PPM.MeansClass
{
    class MeansLogin : IMeansLogin
    {
        private static Window _theLoginWindow;
        private static Window _theMainWindow;

        public Window theLoginWindow
        {
            get { return _theLoginWindow; }
        }
        public Window theMainWindow
        {
            get { return _theMainWindow; }
        }




        public MeansLogin(Window SendInLoginWindow, Window SendInMainWindow)
        {
            _theLoginWindow = SendInLoginWindow;
            _theMainWindow = SendInMainWindow;

        }
        /// <summary>
        /// UI无法测试
       /// </summary>
        internal void HideLoginWindow()
        {
            theLoginWindow.Hide();
        }

        internal void ShowLoginWindow()
        {
            theLoginWindow.Show();
        }


        internal void ShowMainWindow()
        {
            theMainWindow.Show();
        }
 



        public bool IsValidUser(string userName, string password)
        {
            bool isUserExist;
            try
            {

                isUserExist = MySqlHelper.Exists("SELECT * FROM `t_user` where username='yuhao' and password='6641';");
                return isUserExist;
            }
            catch
            {
                return false;
            }

        }

    }
}
