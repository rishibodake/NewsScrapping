using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;

namespace NewsScrapping
{
    public class AccessWeb
    {
        IWebDriver driver;
        public AccessWeb(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void OpenLink()
        {
            driver.Url = "https://news.ycombinator.com/";
        } 
    }
}
