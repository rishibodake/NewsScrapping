using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;

namespace NewsScrapping
{
    public class AccessWeb
    {
        IWebDriver driver = new ChromeDriver();
        public void OpenLink()
        {
            driver.Url = "https://news.ycombinator.com/";
        }

        public void News()
        {
            Dictionary<int, string> mapForNews = new Dictionary<int, string>();
            IList<IWebElement> newsHeadings = driver.FindElements(By.ClassName("storylink"));
            IList<IWebElement> newsPonts = driver.FindElements(By.ClassName("score"));

            for (int i = 0; i < newsHeadings.Count; i++)
            {               
                mapForNews[Int16.Parse(newsPonts[i].Text.Split(' ')[0])] = newsHeadings[i].Text;
            }
            int[] arrayOfPonts = new int[mapForNews.Count];
            int count = -1;
            foreach (var i in mapForNews)
            {
                count++;

                // Console.WriteLine(i.Key);//returns int key value
                arrayOfPonts[count] = i.Key;
                //Console.WriteLine(a[count]);

            }
            Array.Sort(arrayOfPonts);
            Console.WriteLine(arrayOfPonts[arrayOfPonts.Length - 1]);
            Console.WriteLine(mapForNews[arrayOfPonts[arrayOfPonts.Length - 1]]);
        }
    }
}
