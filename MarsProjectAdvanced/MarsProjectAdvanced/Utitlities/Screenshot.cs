using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsProjectAdvanced.Utitlities
{
    public class ClickScreenshot : CommonDriver
    {

        public static void LoginScreenShot()
        {

            Screenshot screenShot = ((ITakesScreenshot)driver).GetScreenshot();
            screenShot.SaveAsFile(@"C:\Users\roshi\OneDrive\Documents\AdvancedMarsTask\AdvancedTaskMars\MarsProjectAdvanced\MarsProjectAdvanced\Login" + DateTime.Now.ToString("dd-MM-yyyy HH mm ss") + ".png", ScreenshotImageFormat.Png);

        }

        public static void CreateSkillScreenShot()
        {

            Screenshot screenShot = ((ITakesScreenshot)driver).GetScreenshot();
            screenShot.SaveAsFile(@"C:\Users\roshi\OneDrive\Documents\AdvancedMarsTask\AdvancedTaskMars\MarsProjectAdvanced\MarsProjectAdvanced\CreateSkills" + DateTime.Now.ToString("dd-MM-yyyy HH mm ss") + ".png", ScreenshotImageFormat.Png);

        }

        public static void EditSkillScreenShot()
        {

            Screenshot screenShot = ((ITakesScreenshot)driver).GetScreenshot();
            screenShot.SaveAsFile(@"C:\Users\roshi\OneDrive\Documents\AdvancedMarsTask\AdvancedTaskMars\MarsProjectAdvanced\MarsProjectAdvanced\EditListings" + DateTime.Now.ToString("dd-MM-yyyy HH mm ss") + ".png", ScreenshotImageFormat.Png);

        }

        public static void DeleteSkillScreenShot()
        {

            Screenshot screenShot = ((ITakesScreenshot)driver).GetScreenshot();
            screenShot.SaveAsFile(@"C:\Users\roshi\OneDrive\Documents\AdvancedMarsTask\AdvancedTaskMars\MarsProjectAdvanced\MarsProjectAdvanced\DeleteListings" + DateTime.Now.ToString("dd-MM-yyyy HH mm ss") + ".png", ScreenshotImageFormat.Png);

        }

        public static void EditDescriptionScreenShot()
        {

            Screenshot screenShot = ((ITakesScreenshot)driver).GetScreenshot();
            screenShot.SaveAsFile(@"C:\Users\roshi\OneDrive\Documents\AdvancedMarsTask\AdvancedTaskMars\MarsProjectAdvanced\MarsProjectAdvanced\EditDescription" + DateTime.Now.ToString("dd-MM-yyyy HH mm ss") + ".png", ScreenshotImageFormat.Png);

        }

        public static void AddDescriptionScreenShot()
        {

            Screenshot screenShot = ((ITakesScreenshot)driver).GetScreenshot();
            screenShot.SaveAsFile(@"C:\Users\roshi\OneDrive\Documents\AdvancedMarsTask\AdvancedTaskMars\MarsProjectAdvanced\MarsProjectAdvanced\AddDescription" + DateTime.Now.ToString("dd-MM-yyyy HH mm ss") + ".png", ScreenshotImageFormat.Png);

        }

    }
    
}