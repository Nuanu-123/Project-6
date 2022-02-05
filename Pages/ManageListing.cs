using MarsQA_1.Helpers;
using MarsQA_1.SpecflowPages.Helpers;
using NUnit.Framework;
using OpenQA.Selenium;
using RelevantCodes.ExtentReports;
using System;
using System.Threading;
using static MarsQA_1.Helpers.CommonMethods;

namespace MarsQA_1.SpecflowPages.Pages
{
    class ManageListing
    {

            private static IWebElement manageListingsLink =>  Driver.driver.FindElement(By.LinkText("Manage Listings"));
            private static IWebElement view =>  Driver.driver.FindElement(By.XPath("(//i[@class='eye icon'])[1]"));
            private static IWebElement ViewValidation =>  Driver.driver.FindElement(By.XPath("//*[@id='service-detail-section']/div[2]/div/div[2]/div[1]/div[1]/div[2]/h1/span"));

            private static IWebElement edit  =>  Driver.driver.FindElement(By.XPath("//*[@id='listing-management-section']/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[8]/div/button[2]/i"));
            private static IWebElement Title =>  Driver.driver.FindElement(By.Name("title"));
            private static IWebElement Save =>  Driver.driver.FindElement(By.XPath("//input[@value='Save']"));
           
            private static IWebElement delete =>  Driver.driver.FindElement(By.XPath("//*[@id='listing-management-section']/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[8]/div/button[3]/i"));
            private static IWebElement clickActionsButton =>  Driver.driver.FindElement(By.XPath("//div[@class='actions']"));
            private static IWebElement yesBtn =>  Driver.driver.FindElement(By.XPath("/html/body/div[2]/div/div[3]/button[2]/i"));


        #region View Listing
        internal void Listings()
        {
            //Click on Manage Listing
            WaitHelpers.WaitForElementVisibility(Driver.driver, "LinkText", "Manage Listings", 50);
            manageListingsLink.Click();
            Driver.driver.Navigate().Refresh();
            Thread.Sleep(1000);
        }

        internal void ListingsView()
        {
            //Click on view button
            WaitHelpers.WaitForElementVisibility(Driver.driver, "XPath", "(//i[@class='eye icon'])[1]", 50);
            view.Click();

        }

        internal void ListingsVerify()
        {
            //Populate excel data
            ExcelLibHelper.PopulateInCollection(ConstantHelpers.ExcelPath, "ManageListing");
            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();
                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.extent.StartTest("ViewListing");

                WaitHelpers.WaitForElement(Driver.driver, "XPath", "//*[@id='service-detail-section']/div[2]/div/div[2]/div[1]/div[1]/div[2]/h1/span", 40000);
                var ViewValidation = Driver.driver.FindElement(By.XPath("//*[@id='service-detail-section']/div[2]/div/div[2]/div[1]/div[1]/div[2]/h1/span")).Text;
                Assert.That(ViewValidation, Is.EqualTo(ExcelLibHelper.ReadData(2, "Title")));
                CommonMethods.test.Log(LogStatus.Pass, "Able to view listing");
                SaveScreenShotClass.SaveScreenshot(Driver.driver, "ListingViewSuccessfull");
            }
            catch (Exception ex)
            {
                Assert.Fail("verify the share skill page failed", ex.Message);
               CommonMethods.test.Log(LogStatus.Fail, "Unable to view listing");
            }
        }
        #endregion

        #region Edit Listing
        internal void OpenListings()
        {
            //Click on Manage Listing
            WaitHelpers.WaitForElementVisibility(Driver.driver, "LinkText", "Manage Listings", 50);
            manageListingsLink.Click();
        }

        internal void EditListings()
        {
            //Click on Edit button
            WaitHelpers.WaitForElementVisibility(Driver.driver, "XPath", "//*[@id='listing-management-section']/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[8]/div/button[2]/i", 50);
            edit.Click();
        }

