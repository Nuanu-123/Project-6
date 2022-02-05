using MarsQA_1.SpecflowPages.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace MarsQA_1.StepDefinition
{
    [Binding]
    public class ManageRequestSteps
    {
        ManageRequest manageRequest = new ManageRequest();
        //Received request
        [Given(@"I go to Manage Request tab")]
        public void GivenIGoToManageRequestTab()
        {
           
            manageRequest.ManageRequests();
        }
        [When(@"I click on Received Request")]
        public void WhenIClickOnReceivedRequest()
        {
    
            manageRequest.ReceviedRequests();
        }
        [Then(@"I am able to accept or decline request")]
        public void ThenIAmAbleToAcceptOrDeclineRequest()
        {
          
            manageRequest.ResponseRequests();
        }

        //Sent Request
        [Given(@"I navigate to Manage Request tab")]
        public void GivenINavigateToManageRequestTab()
        {
        
            manageRequest.MangRequests();
        }
        [When(@"I click on Sent Request")]
        public void WhenIClickOnSentRequest()
        {
          
            manageRequest.SentRequests();
        }
        [Then(@"I am able to sent request")]
        public void ThenIAmAbleToSentRequest()
        {
          
            manageRequest.SentARequest();
        }
                                                                                                                                                                                                                                    
    }
}
