using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Namu_darbai_1
{
   public class Uzduotis1
    {

        public void uzduotis01Met() {
            // uzduotis_1
            Console.WriteLine("Kiek turite bendru draugu?");
            var bendriDraugai = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sauliau, kiek turi draugu?");
            var sauliausDraugai = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ramune, Kiek turi draugu?");
            var ramunesDraugai = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kiek turite sutaupytu pinigu?");
            var santaupos = Convert.ToDouble(Console.ReadLine());

            double pinigaiVienamVaikui = (santaupos / (bendriDraugai + sauliausDraugai + ramunesDraugai));

            Console.WriteLine("Vienam vaikui galima isleisti: " + pinigaiVienamVaikui + "eur.");
        }
    }
}
