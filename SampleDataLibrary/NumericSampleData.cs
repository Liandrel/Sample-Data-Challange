using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleDataLibrary
{
    public class NumericSampleData
    {
        private Random rand = new();
        public bool sampleBool()
        {
            if (rand.Next() % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public int sampleInt(int minRange, int maxRange)
        {
            return rand.Next(minRange, maxRange);
        }
        public double sampleDouble(double minRange, double maxRange)
        {
            return Math.Round((rand.NextDouble() * (maxRange - minRange) + minRange), 3);
        }
        public string samplePhoneNumber(string format)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < 10; i++)
            {
                sb.Append(rand.Next(1, 9));
            }

            return String.Format(format, double.Parse(sb.ToString()));

        }

        public string sampleZipCode(string format)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < 9; i++)
            {
                sb.Append(rand.Next(1, 9));
            }

            return String.Format(format, double.Parse(sb.ToString()));
        }
    }
}
