using System;
using System.IO;
using Newtonsoft.Json;
using System.Text.RegularExpressions;
namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //read the JSON 
            string fileToDesirialize = @"C:\Users\Preslav\Downloads\task1\task1\task1\sample.txt";
            
            string jsonText = File.ReadAllText(fileToDesirialize);
            var data = JsonConvert.DeserializeObject<MovieStar[]>(jsonText);
            // Create a pattern for nums  
            string pattern = @"\b\d+\b";
            // Create a Regex  
            Regex rg = new Regex(pattern);
            //create regex
            foreach (var item in data)
            {
                Console.WriteLine($"{item.Name} {item.Surname}");
                Console.WriteLine($"{item.Sex}");
                Console.WriteLine($"{item.Nationality}");
                
                string result = rg.Matches(item.dateOfBirth)[1].Value;
                Console.WriteLine($"{DateTime.Now.Year - int.Parse(result)} years old");
                Console.WriteLine();
            }
            
        }
    }
    //I am aware that classes usally stay within their own files. For bravity sake I have decided to include the class within the same file. 
    public class MovieStar
    {
        public string dateOfBirth { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Sex { get; set; }
        public string Nationality { get; set; }
    }
}