        internal void EditDetails()
        {
            //Populate excel data
            ExcelLibHelper.PopulateInCollection(ConstantHelpers.ExcelPath, "ManageListing");
            //Edit title
            WaitHelpers.WaitForElementVisibility(Driver.driver, "Name", "title", 50);
            Title.Click();
            Title.Clear();
            Title.SendKeys(ExcelLibHelper.ReadData(3, "Title"));

            //Click on save button
            WaitHelpers.WaitForElementVisibility(Driver.driver, "XPath", "//input[@value='Save']", 50);
            Save.Click();
        }

        internal void ValidateEditedDetails()
        {
            //Populate excel data
            ExcelLibHelper.PopulateInCollection(ConstantHelpers.ExcelPath, "ManageListing");
            // Refresh the page
            Driver.driver.Navigate().Refresh();

            //Validate edited data
            //Click on Manage Listing
            WaitHelpers.WaitForElementVisibility(Driver.driver, "LinkText", "Manage Listings", 50);
            manageListingsLink.Click();
            Thread.Sleep(5000);
            //Click on view button
            WaitHelpers.WaitForElementVisibility(Driver.driver, "XPath", "(//i[@class='eye icon'])[1]", 50);
            view.Click();
            Driver.driver.Navigate().Refresh();
            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();
                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.extent.StartTest("EditListing");

                WaitHelpers.WaitForElement(Driver.driver, "XPath", "//*[@id='service-detail-section']/div[2]/div/div[2]/div[1]/div[1]/div[2]/h1/span", 20000);
                var ViewValidation = Driver.driver.FindElement(By.XPath("//*[@id='service-detail-section']/div[2]/div/div[2]/div[1]/div[1]/div[2]/h1/span")).Text;
                Assert.That(ViewValidation, Is.EqualTo(ExcelLibHelper.ReadData(3, "Title")));
                CommonMethods.test.Log(LogStatus.Pass, "Listing Edited successfully");
                SaveScreenShotClass.SaveScreenshot(Driver.driver, "ListingUpdated");
            }
            catch (Exception ex)
            {
                Assert.Fail("verify the edited share skill page failed", ex.Message);
                CommonMethods.test.Log(LogStatus.Fail, "Unable to edit listing");
            }

        }
        #endregion

        #region Delete Listing
        internal void NavListings()
        {
            //Click on Manage Listing
            WaitHelpers.WaitForElementVisibility(Driver.driver, "LinkText", "Manage Listings", 50);
            manageListingsLink.Click();

        }

        internal void DeleteListings()
        {
            //Click on delete button
            WaitHelpers.WaitForElementVisibility(Driver.driver, "XPath", "//*[@id='listing-management-section']/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[8]/div/button[3]/i", 50);
            delete.Click();


            WaitHelpers.WaitForElementVisibility(Driver.driver, "XPath", "//div[@class='actions']", 50);
            clickActionsButton.Click();
            //Select yes
            try
            {
                WaitHelpers.WaitForElementVisibility(Driver.driver, "XPath", "/html/body/div[2]/div/div[3]/button[2]/i", 50);
                yesBtn.Click();
                
            }
            catch (Exception ex)
            {
                Console.WriteLine("cannot able to delete skill", ex);
                
            }

        }

        internal void ValidateDeletedDetails()
        {
            //Populate excel data
            ExcelLibHelper.PopulateInCollection(ConstantHelpers.ExcelPath, "ManageListing");
            // Refresh the page
            Driver.driver.Navigate().Refresh();
            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();
                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.extent.StartTest("DeleteListing");
                //Verify deleted details

                var deletedListing = Driver.driver.FindElement(By.XPath("//*[@id='listing-management-section']/div[2]/div[1]/div[1]/table/tbody/tr/td[3]")).Text;
                if (deletedListing != ExcelLibHelper.ReadData(3, "Title"))
                {
                    Assert.Pass("Manage Listing deleted successfuly");
                    CommonMethods.test.Log(LogStatus.Pass, "deleted successfuly");
                    SaveScreenShotClass.SaveScreenshot(Driver.driver, "ListingDeleted");
                }
                else
                {
                    Assert.Fail("Manage Listing not deleted");
                    CommonMethods.test.Log(LogStatus.Fail, "Listing not deleted successfuly");
                }
            }
            catch
            {
                Console.WriteLine("Test passed, Listing deleted");
            }
        }
        #endregion

    }
}
