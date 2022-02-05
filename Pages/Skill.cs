using MarsQA_1.Helpers;
using MarsQA_1.SpecflowPages.Helpers;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using RelevantCodes.ExtentReports;
using System;
using System.Threading;
using static MarsQA_1.Helpers.CommonMethods;

namespace MarsQA_1.SpecflowPages.Pages
{
    class Skill
    {
            //Add Skill
             private static IWebElement SkillBtn =>  Driver.driver.FindElement(By.XPath("//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
             private static IWebElement AddNewSkillBtn =>  Driver.driver.FindElement(By.XPath("//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div"));
             private static IWebElement AddSkillBox =>  Driver.driver.FindElement(By.Name("name"));
             private static IWebElement AddSkill =>  Driver.driver.FindElement(By.Name("name"));
             private static IWebElement AddSkillLevel =>  Driver.driver.FindElement(By.Name("level"));
             private static IWebElement AddSkillBtn =>  Driver.driver.FindElement(By.XPath("//input[@value='Add']"));

            //Edit Skill
             private static IWebElement SkillToSel =>  Driver.driver.FindElement(By.XPath("//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));
             private static IWebElement EditSkill =>  Driver.driver.FindElement(By.XPath("//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[1]/i"));
             private static IWebElement UpdateSkillBtn =>  Driver.driver.FindElement(By.XPath("//input[@class='ui teal button']"));
             

            //Delete Skill
             private static IWebElement DeleteSkillBtn =>  Driver.driver.FindElement(By.XPath("//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[2]/i"));
            
        #region Add Skill
        internal void EnterSkill()
        {
            //Populate excel data
            ExcelLibHelper.PopulateInCollection(ConstantHelpers.ExcelPath, "Profile");
            // Refresh the page
            Driver.driver.Navigate().Refresh();
            //Click on skill
            SkillBtn.Click();

            //Click on add new skill
          
            AddNewSkillBtn.Click();

            //Add new skill
            AddSkillBox.Click();
            AddSkill.SendKeys(ExcelLibHelper.ReadData(2, "Skill"));

            //Add skill level
            AddSkillLevel.Click();
            new SelectElement(AddSkillLevel).SelectByText(ExcelLibHelper.ReadData(2, "SkillLevel"));
            Thread.Sleep(1000);
        }

        internal void AddSkills()
        {
            //Click on add skill
          AddSkillBtn.Click();
            CommonMethods.test.Log(LogStatus.Info, "Added skill successfully");
        }

        internal void VerifySkill()
        {
            //Populate excel data
            ExcelLibHelper.PopulateInCollection(ConstantHelpers.ExcelPath, "Profile");
            // Refresh the page
            Driver.driver.Navigate().Refresh();
            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();
                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.extent.StartTest("Add skill");

                //Jump to Skill tab

                //Click on skill
              SkillBtn.Click();

                //Verify Skill Name
               WaitHelpers.WaitForElementVisibility(Driver.driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[1]", 50);
                var lastRowSkillName = Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[1]")).Text;
                Assert.That(lastRowSkillName, Is.EqualTo(ExcelLibHelper.ReadData(2, "Skill")));

                //Verify Skill Level
               WaitHelpers.WaitForElementVisibility(Driver.driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[2]", 50);
                var lastRowSkillLevel = Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[2]")).Text;
                Assert.That(lastRowSkillLevel, Is.EqualTo(ExcelLibHelper.ReadData(2, "SkillLevel")));
                CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Skill Added Successfully");
                SaveScreenShotClass.SaveScreenshot(Driver.driver, "SkillAdded");
            }
            catch (Exception ex)
            {
                CommonMethods.test.Log(LogStatus.Fail, "Test Failed");
                Assert.Fail("Test failed to verify Entering Skills", ex.Message);
                
            }
        }
        #endregion

        #region Edit Skill
        internal void EditSkills()
        {
            //Populate excel data
            ExcelLibHelper.PopulateInCollection(ConstantHelpers.ExcelPath, "Profile");
            // Refresh the page
            Driver.driver.Navigate().Refresh();

            //Click on skill
            //Click on skill
           SkillBtn.Click();

            //Click on skill to be edited
           SkillToSel.Click();

            //Click on Edit skill
            WaitHelpers.WaitForElementVisibility(Driver.driver, "XPath", "//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[1]/i", 50);
            EditSkill.Click();

            //Edit the skill
            //Add skill level
           
            AddSkillLevel.Click();
            Thread.Sleep(1000);
            AddSkillLevel.SendKeys(ExcelLibHelper.ReadData(3, "SkillLevel"));
           // new SelectElement(AddSkillLevel).SelectByText(ExcelLibHelper.ReadData(3, "SkillLevel"));
          //  Thread.Sleep(1000);
        }

        internal void UpodateSkills()
        {
            Thread.Sleep(1000);
            //Click on update
           UpdateSkillBtn.Click();
            //CommonMethods.test.Log(LogStatus.Info, "Skill edited successfully");
        }

        internal void VerifyEditedSkill()
        {
            //Populate excel data
            ExcelLibHelper.PopulateInCollection(ConstantHelpers.ExcelPath, "Profile");
            // Refresh the page
            Driver.driver.Navigate().Refresh();
            //Verify updated skill
            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();
                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.extent.StartTest("Edit skill");

                //Jump to Skill tab

                //Click on skill
                SkillBtn.Click();

                //Verify Skill Level
                var lastRowSkillLevel = Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[2]")).Text;
                Assert.That(lastRowSkillLevel, Is.EqualTo(ExcelLibHelper.ReadData(3, "SkillLevel")));
                CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Skill Updated Successfully");
                SaveScreenShotClass.SaveScreenshot(Driver.driver, "SkillUpdated");
            }
            catch (Exception ex)
            {
                CommonMethods.test.Log(LogStatus.Fail, "Test Failed");
                Assert.Fail("Test failed to verify updated Skills", ex.Message);
                
            }
        }
        #endregion

        #region Delete Skill
        internal void DeleteSkill()
        {
            // Refresh the page
            Driver.driver.Navigate().Refresh();
            //Delete Skill

            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();
                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.extent.StartTest("Delete skill");


                //Click on skill
               SkillBtn.Click();

                //Click on skill to be deleted
               SkillToSel.Click();

                //Click on Delete skill
               DeleteSkillBtn.Click();
                CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Skill deleted Successfully");
                SaveScreenShotClass.SaveScreenshot(Driver.driver, "SkillDeleted");

            }
            catch (Exception ex)
            {
                CommonMethods.test.Log(LogStatus.Fail, "Test Failed", ex.Message);

            }
        }
        #endregion
    }
}
