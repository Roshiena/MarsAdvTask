using MarsProjectAdvanced.Utitlities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarsProjectAdvanced.Pages;

namespace MarsProjectAdvanced.Pages
{
    public class ChangePasswordPage : CommonDriver
    {
        public IWebElement userDropdown => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/div[1]/div[2]/div/span"));
        public IWebElement changePassword => driver.FindElement(By.XPath("//a[contains(text(),'Change Password')]"));
        public IWebElement currentPassword => driver.FindElement(By.XPath("//body/div[4]/div[1]/div[2]/form[1]/div[1]/input[1]"));
        public IWebElement newPassword => driver.FindElement(By.XPath("//body/div[4]/div[1]/div[2]/form[1]/div[2]/input[1]"));
        public IWebElement confirmPassword => driver.FindElement(By.XPath("//body/div[4]/div[1]/div[2]/form[1]/div[3]/input[1]"));
        public IWebElement savePassword => driver.FindElement(By.XPath("//body/div[4]/div[1]/div[2]/form[1]/div[4]/button[1]"));
        public IWebElement signoutButton => driver.FindElement(By.XPath("//button[contains(text(),'Sign Out')]"));
        public IWebElement forgotPassword => driver.FindElement(By.XPath("//a[contains(text(),'Forgot your password?')]"));
        public IWebElement signIn => driver.FindElement(By.XPath("//*[@id=\"home\"]/div/div/div[1]/div/a"));
        public IWebElement emailId => driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[1]/input"));
        public IWebElement passwordTextbox => driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[2]/input"));
        public IWebElement loginButton => driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button"));





        public void ChangePassword(string currentpwd, string newpwd, string confirmpwd)
        {
            WaitHelpers.WaitToBeClickable(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/div[1]/div[2]/div/span", 20);
            // Thread.Sleep(3000);
            userDropdown.SendKeys(Keys.Enter);
            changePassword.Click();
            currentPassword.SendKeys(currentpwd);
            newPassword.SendKeys(newpwd);
            confirmPassword.SendKeys(confirmpwd);
            savePassword.Click();
            signoutButton.Click();
        }


        public void ChangeOldPassword(string currentpwd, string newpwd, string confirmpwd)
        {
            WaitHelpers.WaitToBeClickable(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/div[1]/div[2]/div/span", 20);
            userDropdown.SendKeys(Keys.Enter);
            // Thread.Sleep(3000);
            changePassword.Click();
            currentPassword.SendKeys(newpwd);
            newPassword.SendKeys(currentpwd);
            confirmPassword.SendKeys(currentpwd);
            savePassword.Click();

        }
    }
}