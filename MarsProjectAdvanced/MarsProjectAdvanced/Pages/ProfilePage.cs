using MarsProjectAdvanced.Utitlities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsProjectAdvanced.Pages
{
    public class ProfilePage : CommonDriver
    {
        public IWebElement shareSkillsButton => driver.FindElement(By.XPath("//a[contains(text(),'Share Skill')]"));
        public IWebElement manageListings => driver.FindElement(By.XPath("//a[contains(text(),'Manage Listings')]"));


        public void NavigateShareSkills()
        {

            shareSkillsButton.Click();
        }

        public void NavigateManageListings()
        {

            manageListings.Click();
        }




    }
}