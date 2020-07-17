using NewsScrapping;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace NUnitTestProject1
{
    public class Tests
    {
        IWebDriver driver;
        AccessWeb web;
        DataScapper scrapper;
        MostOccuredWord word;
       [OneTimeSetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            web = new AccessWeb(driver);
            scrapper = new DataScapper(driver);
            word = new MostOccuredWord(driver);
        }

        [Test,Order(1)]
        public void OpenWebSite()
        {           
            web.OpenLink();
            Assert.AreEqual("Hacker News",driver.Title);
        }

        [Test,Order(2)]
        public void WebScrapping()
        {
            scrapper.ScrapTheNeededData();
            int number = scrapper.newsHeadings.Count;
            Assert.AreEqual(30, number);
        }

        [Test,Order(3)]
        public void NewsSorting()
        {
            scrapper.SortTheDataPointWise();
        }

        [Test,Order(4)]
        public void MostOccuredWordTest()
        {
            string mostOccuredWord = word.MostOccuredWords();
            Assert.AreEqual(word.mostOccuredWordInNews, mostOccuredWord);
        }
    }
}