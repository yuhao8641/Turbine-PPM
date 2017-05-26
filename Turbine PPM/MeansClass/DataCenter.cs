using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Turbine_PPM.MeansClass
{
    class DataCenter
    {
        public static int LoginState; //0为未登录，1为成功登录

        public static void InitialMyInfos()
        {
            LoginState = 0;
        }
    }
}
