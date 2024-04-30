using System;
using System.Collections.Concurrent;
using System.IO;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SimpleCrawler
{
    class SimpleCrawler
    {
        private ConcurrentDictionary<string, bool> urls = new ConcurrentDictionary<string, bool>();
        private int count = 0;

        static void Main(string[] args)
        {
            SimpleCrawler myCrawler = new SimpleCrawler();
            string startUrl = "http://www.cnblogs.com/dstang2000/";
            if (args.Length >= 1) startUrl = args[0];
            myCrawler.urls.TryAdd(startUrl, false); // 加入初始页面
            myCrawler.Crawl();
        }

        private void Crawl()
        {
            Console.WriteLine("开始爬行了.... ");
            while (true)
            {
                Parallel.ForEach(urls.Keys, new ParallelOptions { MaxDegreeOfParallelism = 10 }, url => {
                    if (urls.TryGetValue(url, out bool visited) && !visited)
                    {
                        Console.WriteLine("爬行" + url + "页面!");
                        string html = DownLoad(url); // 下载
                        urls[url] = true;
                        count++;
                        Parse(html); // 解析,并加入新的链接
                        Console.WriteLine("爬行结束");
                    }
                });

                if (count > 10) break;
            }
        }

        public string DownLoad(string url)
        {
            try
            {
                WebClient webClient = new WebClient();
                webClient.Encoding = Encoding.UTF8;
                string html = webClient.DownloadString(url);
                string fileName = count.ToString();
                File.WriteAllText(fileName, html, Encoding.UTF8);
                return html;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return "";
            }
        }

        private void Parse(string html)
        {
            string strRef = @"(href|HREF)[]*=[]*[""'][^""'#>]+[""']";
            MatchCollection matches = new Regex(strRef).Matches(html);
            foreach (Match match in matches)
            {
                strRef = match.Value.Substring(match.Value.IndexOf('=') + 1)
                          .Trim('"', '\"', '#', '>');
                if (strRef.Length == 0) continue;
                urls.TryAdd(strRef, false);
            }
        }
    }
}
