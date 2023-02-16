using MarsProjectAdvanced.Input;
using MarsProjectAdvanced.Utitlities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium.DevTools.V107.Storage;
using ExcelDataReader;

namespace MarsProjectAdvanced.Pages
{
    public class DescriptionPage : CommonDriver
    {
        public IWebElement descriptionIcon => driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/div[1]/div[1]/div[1]/h3[1]/span[1]/i[1]"));
        public IWebElement descriptionTextbox => driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/div[1]/div[1]/form[1]/div[1]/div[1]/div[2]/div[1]/textarea[1]"));
        public IWebElement descriptionSave => driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/div[1]/div[1]/form[1]/div[1]/div[1]/div[2]/button[1]"));
        public IWebElement addedDescription => driver.FindElement(By.XPath("//span[contains(text(),'I love travelling and exploring new cultures')]"));
        public IWebElement editedDescription => driver.FindElement(By.XPath("//span[contains(text(),'I love cooking and watching documentaries')]"));
        public IWebElement profileTab => driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[1]/div[1]/a[2]"));


        public static void ReadDataFromEXcel1()

        {
            string fileName = @"C:\Users\roshi\OneDrive\Documents\Description.xlsx";
            //open file and returns as stream
            stream = File.Open(fileName, FileMode.Open, FileAccess.Read);
            ExcelReader.PopulateInCollection(stream, "Description");
        }

        public void AddDescription()
        {
            Waits();
            ReadDataFromEXcel1();
            descriptionIcon.Click();
            Thread.Sleep(2000);
            descriptionTextbox.Clear();
            string descTextbox = ExcelReader.ReadData(1, "Description1");
            descriptionTextbox.SendKeys(descTextbox);
            descriptionSave.Click();
            stream.Dispose();




        }
        public string GetDescription()
        {
            profileTab.Click();
            return addedDescription.Text;
        }

        public void EditDescription()
        {
           
            
            WaitHelpers.WaitToBeClickable(driver, "XPath", "//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/div[1]/div[1]/div[1]/h3[1]/span[1]/i[1]", 30);
            ReadDataFromEXcel1();
            descriptionIcon.Click();
            Thread.Sleep(1000);
            descriptionTextbox.Clear();
            string editeddescTextbox = ExcelReader.ReadData(1, "Description2");
            descriptionTextbox.SendKeys(editeddescTextbox);
            descriptionSave.Click();
        }

        public string EditedDescription()
        {
            // profileTab.Click();
            WaitHelpers.WaitToBeVisible(driver, "XPath", "//span[contains(text(),'I love cooking and watching documentaries')]", 30);
            return editedDescription.Text;
        }

    }
}