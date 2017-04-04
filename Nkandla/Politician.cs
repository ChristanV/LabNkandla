using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nkandla
{
    public class Politician: Person, IVisitor
    {
        private Party PoliticianParty;

        public Politician(string _Name, int _Age, char _Gender, Type _type, Party _Party) : base(_Name, _Age, _Gender, _type, _Party)
        {
            this.PoliticianParty = _Party;
        }

        public void visit(HomeStead home)
        {
            if (base.Type.Equals(Type.Politician) && !base.Party.Equals(Party.ANC))
            {
             //   Console.WriteLine(base.Name + " Pay The Money!");
                throw new Exception(base.Name + "Pay The Money!");
            }
            else
            {
                Console.WriteLine(base.Name + " Welcome to Nkandla.");
         
            }
        }

        public override string ToString()
        {
            return base.ToString();
        }

    }

}
