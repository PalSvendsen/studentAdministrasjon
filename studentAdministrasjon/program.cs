namespace studentAdministrasjon
{
    class Program
    {
        static void Main()
        {
            var Pål = new student("Pål", 34, "koding", 12644);
            var Kim = new student("Kim", 37, "Mekanisk", 66532);
            Pål.Fagliste.Add("Mattematikk");
            Pål.Fagliste.Add("Heimkunnskap");
            Pål.Fagliste.Add("Sjåfør");
            Pål.Karakterliste.Add(4);
            Pål.Karakterliste.Add(5);
            Pål.Karakterliste.Add(6);

            Kim.Fagliste.Add("Kassearbeider");
            Kim.Fagliste.Add("Uber");
            Kim.Fagliste.Add("Gym");
            Kim.Karakterliste.Add(3);
            Kim.Karakterliste.Add(4);
            Kim.Karakterliste.Add(3);

            var Pål1 = new fag(12345, "koding", 12345);
            var Kim1 = new fag(67890, "Mekanisk", 67890);

            var verdi = new karakter("Pål", "koding", 6);
            var verdi1 = new karakter("Kim", "Mekanisk", 5);

            Console.WriteLine("Informasjon om studentene: ");
            Console.WriteLine();
            Pål.skrivUtInfo(); 
            Pål1.skrivUtInfoFag();
            verdi.karakterInfo();
            Console.WriteLine();
            Kim.skrivUtInfo();
            Kim1.skrivUtInfoFag();
            verdi1.karakterInfo();
        }
    }
}