using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleDataLibrary
{
    public class NumericSampleData
    {
        private Random _rand;

        public NumericSampleData()
        {
            _rand = new();
        }
        public bool SampleBool()
        {
            if (_rand.Next() % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public int SampleInt(int minRange, int maxRange)
        {
            return _rand.Next(minRange, maxRange);
        }
        public double SampleDouble(double minRange, double maxRange)
        {
            return Math.Round((_rand.NextDouble() * (maxRange - minRange) + minRange), 3);
        }
        public string SamplePhoneNumber(string format)
        {
            StringBuilder sb = new();

            for (int i = 0; i < 10; i++)
            {
                sb.Append(_rand.Next(1, 9));
            }

            return String.Format(format, double.Parse(sb.ToString()));

        }

        public string SampleZipCode(string format)
        {
            StringBuilder sb = new();

            for (int i = 0; i < 9; i++)
            {
                sb.Append(_rand.Next(1, 9));
            }

            return String.Format(format, double.Parse(sb.ToString()));
        }
    }
}
