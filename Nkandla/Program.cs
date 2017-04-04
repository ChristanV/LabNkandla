using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nkandla
{
    class Program
    {
        static void Main(string[] args)
        {
            HomeStead home = new HomeStead("Zuma", "Wierda", "Gauteng", "Unfortunantly in RZA");
            Nkandla nkandla = new Nkandla("Zuma", "Wierda", "Gauteng", "Unfortunantly in RZA");

            ChickenRun run = new ChickenRun(5);
            Amphitheatre theatre = new Amphitheatre(100);
            SwimmingPool pool = new SwimmingPool(10, 20);


            Politician JacobZuma = new Politician("JZ", 55, 'M', Type.President, Party.ANC);
     
            Lawyer Laywer = new Lawyer("Lawyer1", 32, 'M', Type.Lawyer, Party.ANC);
            Architect Architect = new Architect("Architect", 32, 'F', Type.Architect, Party.ANC);

            Politician HelenZille = new Politician("Helen Zille", 500000, 'F', Type.Politician, Party.DA);
            Politician JuliusMalema = new Politician("Julius", 24, 'M', Type.Politician, Party.EFF);
            Politician Pravin = new Politician("Pravin", 24, 'M', Type.Politician, Party.ANC);



            //Nkandla Properties
            Console.WriteLine(nkandla.ToString());
            Console.WriteLine("Nkandla Details:");
            Console.WriteLine(theatre.ToString());
            Console.WriteLine(run.ToString());
            Console.WriteLine(pool.ToString());

            //People
            Console.WriteLine("People:");
            Console.WriteLine(JacobZuma.ToString());
            Console.WriteLine(HelenZille.ToString());
            Console.WriteLine(JuliusMalema.ToString());
            Console.WriteLine(Pravin.ToString());

            Console.WriteLine(Laywer.ToString());
            Console.WriteLine(Architect.ToString());


            Console.WriteLine();
            //Visitors
            Console.WriteLine("Visitors of Nkandla:");


                JacobZuma.visit(nkandla);
                HelenZille.visit(nkandla);
                JuliusMalema.visit(nkandla);
                Pravin.visit(nkandla);


            Console.ReadKey();
        }

    }
}
