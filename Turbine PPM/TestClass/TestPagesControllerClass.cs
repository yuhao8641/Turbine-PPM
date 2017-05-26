using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Turbine_PPM.MeansClass;

namespace Turbine_PPM.TestClass
{
    [TestFixture]
    class TestPagesControllerClass
    {
        [Test]
        public void DoLogin_ValidUser_LoginStateInDataCenterChangeto1()
        {
            //PagesController使用参数——MeansLogin类
            //MeansLogin类包含登录窗口的Window类实例，和主窗口的Window类实例，对这两个窗口进行关闭和显示。
            //MeansLogin类还负责用户名和密码是否正确的检测。
            //桩对象StubMeansLogin类，用于假设始终正确验证用户名和密码
            StubMeansLogin theFakeMLogin = new StubMeansLogin();
            if (theFakeMLogin.IsValidUser(TestDatas.testusername, TestDatas.testpassword))
            {
                Assert.AreEqual(1, DataCenter.LoginState = 1,"The User is valid but loginstate is program didn't change!");
            }
        }
    }

    //桩对象
    internal class StubMeansLogin : IMeansLogin
    {
        public bool IsValidUser(string userName, string password)
        {
            return true;
        }
    }



}
