using MarsQA_1.Helpers;
using MarsQA_1.SpecflowPages.Helpers;
using OpenQA.Selenium;
using RelevantCodes.ExtentReports;
using System.Threading;
using static MarsQA_1.Helpers.CommonMethods;

namespace MarsQA_1.SpecflowPages.Pages
{
    class Notification
    {
            private static IWebElement ClickNotification => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/div[1]/div[2]/div/div"));
            private static IWebElement ClickSeeAll => Driver.driver.FindElement(By.LinkText("See All..."));
            private static IWebElement SelectAll => Driver.driver.FindElement(By.XPath("//div[@data-tooltip='Select all']"));
            private static IWebElement UnSelectAll => Driver.driver.FindElement(By.XPath("//*[@id='notification-section']/div[2]/div/div/div[3]/div[1]/div[2]"));
            private static IWebElement SelectOne => Driver.driver.FindElement(By.XPath("//*[@id='notification-section']/div[2]/div/div/div[3]/div[2]/span/span/div/div[1]/div/div/div[3]/input"));
            private static IWebElement MarkSelection => Driver.driver.FindElement(By.XPath("//*[@id='notification-section']/div[2]/div/div/div[3]/div[1]/div[4]"));
            private static IWebElement Delete => Driver.driver.FindElement(By.XPath("//*[@id='notification-section']/div[2]/div/div/div[3]/div[1]/div[3]/i"));

        #region notification
        internal void Notifications()
        {
            //Click on Notification tab
           WaitHelpers.WaitForElementVisibility(Driver.driver, "XPath", "//*[@id='account-profile-section']/div/div[1]/div[2]/div/div", 50);
            ClickNotification.Click();
        }

        internal void NotificationSellAll()
        {
            //Click on See all
            WaitHelpers.WaitForElementVisibility(Driver.driver, "LinkText", "See All...", 50);
            ClickSeeAll.Click();
        }

        internal void NotificationSelectAll()
        {
            //Start the Reports
            CommonMethods.ExtentReports();
            Thread.Sleep(2000);
            CommonMethods.test = CommonMethods.extent.StartTest("Notification Select All");
            //Click on select all
            // Wait 
            Thread.Sleep(3000);
            // WaitHelpers.WaitForElementClickable(Driver.driver, "XPath", "//*[@id='notification-section']//" +
            //  "div[last()-1]/div/div/div[3]/input", 1000);
            // GlobalDefinitions.WaitForElementVisibility(GlobalDefinitions.driver, "XPath", "//div[@data-tooltip='Select all']", 50);
            SelectAll.Click();
            Thread.Sleep(1000);
            CommonMethods.test.Log(LogStatus.Info, "Successfully selected all notifications");
            SaveScreenShotClass.SaveScreenshot(Driver.driver, "SelectAllNotification");
        }

        internal void NotificationUnSelectAll()
        {
            //Start the Reports
            CommonMethods.ExtentReports();
            Thread.Sleep(1000);
            CommonMethods.test = CommonMethods.extent.StartTest("UnSelect All");
            //UnSelect All
           WaitHelpers.WaitForElementVisibility(Driver.driver, "XPath", "//*[@id='notification-section']/div[2]/div/div/div[3]/div[1]/div[2]", 50);
            UnSelectAll.Click();
            CommonMethods.test.Log(LogStatus.Info, "Successfully Unselected all notifications");
            SaveScreenShotClass.SaveScreenshot(Driver.driver, "UnSelectAllNotification");
        }

        
        internal void NotificationSelect()
        {
            Thread.Sleep(2000);
            //Select one
            WaitHelpers.WaitForElementVisibility(Driver.driver, "XPath", "//*[@id='notification-section']/div[2]/div/div/div[3]/div[2]/span/span/div/div[1]/div/div/div[3]/input", 50);
            SelectOne.Click();
        }


        internal void NotificationMark()
        {
            Thread.Sleep(2000);
            //Mark Selction as read
            WaitHelpers.WaitForElementVisibility(Driver.driver, "XPath", "//*[@id='notification-section']/div[2]/div/div/div[3]/div[1]/div[4]", 50);
            MarkSelection.Click();
        }

        internal void NotificationDelete()
        {
            SelectOne.Click();
            //Start the Reports
            CommonMethods.ExtentReports();
            Thread.Sleep(2000);
            CommonMethods.test = CommonMethods.extent.StartTest("Delete Notification");
            //Delete Notification
          //  WaitHelpers.WaitForElementVisibility(Driver.driver, "XPath", "//*[@id='notification-section']/div[2]/div/div/div[3]/div[1]/div[3]/i", 50);
            Delete.Click();
            Thread.Sleep(2000);
            CommonMethods.test.Log(LogStatus.Info, "Delete notification successfull");
            SaveScreenShotClass.SaveScreenshot(Driver.driver, "NotificationDelete");
        }
        #endregion
    }
}
