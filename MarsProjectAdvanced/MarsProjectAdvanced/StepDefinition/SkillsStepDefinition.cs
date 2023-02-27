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
    public class SkillsStepDefinition : CommonDriver
    {
        SkillsPage skillsPageObj;

        public SkillsStepDefinition()
        {
            skillsPageObj = new SkillsPage();
        }


        [When(@"I add '([^']*)' and '([^']*)' to profile")]
        public void WhenIAddAndToProfile(string skills, string level)
        {
           
            skillsPageObj.AddSkills(skills, level);
        }

        [Then(@"The '([^']*)' and '([^']*)' should be added to the profile successfully")]
        public void ThenTheAndShouldBeAddedToTheProfileSuccessfully(string skills, string level)
        {
            string newSkill = skillsPageObj.GetSkills();
            string skillLevel = skillsPageObj.GetLevel();

            Assert.That(newSkill == skills, "Actual skills and expected skills do not match");
            Assert.That(skillLevel == level, "Acutal level and expected level do not match");

        }

        [When(@"I edit '([^']*)' and '([^']*)' to profile")]
        public void WhenIEditAndToProfile(string skills, string level)
        {
            skillsPageObj.EditSkills(skills, level);
        }

        [Then(@"The '([^']*)' and '([^']*)' should be edited to the profile successfully")]
        public void ThenTheAndShouldBeEditedToTheProfileSuccessfully(string skills, string level)

        {
            string updatedSkills = skillsPageObj.EditedSkills();
            string updatedLevel = skillsPageObj.EditedLevel();


            Assert.That(updatedSkills == skills, "Actual skills and expected skills do not match");
            Assert.That(updatedLevel == level, "Acutal level and expected level do not match");

        }

        [When(@"I delete '([^']*)' and '([^']*)' from profile")]
        public void WhenIDeleteAndFromProfile(string skills, string level)
        {
            skillsPageObj.DeleteSkills();
        }

        [Then(@"The '([^']*)' and '([^']*)' should be deleted from the profile successfully")]
        public void ThenTheAndShouldBeDeletedFromTheProfileSuccessfully(string skills, string level)
        {
            {
                string deletedSkills = skillsPageObj.DeletedSkills();
                string deletedLevel = skillsPageObj.DeletedLevel();
                Assert.That(deletedSkills != skills, "Actual skills and expected skills do not match");
                Assert.That(deletedLevel != level, "Actual level and expected levels do not match");
               
            }
        }

    }



}


