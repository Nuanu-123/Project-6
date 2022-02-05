using MarsQA_1.SpecflowPages.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace MarsQA_1.StepDefinition
{
    [Binding]
    public class ChatSteps
    {
        Chat ChatObj = new Chat();
        [Given(@"I go to chat tab")]
        public void GivenIGoToChatTab()
        {
           
            ChatObj.Chats();
        }
        [Given(@"I select the person to chat")]
        public void GivenISelectThePersonToChat()
        {
            ChatObj.ChatsUser();
        }
        [When(@"I enter and the details and click on sent")]
        public void WhenIEnterAndTheDetailsAndClickOnSent()
        {
            ChatObj.ChatsSent();
        }
        [Then(@"sent message should be successfull")]
        public void ThenSentMessageShouldBeSuccessfull()
        {
            ChatObj.SuccesfullChats();
        }

    }
}
