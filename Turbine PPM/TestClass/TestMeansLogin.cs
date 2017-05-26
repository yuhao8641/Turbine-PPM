using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Turbine_PPM.MeansClass;
using System.Windows;


namespace Turbine_PPM.TestClass
{
    [TestFixture]
    class TestMeansLogin
    {
        private MeansLogin theMLogin;
        [SetUp]
        public void Setup()
        {
            Window FakeLoginWindow =new Window();
            Window FakeMainWindow=new Window();

            FakeMainWindow.Hide();
            FakeLoginWindow.Show();

           theMLogin= new MeansLogin(FakeLoginWindow, FakeMainWindow);
        }


        [Test]
        public void HideLoginWindow_isValidUser_LoginWindowHided()
        {
            theMLogin.HideLoginWindow();
            Assert.IsFalse(theMLogin.theLoginWindow.IsVisible,"The user is Valid, but LoginWindow didn't hide!");
        }




        //[Test]
        //public void IsValidUser_UserExist_ReturnTrue()
        //{
        //    MeansLogin theLogin = new MeansLogin();
        //    bool isValidUser = false;
        //    isValidUser= theLogin.IsValidUser("yuhao","6641");
        //    Assert.IsTrue(isValidUser, "The username and password are correct, but the login is failed.");
        //}




    }
}
