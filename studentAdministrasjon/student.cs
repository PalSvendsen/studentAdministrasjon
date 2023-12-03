using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentAdministrasjon
{
    public class student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Studieprogram { get; set; }
        public int StudentID { get; set; }
        public List<string> Fagliste { get; set; }
        public List<int> Karakterliste { get; set; }

        public student(string name, int age, string studieprogram, int studentId)
        {
            Name = name;
            Age = age;
            Studieprogram = studieprogram;
            StudentID = studentId;
            Fagliste = new List<string>();
            Karakterliste = new List<int>();
        }

        public void skrivUtInfo()
        {
            Console.WriteLine($"{Name} er {Age}, og studerer {Studieprogram} og student ID er: {StudentID}");

            for (int i = 0; i < Fagliste.Count; i++)
            {
                Console.WriteLine($"Og tar ekstra faget {Fagliste[i]} med karakter {Karakterliste[i]}");
            }
            double Gjennomsnitt = GjennomsnittsKarakter();
            Console.WriteLine($"Gjennomsnittskarakter: {Gjennomsnitt}");
        }

        public double GjennomsnittsKarakter()
        {
            double sum = 0;
            foreach (var karakter in Karakterliste)
            {
                sum += karakter;
            }
            double Gjennomsnitt = sum / Karakterliste.Count;
            return Gjennomsnitt;
        }
    }
}
