using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleDataLibrary
{
    public class NamesSampleData
    {
        private Random _rand = new();
        public string SampleFirstName()
        {
            List<string> firstNames = File.ReadAllLines("firstnames.txt").ToList();
            int sample = _rand.Next(0, firstNames.Count);
            return firstNames[sample];

        }
        public string SampleLastName()
        {
            List<string> lastNames = File.ReadAllLines("lastnames.txt").ToList();
            int sample = _rand.Next(0, lastNames.Count);
            return lastNames[sample];
        }

        public string SampleFullName()
        {
            return $"{SampleFirstName()} {SampleLastName()}";
        }
    }
}
