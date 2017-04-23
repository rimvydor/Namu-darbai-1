using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Namu_darbai_1
{
    class ClassUzduotis4
    {
        //Slidinėjimo varžybų trasą sudaro n ratų.Vieno rato ilgis yra m metrų.
        //    Sportininkas pirmą ratą įveikė per t1 sekundžių, antrąjį - per t2 sekundžių ir t.t.
        //    Parenkite programą, kuri apskaičiuotų, kokiu vidutiniu greičiu v čiuožė sportininkas
        //    ir kiek laiko t sugaišo įveikdamas trasą.
        int ratai = 4;
        int ratoIlgis = 500;


       public void trasaMet()
        {
            Console.WriteLine("Per kiek sekundziu iveikete pirma rata?");
            var pirmasRatas = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Per kiek sekundziu iveikete antra rata?");
            var antrasRatas = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Per kiek sekundziu iveikete trecia rata?");
            var treciasRatas = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Per kiek sekundziu iveikete ketvirta rata?");
            var ketvirtasRatas = Convert.ToDouble(Console.ReadLine());

            var sekundesTrasoje = pirmasRatas + antrasRatas + treciasRatas + ketvirtasRatas;
            var trasosIlgis = ratai * ratoIlgis;
            var vidGreitis = trasosIlgis / sekundesTrasoje;

            Console.WriteLine("Vidutinis greitis Trasoje: " + vidGreitis + "m/s.");
            Console.WriteLine("Trasoje sugaistos sekundes: " + sekundesTrasoje + "s.");
        }


    }
}
