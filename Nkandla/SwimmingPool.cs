using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nkandla
{
    class SwimmingPool
    {
        private double iWidth;
        private double iLength;

        public SwimmingPool(double _Width, double _Height)
        {
            this.iWidth = _Width;
            this.iLength = _Height;
        }

        public double Width { get; set; }
        public double Height { get; set; }

        public override string ToString()
        {
            return "SwimmingPool\n" + "Width:" + iWidth + "\nLength:" + iLength + "\n";
        }
    }
}
