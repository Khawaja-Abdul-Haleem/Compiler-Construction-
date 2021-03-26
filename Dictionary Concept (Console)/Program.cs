using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Dictionary <string, string> dict = new Dictionary<string,string>();
            dict.Add("Amazing", "Incredible");
            dict.Add("Anger", "Enrage");
            dict.Add("Angry", "Furious");
            dict.Add("Answer", "Reply");
            dict.Add("Ask", "Query");
            dict.Add("Brave", "Fearless");
            dict.Add("Big", "Huge");
            dict.Add("Break", "Fracture");
            dict.Add("Bright", "Vivid");
            dict.Add("Cry", "Weep");

            foreach (var item in dict) {
                Console.WriteLine("Key is: " + item.Key + "\t\tValue is: " + item.Value);

            }
            Console.ReadKey();
        }
    }
}
