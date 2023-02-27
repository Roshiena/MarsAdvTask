using MarsProjectAdvanced.Utitlities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsProjectAdvanced.Pages
{
    public class ListingsPage : CommonDriver
    {
        public IWebElement viewIcon => driver.FindElement(By.XPath("//tbody/tr[1]/td[8]/div[1]/button[1]"));
        public IWebElement editIcon => driver.FindElement(By.XPath("//tbody/tr[1]/td[8]/div[1]/button[2]"));
        public IWebElement deleteIcon => driver.FindElement(By.XPath("//tbody/tr[1]/td[8]/div[1]/button[3]"));
        public IWebElement checkTitle => driver.FindElement(By.XPath("//div[contains(text(),'Ace English Grammar')]"));
        public IWebElement editedTitle => driver.FindElement(By.XPath("//div[contains(text(),'Conversational English')]"));
        public IWebElement alertYes => driver.FindElement(By.XPath("//body/div[2]/div[1]/div[3]/button[2]"));
        public IWebElement deleteConfirm => driver.FindElement(By.XPath("/html/body/div[2]/div/div[3]/button[2]"));
        public IWebElement deletedTitle => driver.FindElement(By.XPath("//h3[contains(text(),'You do not have any service listings!')]"));




        public void NagivateToEdit()
        {
            Waits();

            editIcon.Click();


        }


        public void DeleteSkills()
        {
            Waits();

            deleteIcon.Click();
            deleteConfirm.Click();

        }

        public string CheckDeletedSkill()
        {
            return deletedTitle.Text;
        }

    }
}