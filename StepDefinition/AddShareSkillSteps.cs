using MarsQA_1.SpecflowPages.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace MarsQA_1.StepDefinition
{
    [Binding]
    public class AddShareSkillSteps
    {
        ShareSkill shareSkillObj = new ShareSkill();
        [Given(@"I open Share Skill page")]
        public void GivenIOpenShareSkillPage()
        {
            //Add Share Skill
           shareSkillObj.GotoShareSkill();
            
        }
        [When(@"I list my Selenium skill for trade")]
        public void WhenIListMySeleniumSkillForTrade()
        {
            //Add Share Skill
            shareSkillObj.AddShareSkill();
           
        }
        [Then(@"Selenium is found in my managed listings")]
        public void ThenSeleniumIsFoundInMyManagedListings()
        {
            //Verify Share Skill
             shareSkillObj.VerifySkill();

        }


    }
}
