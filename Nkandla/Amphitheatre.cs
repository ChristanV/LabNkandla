using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nkandla
{
    class Amphitheatre
    {
        private int iNumberOfSeats;

        public Amphitheatre(int _numberofseats)
        {
            this.iNumberOfSeats = _numberofseats;
        }
      
        public int NumberofSeats { get; set; }

        public override string ToString()
        {
            return "Amphitheatre\n" + "Number of seats:" + iNumberOfSeats + "\n";
        }
    }
}
