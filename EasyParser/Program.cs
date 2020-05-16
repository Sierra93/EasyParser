using System;
using System.Linq;
using System.Net;

namespace EasyParser {
    class Program {
        static void Main(string[] args) {
            string url = "https://www.btb.su/about/articles/yandex-region/";
            WebClient wc = new WebClient();
            string str = wc.DownloadString(url);
            HtmlAgilityPack.HtmlDocument htmlDocument = new HtmlAgilityPack.HtmlDocument();
            htmlDocument.LoadHtml(str);
            var result = htmlDocument.DocumentNode.SelectNodes("//li").Select(el => el.InnerText);

            Console.ReadKey();
        }
    }
}
