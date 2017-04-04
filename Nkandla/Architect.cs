using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nkandla
{
    class Architect : Person
    {
        public Architect(string _Name, int _Age, char _Gender, Type _type, Party _Party) : base(_Name, _Age, _Gender, _type, _Party)
        {

        }

        public override string ToString()
        {
            return "Lawyer " + base.ToString();
        }
    }
}
