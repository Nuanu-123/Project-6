using MarsQA_1.SpecflowPages.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace MarsQA_1.StepDefinition
{
    [Binding]
    public class SkillSteps
    {
        Skill skillobj = new Skill();
        //Add Skill
        [Given(@"User try to add new Skill on profile page")]
        public void GivenUserTryToAddNewSkillOnProfilePage()
        {
            //Add Skill
            
            skillobj.EnterSkill();
            
        }
        [When(@"User click on Add Skill button")]
        public void WhenUserClickOnAddSkillButton()
        {
            //Add Skill
            skillobj.AddSkills();
           
        }
        [Then(@"User should able to add new skill successfully")]
        public void ThenUserShouldAbleToAddNewSkillSuccessfully()
        {
            //Verify added Skill
            skillobj.VerifySkill();
        }

        //Edit skill
        [Given(@"User try to edit the Skill record")]
        public void GivenUserTryToEditTheSkillRecord()
        {
            //Edit Skill
            skillobj.EditSkills();
            

        }
        [When(@"User click on update skill button")]
        public void WhenUserClickOnUpdateSkillButton()
        {
            //Edit Skill
            skillobj.UpodateSkills();
           
        }
        [Then(@"User should able to edit skill successfully")]
        public void ThenUserShouldAbleToEditSkillSuccessfully()
        {
            //Verify Edited Skill
            skillobj.VerifyEditedSkill();
        }


        //Delete Skill
        [Given(@"User should able to Delete Skill sucessfully")]
        public void GivenUserShouldAbleToDeleteSkillSucessfully()
        {
            //Delete Skill
            skillobj.DeleteSkill();

        }

    }
}
