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
    public class ManageListingsStepDefinition : CommonDriver
    {
        ProfilePage profilePageObj;
        ListingsPage listingsPageObj;
        ShareSkillsPage shareSkillsPageObj;

        public ManageListingsStepDefinition()
        {
            profilePageObj = new ProfilePage();
            listingsPageObj = new ListingsPage();
            shareSkillsPageObj = new ShareSkillsPage();
        }

        [Given(@"I have navigated to Manage Listings Page")]
        public void GivenIHaveNavigatedToManageListingsPage()
        {
            profilePageObj.NavigateManageListings();
        }

        [When(@"I edit Manage Listings")]
        public void WhenIEditManageListings()
        {
            listingsPageObj.NagivateToEdit();
            shareSkillsPageObj.EditSkills();
        }

        [Then(@"Then Manage Listings should be edited")]
        public void ThenThenManageListingsShouldBeEdited()
        {
            try
            {
                test = extentreportobj.CreateTest("EditSkills", "Testing Edit Skills");
                string editedTitle = shareSkillsPageObj.CheckEditedSkills();
                Assert.That(editedTitle == "Conversational English", "Expected Title and Edited Title do not match");
                ClickScreenshot.EditSkillScreenShot();
                test.Log(Status.Info, "Skills edited successfully");
                test.Log(Status.Pass, "Test passed");
            }
            catch (Exception ex)
            {
                ClickScreenshot.EditSkillScreenShot();
                test.Log(Status.Fail, "Test passed");
                throw;

            }
        }

        [When(@"I delete Manage Listings")]
        public void WhenIDeleteManageListings()
        {
            listingsPageObj.DeleteSkills();
        }

        [Then(@"The Manage Listings should be deleted")]
        public void ThenTheManageListingsShouldBeDeleted()
        {
            try
            {
                test = extentreportobj.CreateTest("DeleteSkills", "Testing Delete Skills");
                string deletedTitle = listingsPageObj.CheckDeletedSkill();
                Assert.That(deletedTitle == "You do not have any service listings!", "Record is not deleted");
                ClickScreenshot.DeleteSkillScreenShot();
                test.Log(Status.Info, "Skills deleted successfully");
                test.Log(Status.Pass, "Test passed");
            }
            catch (Exception ex)

            {
                ClickScreenshot.DeleteSkillScreenShot();
                test.Log(Status.Fail, "Test failed");

                throw;
            }
        }
    }
}