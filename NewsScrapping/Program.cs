using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace NewsScrapping
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            AccessWeb web = new AccessWeb(driver);
            DataScapper scapper = new DataScapper(driver);

            web.OpenLink();
            scapper.ScrapTheNeededData();
            scapper.SortTheDataPointWise();
           

        }
    }
}
