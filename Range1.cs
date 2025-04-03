using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BagrutListLab8n
{
    public class Range1
    {
        private int high;
        private int low;

        public Range1(int high, int low)
        {
            this.high = high;
            this.low = low;
        }
        public int GetHigh() 
        {
            return high;
        }
        public int GetLow() 
        {
            return high;
        }
        public override string ToString()
        {
            return "High: " + high + " Low: " + low;
        }

    }
}
