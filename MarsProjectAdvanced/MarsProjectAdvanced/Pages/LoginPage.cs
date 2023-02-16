using MarsProjectAdvanced.Input;
using MarsProjectAdvanced.Utitlities;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsProjectAdvanced.Pages
{

    public class LoginPage : CommonDriver
    {
        public IWebElement signIn => driver.FindElement(By.XPath("//*[@id=\"home\"]/div/div/div[1]/div/a"));
        public IWebElement emailId => driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[1]/input"));
        public IWebElement passwordTextbox => driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[2]/input"));
        public IWebElement loginButton => driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button"));
        public IWebElement forgotPassword => driver.FindElement(By.XPath("//a[contains(text(),'Forgot your password?')]"));
        public IWebElement marsLogo => driver.FindElement(By.XPath("//a[contains(text(),'Mars Logo')]"));




        public void LoginSteps()
        {
            try
            {

                //Enter valid username and valid password
                signIn.Click();
                emailId.SendKeys(LoginCredentials.userName);
                passwordTextbox.SendKeys(LoginCredentials.passWord);

                //Click login button
                loginButton.Click();
                WaitHelpers.WaitToBeVisible(driver, "XPath", "//a[contains(text(),'Mars Logo')]", 20);

            }
            catch (Exception ex)
            {
                Assert.Fail("Unable to launch Mars portal", ex.Message);
            }

        }

        public string LoginChangedPassword()
        {
            // driver.Navigate().GoToUrl(LoginCredentials.urlLink);
            Waits();
            signIn.Click();
            emailId.SendKeys(LoginCredentials.userName);
            passwordTextbox.SendKeys(LoginCredentials.passWord2);
            loginButton.Click();
            WaitHelpers.WaitToBeVisible(driver, "XPath", "//a[contains(text(),'Mars Logo')]", 20);
            return marsLogo.Text;
        }


    }
}