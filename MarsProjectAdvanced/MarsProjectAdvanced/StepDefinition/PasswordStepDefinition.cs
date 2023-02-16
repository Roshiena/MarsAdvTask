using AventStack.ExtentReports;
using MarsProjectAdvanced.Utitlities;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using ExcelDataReader;
using MarsProjectAdvanced.Pages;

namespace MarsProjectAdvanced.StepDefinition
{
    [Binding]
    public class PasswordStepDefinition : CommonDriver
    {
        LoginPage loginPageObj;
        ChangePasswordPage passwordPageObj;

        public PasswordStepDefinition()
        {
            loginPageObj = new LoginPage();
            passwordPageObj = new ChangePasswordPage();
        }

        [When(@"I change '([^']*)' , '([^']*)' and '([^']*)' in the profile")]
        public void WhenIChangeAndInTheProfile(string currentpwd, string newpwd, string confirmpwd)
        {
            passwordPageObj.ChangePassword(currentpwd, newpwd, confirmpwd);
        }

        [Then(@"The '([^']*)' , '([^']*)' and '([^']*)' should be changed in the profile")]
        public void ThenTheAndShouldBeChangedInTheProfile(string currentpwd, string newpwd, string confirmpwd)
        {
            try
            {
                test = extentreportobj.CreateTest("ChangePassword", "Testing Change Password");
                string loggedNewPassword = loginPageObj.LoginChangedPassword();
                Assert.That(loggedNewPassword == "Mars Logo", "Password not changed");
                ClickScreenshot.LoginScreenShot();
                test.Log(Status.Info, "Password changed successfully");
                test.Log(Status.Pass, "Test passed");
                passwordPageObj.ChangeOldPassword(currentpwd, newpwd, confirmpwd);
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