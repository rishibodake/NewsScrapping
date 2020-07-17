using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;

namespace NewsScrapping
{
    public class AccessWeb
    {
        IWebDriver driver = new ChromeDriver();
        Dictionary<int, string> mapForNews;
        IList<IWebElement> newsHeadings;
        IList<IWebElement> newsPonts;
        public void OpenLink()
        {
            driver.Url = "https://news.ycombinator.com/";
        }

        public void ScrapTheNeededData()
        {
            mapForNews = new Dictionary<int, string>();//Creating map for all the news
            newsHeadings = driver.FindElements(By.ClassName("storylink"));//List Of  All The News 
            newsPonts = driver.FindElements(By.ClassName("score"));//List Of All The Points

            for (int i = 0; i < newsHeadings.Count; i++)
            {               
                mapForNews[Int16.Parse(newsPonts[i].Text.Split(' ')[0])] = newsHeadings[i].Text;
            }         
        }

        public void SortTheDataPointWise()
        {
            int[] arrayOfPoints = new int[mapForNews.Count];
            int count = -1;
            foreach (var i in mapForNews)
            {
                count++;
                arrayOfPoints[count] = i.Key;
            }
            Array.Sort(arrayOfPoints);
            Console.WriteLine(arrayOfPoints[arrayOfPoints.Length - 1]);
            Console.WriteLine(mapForNews[arrayOfPoints[arrayOfPoints.Length - 1]]);
        }
    }
}
