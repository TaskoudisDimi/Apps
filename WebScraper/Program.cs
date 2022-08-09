using SimpleWebScraper.Builders;
using SimpleWebScraper.Data;
using SimpleWebScraper.Workers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;


namespace WebScraper
{
    class Program
    {

        private const string Method = "search";


        static void Main(string[] args)
        {


            //Person person = new Person();
            //person.FirstName = "Test";

            //Console.WriteLine(person.FirstName);

            //person.FirstName = "";
            //Console.WriteLine(person.FirstName);


            //SuperPerson person2 = new SuperPerson("Test1", "Test2");
            //person2.Walk();
            //person2.Sleep();


            //Person person1 = new PersonBuilder().Build();
            //Person person2 = new PersonBuilder().Build();
            //Person person3 = new PersonBuilder().FirstName("TestName").Build();




            ////Regular Expressions
            //MatchCollection matches = Regex.Matches("Test Test Test Test This is my rat", "This is my [a-z]at");

            //foreach (var match in matches)
            //{
            //    Console.WriteLine(match);
            //}





            //Build WebScraper



            try
            {
                Console.WriteLine("Please enter which city you would like to scrape information from:");
                var craigslistCity = Console.ReadLine() ?? string.Empty;

                Console.WriteLine("Please enter the CraigsList category that you would like to scrape:");
                var craigslistCategoryName = Console.ReadLine() ?? string.Empty;

                using (WebClient client = new WebClient())
                {
                    string content = client.DownloadString($"http://{craigslistCity.Replace(" ", string.Empty)}.craigslist.org/{Method}/{craigslistCategoryName}");

                    ScrapeCriteria scrapeCriteria = new ScrapeCriteriaBuilder()
                        .WithData(content)
                        // craigslist recently added an id to their group elements which I have included here as an update - 10/5/2020
                        .WithRegex(@"<a href=\""(.*?)\"" data-id=\""(.*?)\"" class=\""result-title hdrlnk\"" id=\""(.*?)\"" >(.*?)</a>")
                        .WithRegexOption(RegexOptions.ExplicitCapture)
                        .WithPart(new ScrapeCriteriaPartBuilder()
                            .WithRegex(@">(.*?)</a>")
                            .WithRegexOption(RegexOptions.Singleline)
                            .Build())
                        .WithPart(new ScrapeCriteriaPartBuilder()
                            .WithRegex(@"href=\""(.*?)\""")
                            .WithRegexOption(RegexOptions.Singleline)
                            .Build())
                        .Build();

                    Scraper scraper = new Scraper();

                    var scrapedElements = scraper.Scrape(scrapeCriteria);

                    if (scrapedElements.Any())
                    {
                        foreach (var scrapedElement in scrapedElements) Console.WriteLine(scrapedElement);
                    }
                    else
                    {
                        Console.WriteLine("There were no matches for the specified scrape criteria.");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }



        }
    }
}


