using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using MarsProjectAdvanced.Utitlities;
using MarsProjectAdvanced.Pages;
using AventStack.ExtentReports;
using MarsProjectAdvanced.Input;

namespace MarsProjectAdvanced.Tests
{
    [TestFixture]
    public class ChangePasswordTest : CommonDriver
    {

        LoginPage loginPageObj;
        ChangePasswordPage passwordPageObj;

        public ChangePasswordTest()
        {
            loginPageObj = new LoginPage();
            passwordPageObj = new ChangePasswordPage();
        }


        [Test, Order(5)]

        public void PasswordTest()

        {
            try
            {
                
                test = extentreportobj.CreateTest("ChangePassword", "Testing Change Password");
                string currentpwd = LoginCredentials.currentpwd;
                string newpwd = LoginCredentials.newpwd;
                string confirmpwd = LoginCredentials.newpwd;
                passwordPageObj.ChangePassword(currentpwd, newpwd, confirmpwd);
                string loggedNewPassword = loginPageObj.LoginChangedPassword();
                Assert.That(loggedNewPassword == "Mars Logo", "Password not changed");
                ClickScreenshot.LoginScreenShot();
                test.Log(Status.Info, "Password changed successfully");
                test.Log(Status.Pass, "Test passed");
                passwordPageObj.ChangeOldPassword(currentpwd, newpwd, newpwd);
            }
            catch (Exception ex)
            {
                ClickScreenshot.LoginScreenShot();
                test.Log(Status.Fail, "Test failed");

                throw;
            }

        }
    }
}

