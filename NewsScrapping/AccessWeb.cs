using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace NewsScrapping
{
    public class AccessWeb
    {
        IWebDriver driver = new ChromeDriver();
        public void OpenLink()
        {
            driver.Url = "https://news.ycombinator.com/";
        }
    }
}
