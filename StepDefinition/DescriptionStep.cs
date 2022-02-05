using MarsQA_1.SpecflowPages.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace MarsQA_1.StepDefinition
{
    [Binding]
    public sealed class DescriptionStep
    {
        Description descriobj = new Description();
        //Add description
        [Given(@"User try to add Description")]
        public void GivenUserTryToAddDescription()
        {
            //Add description
            
            descriobj.EnterDescription();
           
        }
        [Then(@"User should able to add Description successfully")]
        public void ThenUserShouldAbleToAddDescriptionSuccessfully()
        {
            //verify description
            descriobj.VerifyDescription();
        }


        //Edit description
        [Given(@"User try to edit Description")]
        public void GivenUserTryToEditDescription()
        {
            //Edit description
            descriobj.EditDescription();
           
        }
        [Then(@"User should able to edit Description successfully")]
        public void ThenUserShouldAbleToEditDescriptionSuccessfully()
        {
            //Verify edited description
            descriobj.VerifyEditedDescription();
        }

    }
}
