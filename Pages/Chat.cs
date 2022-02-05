using MarsQA_1.Helpers;
using MarsQA_1.SpecflowPages.Helpers;
using OpenQA.Selenium;
using RelevantCodes.ExtentReports;
using System.Threading;
using static MarsQA_1.Helpers.CommonMethods;

namespace MarsQA_1.SpecflowPages.Pages
{
    class Chat
    {
        private static IWebElement clickChat => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/div[1]/div[2]/div/a[1]"));
        private static IWebElement EnterChatSel => Driver.driver.FindElement(By.XPath("//*[@id='chatList']/div[4]/div[2]/div[1]"));
        private static IWebElement EnterChat => Driver.driver.FindElement(By.XPath("//*[@id='chatTextBox']"));
        private static IWebElement clickSend => Driver.driver.FindElement(By.XPath("//*[@id='btnSend']"));

        #region Chat
        internal void Chats()
        {
            //Click on Chat tab
            WaitHelpers.WaitForElementVisibility(Driver.driver, "XPath", "//*[@id='account-profile-section']/div/div[1]/div[2]/div/a[1]", 50);
            clickChat.Click();
        }

      

        internal void ChatsUser()
        {
            //Select name
            WaitHelpers.WaitForElementVisibility(Driver.driver, "XPath", "//*[@id='chatList']/div[4]/div[2]/div[1]", 50);
            EnterChatSel.Click();

        }

        internal void ChatsSent()
        {
            //Populate excel data
            ExcelLibHelper.PopulateInCollection(ConstantHelpers.ExcelPath, "Chat");

            //Select chat box to enter data
            WaitHelpers.WaitForElementVisibility(Driver.driver, "XPath", "//*[@id='chatTextBox']", 50);
            EnterChat.Click();
            EnterChat.SendKeys(ExcelLibHelper.ReadData(2, "Message"));
            //EnterChat.SendKeys("Hi");
        }

        internal void SuccesfullChats()
        {
            //Start the Reports
            CommonMethods.ExtentReports();
            Thread.Sleep(1000);
            CommonMethods.test = CommonMethods.extent.StartTest("SentChat");

            //Click on Send tab
            WaitHelpers.WaitForElementVisibility(Driver.driver, "XPath", "//*[@id='btnSend']", 50);
            clickSend.Click();
            CommonMethods.test.Log(LogStatus.Info, "Chat message sent successfully");
            SaveScreenShotClass.SaveScreenshot(Driver.driver, "Chat Successfully");
        }
        #endregion
    }
}
