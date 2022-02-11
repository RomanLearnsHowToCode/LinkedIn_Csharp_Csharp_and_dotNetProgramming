using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Dictionaries: it is a datastructure which contain collection of keys and value pairs
namespace LearningDictionaries
{
    class Program
    {
        static void Main(string[] args)
        {   // dictinoary.Add("key", "value");
            Dictionary<String, String> config = new Dictionary<string, string>();

            config.Add("resolution", "1920x1080");
            config.Add("title", "MyWebsite");
            // accessing values based on keys, the keys can't be duplicates, they must be unique 
            Console.WriteLine(config["title"]);
            Console.WriteLine(config["resolution"]);

            foreach (var setting in config)
            {
                Console.WriteLine(setting.Value);
            }

        }
    }
}