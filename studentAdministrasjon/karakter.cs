using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentAdministrasjon
{
    internal class karakter
    {
        public string Studentnavn;
        public string Fag1;
        public int Karakterverdi;

        public karakter(string studentnavn, string fag1, int karakterverdi)
        {
            Studentnavn = studentnavn;
            Fag1 = fag1;
            Karakterverdi = karakterverdi;
        }

        public void skrivUtInfoKarakter()
        {
            Console.WriteLine();
        }

        public void karakterInfo()
        {
            Console.WriteLine($"{Studentnavn} har karakteren {Karakterverdi} i {Fag1}");
        }
    }
    }

