using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Namu_darbai_1
{
    public class uzduotis3
    {
        
        public void uzduotis () {
        var zmSkaicius = 10;
        var trukmeDienomis = 2;
        var skiriamiPinigai = 100;
        var islaidosMaistui = 10;
        var litrBenzino = 1.2;
        var kuroSan = 7;
        var kilometrai = 320;

            var surinktiPinigai = zmSkaicius * skiriamiPinigai;
            var pinigaiMaistui = (zmSkaicius * islaidosMaistui) * trukmeDienomis;
            var islaidosKurui = ((kilometrai * kuroSan) / 100) * litrBenzino;

            var kelionesIslaidos = (pinigaiMaistui + islaidosKurui);

           // Console.WriteLine(islaidosKurui);

            if (surinktiPinigai > kelionesIslaidos)
            {
                Console.WriteLine("Pinigu kelionei pakanka");
            }
            else {
                Console.WriteLine("Kelionei pinigu neuztenka");
            }
        }
    }
}
