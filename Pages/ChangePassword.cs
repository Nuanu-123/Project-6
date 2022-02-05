using MarsQA_1.Helpers;
using MarsQA_1.SpecflowPages.Helpers;
using OpenQA.Selenium;
using RelevantCodes.ExtentReports;
using System.Threading;
using static MarsQA_1.Helpers.CommonMethods;

namespace MarsQA_1.SpecflowPages.Pages
{
    class ChangePassword
    {
        private static IWebElement NameBtn => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/div[1]/div[2]/div/span"));
        private static IWebElement ChgPwdBtn => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/div[1]/div[2]/div/span/div/a[2]"));
        private static IWebElement CurrentPwd => Driver.driver.FindElement(By.XPath("/html/body/div[4]/div/div[2]/form/div[1]/input"));
        private static IWebElement NewPwd => Driver.driver.FindElement(By.XPath("/html/body/div[4]/div/div[2]/form/div[2]/input"));
        private static IWebElement ConfirmNewPwd => Driver.driver.FindElement(By.XPath("/html/body/div[4]/div/div[2]/form/div[3]/input"));
        private static IWebElement SaveBtn => Driver.driver.FindElement(By.XPath("/html/body/div[4]/div/div[2]/form/div[4]/button"));
        private static IWebElement SignOut => Driver.driver.FindElement(By.XPath("//*[@class='ui green basic button']"));
        private static IWebElement SignIn => Driver.driver.FindElement(By.XPath("//*[@class='item']"));
        private static IWebElement EmailSignIn => Driver.driver.FindElement(By.XPath("//*[@placeholder='Email address']"));
        private static IWebElement PassSignIn => Driver.driver.FindElement(By.XPath("//*[@name='password']"));
        private static IWebElement LogIn => Driver.driver.FindElement(By.XPath("//*[@class='fluid ui teal button']"));
        #region change password
        internal void changePassword()
        {
            //Populate excel data
            ExcelLibHelper.PopulateInCollection(ConstantHelpers.ExcelPath, "SignIn");
            //Click on Name
            WaitHelpers.WaitForElementVisibility(Driver.driver, "XPath", "//*[@id='account-profile-section']/div/div[1]/div[2]/div/span", 50);
            NameBtn.Click();

            //Click on change password
            WaitHelpers.WaitForElementVisibility(Driver.driver, "XPath", "//*[@id='account-profile-section']/div/div[1]/div[2]/div/span/div/a[2]", 50);
            ChgPwdBtn.Click();

            //Enter old password
            CurrentPwd.SendKeys(ExcelLibHelper.ReadData(2, "Password"));


            //Enter new password
            NewPwd.SendKeys(ExcelLibHelper.ReadData(2, "NewPassword"));

            //Confirm new password
            ConfirmNewPwd.SendKeys(ExcelLibHelper.ReadData(2, "NewPassword"));
            Thread.Sleep(1000);
            SaveBtn.Click();
            Thread.Sleep(1000);
            SignOut.Click();
            Thread.Sleep(2000);
            SignIn.Click();
            Thread.Sleep(2000);
            EmailSignIn.SendKeys(ExcelLibHelper.ReadData(2, "Username"));
            PassSignIn.SendKeys(ExcelLibHelper.ReadData(2, "NewPassword"));
            LogIn.Click();
            Thread.Sleep(3000);
            NameBtn.Click();
            ChgPwdBtn.Click();
            CurrentPwd.SendKeys(ExcelLibHelper.ReadData(2, "NewPassword"));
            NewPwd.SendKeys(ExcelLibHelper.ReadData(2, "Password"));
            ConfirmNewPwd.SendKeys(ExcelLibHelper.ReadData(2, "Password"));
            SaveBtn.Click();
        }

        #endregion
    }
}
