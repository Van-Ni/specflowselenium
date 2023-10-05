using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public class YoutubeSearchFeatureStepDefinitions
    {
        private IWebDriver driver;

        
        [Given(@"Open the browser")]
        public void GivenOpenTheBrowser()
        {
            driver = new ChromeDriver(@"D:\Vanni\QNU\AutoTest\SpecFlowProject1\chromedriver-win64");
            driver.Manage().Window.Maximize();
        }

        [When(@"Enter the URL")]
        public void WhenEnterTheURL()
        {
            driver.Url = "https://www.youtube.com/";
            Thread.Sleep(3000);
        }

        [Then(@"Search for the BDD Framework")]
        public void ThenSearchForTheBDDFramework()
        {
            var searchBox = driver.FindElement(By.CssSelector("input[name='search_query']"));
            searchBox.SendKeys("BDD Framework");
            searchBox.SendKeys(Keys.Enter);
            Thread.Sleep(5000);
        }

    }
}
