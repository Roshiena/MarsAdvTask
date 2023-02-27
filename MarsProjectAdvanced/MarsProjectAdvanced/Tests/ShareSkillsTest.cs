using AventStack.ExtentReports;
using MarsProjectAdvanced.Pages;
using MarsProjectAdvanced.Utitlities;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsProjectAdvanced.Tests
{
    [TestFixture]
    public class ShareSkillsTest : CommonDriver
    {

        ProfilePage profilePageObj;
        ShareSkillsPage shareSkillsPageObj;
        ListingsPage listingsPageObj;

        public ShareSkillsTest()
        {
            profilePageObj = new ProfilePage();
            shareSkillsPageObj = new ShareSkillsPage();
            listingsPageObj = new ListingsPage();

        }


        [Test, Order(1)]
        public void AddShareSkillTest()
        {
            try
            {
                test = extentreportobj.CreateTest("CreateSkills", "Testing Create Skills");
                profilePageObj.NavigateShareSkills();
                shareSkillsPageObj.CreateSkills();
                ClickScreenshot.CreateSkillScreenShot();
                string createdTitle = shareSkillsPageObj.CheckCreatedSkill();
                Assert.That(createdTitle == "Ace English Grammar", "Expected Title and Edited Title do not match");
                test.Log(Status.Info, "Skills created successfully");
                test.Log(Status.Pass, "Test passed");
            }
            catch (Exception ex)
            {
                ClickScreenshot.CreateSkillScreenShot();
                test.Log(Status.Fail, "Test failed");
                throw;

            }

        }



        [Test, Order(2)]

        public void EditListingsTest()
        {
            try
            {
                test = extentreportobj.CreateTest("EditSkills", "Testing Edit Skills");
                profilePageObj.NavigateManageListings();
                listingsPageObj.NagivateToEdit();
                shareSkillsPageObj.EditSkills();
                ClickScreenshot.EditSkillScreenShot();
                string editedTitle = shareSkillsPageObj.CheckEditedSkills();
                Assert.That(editedTitle == "Conversational English", "Expected Title and Edited Title do not match");
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



        [Test, Order(3)]
        public void DeleteListingsTest()
        {
            try
            {
                test = extentreportobj.CreateTest("DeleteSkills", "Testing Delete Skills");
                profilePageObj.NavigateManageListings();
                listingsPageObj.DeleteSkills();
                ClickScreenshot.DeleteSkillScreenShot();
                string deletedTitle = listingsPageObj.CheckDeletedSkill();
                Assert.That(deletedTitle == "You do not have any service listings!", "Record is not deleted");
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


