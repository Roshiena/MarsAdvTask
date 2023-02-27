using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin.Model;
using MarsProjectAdvanced.Input;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using MarsProjectAdvanced.Pages;
using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MarsProjectAdvanced.Utitlities
{
    [SetUpFixture]
    public class CommonDriver
    {
        public static IWebDriver driver;
        public static ExtentReports extentreportobj;
        public static ExtentHtmlReporter htmlReporter;
        public static ExtentTest test;
        public static FileStream stream;
        

       [OneTimeSetUp]

        public void LoginFunction()
        {
           

            string userName = LoginCredentials.passWord;

            
            var htmlReporter = new ExtentHtmlReporter(@"C:\Users\roshi\OneDrive\Documents\AdvancedMarsTask\AdvancedTaskMars\MarsProjectAdvanced\MarsProjectAdvanced\ExtentReports.html");
            extentreportobj = new ExtentReports();
            extentreportobj.AttachReporter(htmlReporter);

            //Open chrome
            driver = new ChromeDriver();
            //Maximize the chrome window
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(LoginCredentials.urlLink);


            if (userName == LoginCredentials.passWord)
            {
                LoginPage loginPageObj = new LoginPage();
                loginPageObj.LoginSteps();

            }
            else
            {

                SignupPage signupPageObj = new SignupPage();
                signupPageObj.SignUp();
            }



        }

        public static void ReadDataFromEXcel()

        {
            string fileName = @"C:\Users\roshi\OneDrive\Documents\AdvancedMarsTask\AdvancedTaskMars\MarsProjectAdvanced\MarsProjectAdvanced\SkillsDetails.xlsx";
            //open file and returns as stream
            stream = File.Open(fileName, FileMode.Open, FileAccess.Read);
            ExcelReader.PopulateInCollection(stream, "SkillsProfile");



        }
        public static void Waits()
        {

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);

        }
        [OneTimeTearDown]

        public static void Close()
        {
            extentreportobj.Flush();
            driver.Quit();
        }

    }



}