using AventStack.ExtentReports;
using MarsProjectAdvanced.Pages;
using MarsProjectAdvanced.Utitlities;
using NUnit.Framework;


namespace MarsProjectAdvanced.Tests
{
    [TestFixture]
    public class DescriptionTest : CommonDriver

    {
        DescriptionPage descriptionPageObj;

        public DescriptionTest()
        {
            descriptionPageObj = new DescriptionPage();
        }

        [Test, Order(4)]

        public void AddDescriptionTest()
        {
            try
            {
                test = extentreportobj.CreateTest("AddDescription", "Testing Add Description");
                descriptionPageObj.AddDescription();
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

        [Test, Order(2)]

        public void EditDescriptionTest()
        {
            try
            {
                test = extentreportobj.CreateTest("EditDescription", "Testing Edit Description");
                descriptionPageObj.EditDescription();
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
