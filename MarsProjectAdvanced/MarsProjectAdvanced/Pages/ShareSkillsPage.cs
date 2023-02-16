using MarsProjectAdvanced.Utitlities;
using MarsProjectAdvanced.Input;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExcelDataReader;



namespace MarsProjectAdvanced.Pages
{
    public class ShareSkillsPage : CommonDriver
    {

        public IWebElement titleTextBox => driver.FindElement(By.XPath("//body/div[1]/div[1]/div[1]/div[2]/div[1]/form[1]/div[1]/div[1]/div[2]/div[1]/div[1]/input[1]"));
        public IWebElement descriptionTextbox => driver.FindElement(By.Name("description"));
        public IWebElement categoryDropdown => driver.FindElement(By.Name("categoryId"));
        public IWebElement subCategory => driver.FindElement(By.Name("subcategoryId"));
        public IWebElement tagName => driver.FindElement(By.XPath("//body/div[1]/div[1]/div[1]/div[2]/div[1]/form[1]/div[4]/div[2]/div[1]/div[1]/div[1]/div[1]/input[1]"));

        //Select the Service type - hourly service 

        public IWebElement hourlyServiceType => driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[5]/div[2]/div[1]/div[1]/div/input"));

        //Select One Off Service Type
        private IWebElement oneOffServiceType => driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[5]/div[2]/div[1]/div[2]/div/input"));


        //Select On-Site Location Type
        public IWebElement onSiteLocation => driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[6]/div[2]/div/div[1]/div/input"));


        //Select Online Location Type
        public IWebElement onlineLocation => driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[6]/div[2]/div/div[2]/div/input"));

        public IWebElement startDate => driver.FindElement(By.Name("startDate"));
        public IWebElement endDate => driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[7]/div[2]/div/div[1]/div[4]/input"));
        public IWebElement daysAvail => driver.FindElement(By.XPath("//body/div[1]/div[1]/div[1]/div[2]/div[1]/form[1]/div[7]/div[2]/div[1]/div[2]/div[1]"));
        public IWebElement selectWednesday => driver.FindElement(By.XPath("//body/div[1]/div[1]/div[1]/div[2]/div[1]/form[1]/div[7]/div[2]/div[1]/div[5]/div[1]/div[1]/input[1]"));
        public IWebElement startTime => driver.FindElement(By.XPath("//body/div[1]/div[1]/div[1]/div[2]/div[1]/form[1]/div[7]/div[2]/div[1]/div[5]/div[2]/input[1]"));
        public IWebElement endTime => driver.FindElement(By.XPath("//body/div[1]/div[1]/div[1]/div[2]/div[1]/form[1]/div[7]/div[2]/div[1]/div[5]/div[3]/input[1]"));
        public IWebElement skillsExchange => driver.FindElement(By.XPath("//body/div[1]/div[1]/div[1]/div[2]/div[1]/form[1]/div[8]/div[2]/div[1]/div[1]/div[1]"));
        public IWebElement selectCredit => driver.FindElement(By.XPath("//body/div[1]/div[1]/div[1]/div[2]/div[1]/form[1]/div[8]/div[2]/div[1]/div[2]/div[1]/input[1]"));
        public IWebElement creditAmount => driver.FindElement(By.XPath("//body/div[1]/div[1]/div[1]/div[2]/div[1]/form[1]/div[8]/div[4]/div[1]/div[1]/input[1]"));
        public IWebElement skillExchange => driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[8]/div[4]/div/div/div/div/div/input"));
        public IWebElement workSample => driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[2]/div/form/div[9]/div/div[2]/section/div/label/div/span/i"));
        public IWebElement selectActive => driver.FindElement(By.XPath("//body/div[1]/div[1]/div[1]/div[2]/div[1]/form[1]/div[10]/div[2]/div[1]/div[1]/div[1]/input[1]"));
        public IWebElement selectHidden => driver.FindElement(By.XPath("//body/div[1]/div[1]/div[1]/div[2]/div[1]/form[1]/div[1"));
        public IWebElement saveButton => driver.FindElement(By.XPath("//input[@value='Save']"));
        public IWebElement viewCreatedSkills => driver.FindElement(By.XPath("//i[@class='eye icon']"));
        public IWebElement checkCreatedTitle => driver.FindElement(By.XPath("//span[contains(text(),'Ace English Grammar')]"));
        public IWebElement viewEditedSkills => driver.FindElement(By.XPath("//tbody/tr[1]/td[8]/div[1]/button[1]/i[1]"));
        public IWebElement checkEditedTitle => driver.FindElement(By.XPath("//span[contains(text(),'Conversational English')]"));

        

        public void createSelectElementAndSelectByText(IWebElement webElement, int rowNumber, String name)
        {
           
            webElement.Click();
            SelectElement selectCategory = new SelectElement(webElement);
            selectCategory.SelectByText(ExcelReader.ReadData(rowNumber, name));
        }

