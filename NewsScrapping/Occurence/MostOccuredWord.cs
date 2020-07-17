
using OpenQA.Selenium;
using System;
using System.Collections.Generic;

namespace NewsScrapping
{
    public class MostOccuredWord
    {
        IWebDriver driver;
        public IList<IWebElement> newsHeadings;
        string combined = "";
        public string mostOccuredWordInNews;
        public MostOccuredWord(IWebDriver driver)
        {
            this.driver = driver;
        }

        public string MostOccuredWords()
        {
            newsHeadings = driver.FindElements(By.ClassName("storylink"));
            foreach (var index in newsHeadings)
            {
                combined = combined + index.Text;
            }
            
            string[] splited = combined.Split(' ');
            Array.Sort(splited);
            int max = 0;
            int count = 0;
            string word = splited[0];
            string currunt = splited[0];
            for (int i = 1; i < splited.Length; i++)
            {
                if (splited[i].Equals(currunt))
                {
                    count++;
                }
                else
                {
                    count = 1;
                    currunt = splited[i];
                }
                if (max < count)
                {
                    max = count;
                    word = splited[i];
                }
            }
            Console.WriteLine("'"+word+"'" + " is most occured in all news for " + max + " times");
            mostOccuredWordInNews = word;
            return word;
        }
    }
}
