namespace NewsScrapping
{
    class Program
    {
        static void Main(string[] args)
        {
            AccessWeb web = new AccessWeb();
            web.OpenLink();
        }
    }
}
