using AventStack.ExtentReports;
using MarsProjectAdvanced.Utitlities;
using MarsProjectAdvanced.Pages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace MarsProjectAdvanced.StepDefinition
{
    [Binding]
    public class DescriptionStepDefinition : CommonDriver
    {
        DescriptionPage descriptionPageObj;

        public DescriptionStepDefinition()
        {
            
            descriptionPageObj = new DescriptionPage();
        }

        [When(@"I add Description to profile")]
        public void WhenIAddDescriptionToProfile()
        {
            descriptionPageObj.AddDescription();
        }

        [Then(@"The Description should be added to the profile successfully")]
        public void ThenTheDescriptionShouldBeAddedToTheProfileSuccessfully()
        {
            try
            {
                test = extentreportobj.CreateTest("AddDescription", "Testing Add Description");
               
                string getNewDesp = descriptionPageObj.GetDescription();
                Assert.That(getNewDesp == "I love travelling and exploring new cultures", "Actual skills and expected skills do not match");
                ClickScreenshot.AddDescriptionScreenShot();
                test.Log(Status.Info, "Description added successfully");
                test.Log(Status.Pass, "Test passed");

            }
            catch (Exception ex)
            {
                ClickScreenshot.AddDescriptionScreenShot();
                test.Log(Status.Fail, "Test failed");

                throw;
            }
        }

        [When(@"I edit Description in profile")]
        public void WhenIEditDescriptionInProfile()
        {
           
            descriptionPageObj.EditDescription();
        }

        [Then(@"The Description should be edited in the profile successfully")]
        public void ThenTheDescriptionShouldBeEditedInTheProfileSuccessfully()
        {
            try
            {
                test = extentreportobj.CreateTest("EditDescription", "Testing Edit Description");
                
                string getEditedDesp = descriptionPageObj.EditedDescription();
                Assert.That(getEditedDesp == "I love cooking and watching documentaries", "Actual skills and expected skills do not match");
                ClickScreenshot.EditDescriptionScreenShot();
                test.Log(Status.Info, "Description edited successfully");
                test.Log(Status.Pass, "Test passed");

            }
            catch (Exception ex)
            {
                ClickScreenshot.EditDescriptionScreenShot();
                test.Log(Status.Fail, "Test failed");

                throw;
            }

        }




    }
}