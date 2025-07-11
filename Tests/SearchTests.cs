﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SearchTests;

namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        private IWebDriver driver;

        [TestInitialize]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.ebay.com");
        }

        [TestMethod]
        public void Test1_field()
        {
            IWebElement searchBox = driver.FindElement(By.Id("gh-ac"));
            Assert.IsNotNull(searchBox);
        }

        [TestMethod]
        public void Test2_search()
        {
            IWebElement searchButton = driver.FindElement(By.Id("gh-btn"));
            Assert.IsNotNull(searchButton);
        }

        [TestCleanup]
        public void Cleanup()
        {
            driver.Quit();
        }
    }
}