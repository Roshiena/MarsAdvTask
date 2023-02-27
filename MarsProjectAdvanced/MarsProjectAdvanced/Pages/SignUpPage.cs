using MarsProjectAdvanced.Utitlities;
using MarsProjectAdvanced.Input;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsProjectAdvanced.Pages
{
    public class SignupPage : CommonDriver
    {


        public IWebElement joinButton => driver.FindElement(By.XPath("//button[contains(text(),'Join')]"));
        public IWebElement firstNamebox => driver.FindElement(By.XPath("//body/div[2]/div[1]/div[1]/form[1]/div[1]/input[1]"));
        public IWebElement lastNamebox => driver.FindElement(By.XPath("//body/div[2]/div[1]/div[1]/form[1]/div[2]/input[1]"));
        public IWebElement emailId => driver.FindElement(By.XPath("//input[@placeholder='Email address']"));
        public IWebElement passwordButton => driver.FindElement(By.XPath("//body/div[2]/div[1]/div[1]/form[1]/div[4]/input[1]"));
        public IWebElement passwordConfirm => driver.FindElement(By.XPath("//body/div[2]/div[1]/div[1]/form[1]/div[5]/input[1]"));
        public IWebElement agreeTerms => driver.FindElement(By.XPath("//body/div[2]/div[1]/div[1]/form[1]/div[6]/div[1]/div[1]/input[1]"));
        public IWebElement submitButton => driver.FindElement(By.XPath("//div[@id='submit-btn']"));

        


        public void SignUp()
        {


            ReadDataFromEXcel();
            ExcelReader.ReadDataTable(stream, "Signup");
            joinButton.Click();

            firstNamebox.Click();
            string firstName = ExcelReader.ReadData(1, "Firstname");
            firstNamebox.SendKeys(firstName);

            lastNamebox.SendKeys("Roro");

            emailId.Click();
            string emailAddress = ExcelReader.ReadData(1, "Email");
            emailId.SendKeys(emailAddress);

            passwordButton.Click();

            string passWord = ExcelReader.ReadData(1, "Password");
            passwordButton.SendKeys(passWord);

            passwordConfirm.Click();

            string passWordConfirm = ExcelReader.ReadData(1, "ConfirmPassword");
            passwordConfirm.SendKeys(passWordConfirm);

            agreeTerms.Click();
            submitButton.Click();
            stream.Dispose();

        }

    }

}