        public void StartDate(IWebElement webElement, int rowNumber, String name)
        {
            
            string startDateOn = ExcelReader.ReadData(rowNumber, name);
            startDate.SendKeys(startDateOn);

            webElement.Click();
        }
        public void TimingsOn(IWebElement webElement, int rowNumber, String name)
        {
            
            string startTimeOn = ExcelReader.ReadData(rowNumber, name);
            webElement.SendKeys(startTimeOn);

            string endTimeOn = ExcelReader.ReadData(rowNumber, name);
            webElement.SendKeys(endTimeOn);

        }

        public void ServiceType(IWebElement webElement, int rowNumber, string name)
        {
            
            string serviceType = ExcelReader.ReadData(rowNumber, name);
            if (serviceType.Equals("Hourly basis service"))
            {
                webElement.Click();
            }
            else if (serviceType.Equals("One-off service"))
            {
                webElement.Click();
            }
        }

        public void LocationType(IWebElement webElement, int rowNumber, string name)
        {
            
            string locationType = ((ExcelReader.ReadData(rowNumber, name)));
            if (locationType.Equals("On-site"))
            {
                webElement.Click();
            }
            else if (locationType.Equals("Online"))
            {
                webElement.Click();
            }
        }

        public void WorkSample()
        {
            workSample.Click();


            using (Process exeProcess = Process.Start(@"C:\Users\roshi\OneDrive\Documents\Worksamplee.exe"))
            {

                exeProcess.WaitForExit();
            }

        }

        public void SkillsExchange(IWebElement webElement, int rowNumber, string name)
        {
            
            webElement.Click();
            string skillExchangeTag = ExcelReader.ReadData(rowNumber, name);

            webElement.SendKeys(skillExchangeTag);
            webElement.SendKeys(Keys.Enter);
        }

        public void CreateSkills()
        {
            Waits();

            ReadDataFromEXcel();
            string title = ExcelReader.ReadData(1, "Title");
            titleTextBox.SendKeys(title);


            //Identify the description text box and add the description
            descriptionTextbox.Click();
            string description = ExcelReader.ReadData(1, "Description");
            descriptionTextbox.SendKeys(description);

            createSelectElementAndSelectByText(categoryDropdown, 1, "Category");
            createSelectElementAndSelectByText(subCategory, 1, "SubCategory");


            string tag = ExcelReader.ReadData(1, "Tags");
            tagName.SendKeys(tag);
            tagName.SendKeys(Keys.Enter);

            ServiceType(oneOffServiceType, 1, "ServiceType");
            LocationType(onlineLocation, 1, "LocationType");
            StartDate(selectWednesday, 1, "Start Date");
            TimingsOn(startTime, 1, "Start Time");
            TimingsOn(endTime, 1, "End Time");
            SkillsExchange(skillExchange, 1, "SkillsExchange");

            WorkSample();
            selectActive.Click();
            Waits();
            saveButton.Click();
            stream.Dispose();

        }


        public string CheckCreatedSkill()

        {

            viewCreatedSkills.Click();
            return checkCreatedTitle.Text;
        }


        public void DateLoop()
        {
            
            startDate.SendKeys(Input.ExcelReader.ReadData(2, "Start Date"));
            startDate.Click();
            endDate.SendKeys(Input.ExcelReader.ReadData(2, "End Date"));
            endDate.Click();

            for (int i = 2; i < 9; i++)
            {


                for (int j = 2; j < 9; j++)
                {
                    IWebElement startTime = driver.FindElement(By.XPath("//div[" + i + "]/div[2]/input"));

                    IWebElement endTime = driver.FindElement(By.XPath("//div[" + j + "]/div[3]/input"));

                    if (i == 2 && j == 2)
                    {
                        driver.FindElement(By.XPath("//div[contains(@class,'twelve wide column')]//div[2]//div[1]//div[1]//input[1]")).Click();
                        startTime.SendKeys("0230PM");
                        startTime.SendKeys(Keys.Tab);
                        endTime.SendKeys("0630PM");
                    }
                    if (i == 3 && j == 3)
                    {
                        driver.FindElement(By.XPath("//div[3]//div[1]//div[1]//input[1]")).Click();
                        startTime.SendKeys("0930AM");
                        endTime.SendKeys("0630PM");
                    }

                }
            }
        }


        public void EditSkills()
        {
            Waits();

            ReadDataFromEXcel();
            titleTextBox.Clear();

            string editedTitle1 = ExcelReader.ReadData(2, "Title");
            titleTextBox.SendKeys(editedTitle1);

            descriptionTextbox.Clear();
            string editedDescription1 = ExcelReader.ReadData(2, "Description");
            descriptionTextbox.SendKeys(editedDescription1);

            string editedTag2 = ExcelReader.ReadData(1, "Tags");
            tagName.SendKeys(editedTag2);
            tagName.SendKeys(Keys.Enter);

            DateLoop();
            selectCredit.Click();
            string creditAmt = ExcelReader.ReadData(2, "Credit Amount");
            creditAmount.SendKeys(creditAmt);

            saveButton.Click();


        }

        public string CheckEditedSkills()
        {
            viewEditedSkills.Click();
            return checkEditedTitle.Text;
        }

    }
}
