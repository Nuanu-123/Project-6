using MarsQA_1.SpecflowPages.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace MarsQA_1.StepDefinition
{
    [Binding]
    public class NotificationSteps
    {
        Notification notifiObj = new Notification();
        [Given(@"I go to notification tab")]
        public void GivenIGoToNotificationTab()
        {
            
            notifiObj.Notifications();
        }
        [Given(@"I click on see all button")]
        public void GivenIClickOnSeeAllButton()
        {
          
            notifiObj.NotificationSellAll();
        }

        [Given(@"I click on select all button")]
        public void GivenIClickOnSelectAllButton()
        {
           
            notifiObj.NotificationSelectAll();
        }
        [Given(@"I click on unselect all button")]
        public void GivenIClickOnUnselectAllButton()
        {
           
            notifiObj.NotificationUnSelectAll();
        }
        [Given(@"I select one notification")]
        public void GivenISelectOneNotification()
        {
           
           notifiObj.NotificationSelect();
        }

        [When(@"I mark one selection as read")]
        public void WhenIMarkOneSelectionAsRead()
        {
           
           notifiObj.NotificationMark();
        }

       
        [Then(@"I should be able to delete notification successfully")]
        public void ThenIShouldBeAbleToDeleteNotificationSuccessfully()
        {
          
           notifiObj.NotificationDelete();
        }

    }
}
