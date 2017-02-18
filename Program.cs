using System;
using System.Text.RegularExpressions;
using Microsoft.AspNetCore.Hosting;

namespace WebServiceApplication
{
    public class ConsoleParser
    {
        public static void Main()
        {
            var host = new WebHostBuilder()
             .UseKestrel()
             .UseUrls("http://+:5005")
             .UseStartup<Startup>()
             .Build();

            host.Run();
        }

        private static void ShowWords(String s)
        {
            String pattern = @"\w+";
            var matches = Regex.Matches(s, pattern);
            if (matches.Count == 0)
                Console.WriteLine("\nNo words were identified in your input.");
            else
            {
                Console.WriteLine("\nThere are {0} words in your string:", matches.Count);
                for (int ctr = 0; ctr < matches.Count; ctr++)
                    Console.WriteLine("   #{0,2}: '{1}' at position {2}", ctr,
                                      matches[ctr].Value, matches[ctr].Index);
            }
        }
    }
}
