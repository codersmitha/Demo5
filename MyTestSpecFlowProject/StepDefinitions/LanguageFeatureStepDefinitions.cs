
using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Chrome;
using MyTestSpecFlowProject.Pages;
using MyTestSpecFlowProject.Utilities;
using OpenQA.Selenium;
using System.Reflection.Emit;

namespace MyTestSpecFlowProject.StepDefinitions
{
    [Binding]
    public class LanguageFeatureStepDefinitions : CommonDriver
    {
        HomePage homePageObj = new HomePage();
        LoginPage loginPageObj = new LoginPage();
        ProfilePage profilePageObj = new ProfilePage();
        LanguagePage languagePageObj = new LanguagePage();
        

        //SkillsPage skillsPageObj = new SkillsPage();

        [Given(@"User logs into Mars portal")]
        public void GivenUserLogsIntoMarsPortal()
        {
            driver = new ChromeDriver();
            homePageObj.SignInActions(driver);
        }

        [Given(@"User navigates to Profile page")]
        public void GivenUserNavigatesToProfilePage()
        {
            loginPageObj.LoginActions(driver);
        }

        [Given(@"User selects the Language tab")]
        public void GivenUserSelectsTheLanguageTab()
        {
            profilePageObj.ClickLanguageTab(driver);
        }


        [When(@"User adds a new language record '([^']*)' '([^']*)'")]
        public void WhenUserAddsANewLanguageRecord(string language, string level)
        {
            //languagePageObj.DeleteLanguageRecord(driver);
            languagePageObj.AddNewLanguage(driver, language, level);
        }



        [Then(@"Mars portal should save the new language record '([^']*)'")]
        public void ThenMarsPortalShouldSaveTheNewLanguageRecord(string language)
        {
            languagePageObj.AssertAddNewLanguageRecord(driver, language);
        }

        //[Given(@"User choose the update option")]
        //public void GivenUserChooseTheUpdateOption()
        //{
        //    languagePageObj.clickEditButton(driver);
        //}

        //[When(@"User updates language record '([^']*)' '([^']*)'")]
        //public void WhenUserUpdatesLanguageRecord(string language, string level)
        //{
        //    languagePageObj.updateLanguageRecord(driver, language, level);
        //    Thread.Sleep(3000);

        //}
        
        [When(@"User updates language record '([^']*)' '([^']*)'")]
        public void WhenUserUpdatesLanguageRecord(string newlanguage, string newlevel)
        {
            languagePageObj.updateLanguageRecord(driver, newlanguage, newlevel);
            Thread.Sleep(3000);
        }

        [When(@"User updates language value '([^']*)' '([^']*)'")]
        public void WhenUserUpdatesLanguageValue(string oldlanguagevalue, string newlanguagevalue)
        {
            languagePageObj.updateLanguageValue(driver , oldlanguagevalue, newlanguagevalue);
        }

        //[Then(@"Mars portal should save the updated language record '([^']*)' '([^']*)'")]
        //public void ThenMarsPortalShouldSaveTheUpdatedLanguageRecord(string hindi, string marathi)
        //{
        //    throw new PendingStepException();
        //}





        //[When(@"User updates language record <language> <level>")]
        //public void WhenUserUpdatesLanguageRecordLanguageLevel(string language,string level)
        //{
        //    languagePageObj.updateLanguageRecord(driver, language, level);
        //}

        //[Then(@"Mars portal should save the updated language record <language>")]
        //public void ThenMarsPortalShouldSaveTheUpdatedLanguageRecordLanguage()
        //{
        //    throw new PendingStepException();
        //}

        //[Then(@"the language record  should be deleted")]
        //public void ThenTheLanguageRecordShouldBeDeleted()
        //{
        //    throw new PendingStepException();
        //}


        //[When(@"User deletes language record")]
        //public void WhenUserDeletesLanguageRecord()
        //{
        //    for (int i = 0; i < 4; i++) 
        //    {
        //        languagePageObj.DeleteLanguageRecord(driver);
        //        Thread.Sleep(1000);
        //        driver.Navigate().Refresh();

        //    }

        //}

        //[Then(@"the language record  should be deleted")]
        //public void ThenTheLanguageRecordShouldBeDeleted()
        //{
        //    languagePageObj.AssertDeleteLanguageRecord(driver);
        //}

        //[Then(@"the language record  should be deleted")]
        //public void ThenTheLanguageRecordShouldBeDeleted()
        //{
        //    languagePageObj.AssertDeleteLanguageRecord(driver);
        //}


        [AfterScenario]
        public void Closedriver()
        {
            driver.Close();
        }
    }
}
