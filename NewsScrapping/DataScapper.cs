
using OpenQA.Selenium;
using System;
using System.Collections.Generic;

namespace NewsScrapping
{
    public class DataScapper
    {
        IWebDriver driver;
        public Dictionary<int, string> mapForNews;
        public IList<IWebElement> newsHeadings;
        public IList<IWebElement> newsPonts;
        string one = "";
        public DataScapper(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void ScrapTheNeededData()
        {
            mapForNews = new Dictionary<int, string>();//Creating map for all the news
            newsHeadings = driver.FindElements(By.ClassName("storylink"));//List Of  All The News 
            newsPonts = driver.FindElements(By.ClassName("score"));//List Of All The Points

            for (int i = 0; i < newsHeadings.Count; i++)
            {
                mapForNews[Int16.Parse(newsPonts[i].Text.Split(' ')[0])] = newsHeadings[i].Text;
                           //Removing points and converting                 News Heading
                            //into int    KEY                                Values   
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

        public void MostOccuredWord()
        {
            newsHeadings = driver.FindElements(By.ClassName("storylink"));
            foreach (var index in newsHeadings)
            {
                one = one + index;
            }
            Console.WriteLine(one);
        }

    }
}
