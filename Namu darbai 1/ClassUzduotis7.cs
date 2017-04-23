using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Namu_darbai_1
{
   public class ClassUzduotis7
    {

        public void daugybosMet() {
            for (var a = 1; a <= 10; a++)
            {
                for (var b = 1; b <= 10; b++)
                {
                    Console.Write(a * b + "\t");
                }
                Console.Write("\n");
            }
        }

    }
}
