using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using studentAdministrasjon;

namespace studentAdministrasjon
{
    public class fag
    {
        public int Fagkode;
        public string Fagnavn;
        public int Studiepoeng;

        public fag(int fagkode, string fagnavn, int studiepoeng)
        {
            Fagkode = fagkode;
            Fagnavn = fagnavn;
            Studiepoeng = studiepoeng;
        }

        public void skrivUtInfoFag()
        {
            Console.WriteLine($"Og har {Fagnavn} som fag. Fagkoden er: {Fagkode} og studiepoeng er: {Studiepoeng}");
        }
    }
}
