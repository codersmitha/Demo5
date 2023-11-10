using NUnit.Framework;
using OpenQA.Selenium;
using MyTestSpecFlowProject.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using static System.Collections.Specialized.BitVector32;
//using OpenQA.Selenium.Support.PageObjects;

namespace MyTestSpecFlowProject.Pages
{
    public class LanguagePage
    {
        public void AddNewLanguage(IWebDriver driver, string language, string level)
        {
            Thread.Sleep(3000);
            //Wait.waitToBeVisible(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div",10);
            IWebElement AddNewButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
            AddNewButton.Click();
            IWebElement addLanguageInputBox = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[1]/input"));
            addLanguageInputBox.Click();
            addLanguageInputBox.SendKeys(language);
            IWebElement selectLanguageLevelDropdown = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select"));
            selectLanguageLevelDropdown.Click();
            ////if  (level.Equals("Choose Language Level"))
            //{
            //    IWebElement leveloptions = driver.FindElement(By.XPath("//Option[@value='Choose Language Level']"));
            //    leveloptions.Click();
            //}
            if (level.Equals("Basic"))
            {
                IWebElement leveloptions = driver.FindElement(By.XPath("//Option[@value='Basic']"));
                leveloptions.Click();
            }
            else if (level.Equals("Conversational"))
            {
                IWebElement leveloptions = driver.FindElement(By.XPath("//Option[@value='Conversational']"));
                leveloptions.Click();
            }
            else if (level.Equals("Fluent"))
            {
                IWebElement leveloptions = driver.FindElement(By.XPath("//Option[@value='Fluent']"));
                leveloptions.Click();
            }
            else if (level.Equals("Native/Bilingual"))
            {
                IWebElement leveloptions = driver.FindElement(By.XPath("//Option[@value='Native/Bilingual']"));
                leveloptions.Click();
            }
            IWebElement addButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]"));
            addButton.Click();

        }

        public void AssertAddNewLanguageRecord(IWebDriver driver, String language)
        {
            driver.Navigate().Refresh();
            IWebElement lastLanguageRecord = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));
            Assert.That(lastLanguageRecord.Text == language, "Language record has not added successfully");
            Thread.Sleep(2000);
        }

        //public void clickEditButton(IWebDriver driver)
        //{
        //    Thread.Sleep(2000);
        //    //Wait.waitToBeVisible(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div",10);
        //    IWebElement editButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[3]/span[1]/i"));
        //    editButton.Click();
        //    Thread.Sleep(2000);
        //}

        public void updateLanguageRecord(IWebDriver driver, string newlanguage,string newlevel)
        {
             //Wait.waitToBeVisible(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div",10);
            driver.Navigate ().Refresh();
            IWebElement editButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr/td[3]/span[1]/i"));
             editButton.Click();
            Thread.Sleep(2000);
            IWebElement updateLanguageInputBox = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr/td/div/div[1]/input"));
            updateLanguageInputBox.Click();
             updateLanguageInputBox.Clear();
            Thread.Sleep(1000);
            updateLanguageInputBox.SendKeys(newlanguage);
            Thread.Sleep(1000);
            IWebElement updateLanguageLevelDropdown = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr/td/div/div[2]/select"));
            updateLanguageLevelDropdown.Click();
            if (newlevel.Equals("Basic"))
            {
                IWebElement leveloptions = driver.FindElement(By.XPath("//Option[@value='Basic']"));
                leveloptions.Click();
            }
            else if (newlevel.Equals("Conversational"))
            {
                IWebElement leveloptions = driver.FindElement(By.XPath("//Option[@value='Conversational']"));
                leveloptions.Click();
            }
            else if (newlevel.Equals("Fluent"))
            {
                IWebElement leveloptions = driver.FindElement(By.XPath("//Option[@value='Fluent']"));
                leveloptions.Click();
            }
            else if (newlevel.Equals("Native/Bilingual"))
            {
                IWebElement leveloptions = driver.FindElement(By.XPath("//Option[@value='Native/Bilingual']"));
                leveloptions.Click();
            }
            IWebElement updateButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/span/input[1]"));
            updateButton.Click();

        }

        public void updateLanguageValue(IWebDriver driver, string oldlanguagevalue, string newlanguagevalue)
        {

            driver.Navigate().Refresh();
            IWebElement editButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[2]/tr/td[3]/span[1]/i"));
            editButton.Click();
            Thread.Sleep(2000);
            IWebElement updateLanguageValue = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[2]/tr/td/div/div[1]/input"));
            updateLanguageValue.Click();
            updateLanguageValue.Clear();
            Thread.Sleep(1000);
            updateLanguageValue.SendKeys(newlanguagevalue);
            Thread.Sleep(1000);
            IWebElement updateButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/span/input[1]"));
            updateButton.Click();




        }
        //    public void DeleteLanguageRecord(IWebDriver driver)
        //{
        //    Thread.Sleep(2000);
        //    IWebElement deleteButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr/td[3]/span[2]/i"));
        //    deleteButton.Click();
        //    driver.Navigate().Refresh();

        //}

        //public void AssertDeleteLanguageRecord(IWebDriver driver)
        //{
        //    IWebElement deletedRecord = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[1]"));

        //    IWebElement deletedRecord = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr/td[3]/span[2]/i"));
        //    Assert.Fail("Record was not deleted");
        //    Thread.Sleep(2000);
        //}




    }
    //{
    //    Thread.Sleep(2000);
    //    Thread.Sleep(2000);
    //    IWebElement recordToBeDeleted = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr/td[1]"));
    //    if (recordToBeDeleted.Text == language)
    //    {

    //        IWebElement deleteButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr/td[3]/span[2]/i"));
    //        deleteButton.Click();
    //    }
    //    else
    //    {
    //        Assert.Fail("Record to deleted has not been found.");
    //    }
    //driver.Navigate().Refresh();

}


