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
    public class ShareSkillStepDefinition : CommonDriver
    {
        ProfilePage profilePageObj;
        ShareSkillsPage shareSkillsPageObj;

        public ShareSkillStepDefinition()
        {
            profilePageObj = new ProfilePage();
            shareSkillsPageObj = new ShareSkillsPage();
        }

        [Given(@"I have nagivated to Share Skills Page")]
        public void GivenIHaveNagivatedToShareSkillsPage()
        {
            profilePageObj.NavigateShareSkills();
        }

        [When(@"I add Share Skills")]
        public void WhenIAddShareSkills()
        {
            shareSkillsPageObj.CreateSkills();
        }

        [Then(@"The Share Skills should be added")]
        public void ThenTheShareSkillsShouldBeAdded()
        {
            try
            {
                test = extentreportobj.CreateTest("CreateSkills", "Testing Create Skills");
                string createdTitle = shareSkillsPageObj.CheckCreatedSkill();
                Assert.That(createdTitle == "Ace English Grammar", "Expected Title and Edited Title do not match");
                ClickScreenshot.CreateSkillScreenShot();
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

    }
}