using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nkandla
{
     class Nkandla : HomeStead
    {
        private ChickenRun chickenrun;
        private Amphitheatre amphitheatre;
        private SwimmingPool swimmingPool;

        public Nkandla(string _Name, string _District, string _Province, string _Country) : base(_Name, _District, _Province, _Country)
        {
        }


        public ChickenRun ChickenRun
        {
            get { return this.chickenrun; }
            set { this.chickenrun = value; }
        }

        public Amphitheatre Amphitheatre
        {
            get { return this.amphitheatre; }
            set { this.amphitheatre = value; }
        }

        public SwimmingPool SwimmingPool
        {
            get { return this.swimmingPool; }
            set { this.swimmingPool = value; }
        }

        public override string ToString()
        {
            return base.ToString();
        }

    }
}
