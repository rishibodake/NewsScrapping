
using OpenQA.Selenium;

namespace NewsScrapping
{
    public class DataScapper
    {
        IWebDriver driver;
        public DataScapper(IWebDriver driver)
        {
            this.driver = driver;
        }
    }
}
