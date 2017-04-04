using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nkandla
{
    class ChickenRun
    {
        private int iNumberOfChickens;

        public ChickenRun(int _NumberOfChickens)
        {
            this.iNumberOfChickens = _NumberOfChickens;
        }

        public int NumberOfChickens { get; set; }

        public override string ToString()
        {
            return "ChickenRun\n" + "Number of chickens:" + this.iNumberOfChickens +"\n";
        }
    }
}
