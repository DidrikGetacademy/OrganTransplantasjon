using System.Runtime.InteropServices;

namespace Organ_transplant
{
    internal class Program
    {
       
     
        static void Main(string[] args)
        {

            Console.WriteLine("Velkommen til ullevål sykehus");
            Console.WriteLine("---------------------------------");
         




            Bernt bernt = new Bernt("Bernt", new List<Organ> { new Organ("Hjerte"), new Organ("Lunger"), new Organ("Nyre(ødelagt)"), new Organ("Nyre") });
            Kåre kåre = new Kåre("Kåre", new List<Organ> { new Organ("Hjerte"), new Organ("Lunger"), new Organ("Nyre"), new Organ("Nyre") });
            Sykehus sykehus = new Sykehus(bernt, kåre);


            Console.WriteLine();
            Console.WriteLine("Informasjon:");
            Console.WriteLine($" {bernt._Name}  har vært i en  akutt ulykke og er innlagt  ");
            bool program = true;
            while (program)
            {
                Console.WriteLine();
                Console.WriteLine("Meny:");
                Console.WriteLine($"1. sjekk {bernt._Name} sin helsestatus");
                Console.WriteLine($"2. sjekk {kåre._Name} sin helsestatus");
                Console.WriteLine("exit program");
                var input = Console.ReadLine();
                Console.WriteLine();



                switch (input)
            {
                    case "1":
                        bernt.berntinfo();
                        Console.WriteLine();
                        Console.WriteLine($"1. ta test for å se om du kan gi nyren din til {bernt._Name} ");
                        Console.WriteLine("2. returner til meny");
                        var testinput = Console.ReadLine();
                        if (testinput == "1") 
                        {
                            Console.WriteLine();
                           sykehus.UtførTransplantasjon();
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("returnerer til meny");
                            program = true;
                        }
                        break;

                    case "2":
                        kåre.OrganinfoKåre();
                        break;

                    case "4":
                        program = false;
                        break;

                    default:
                        Console.WriteLine("Wrong Answear");
                        break;
            }
            }
        }
    }
}





/*
 Oppgave: Organ transplant!
   Det har vært en akutt ulykke og Bernt ligger på sykehuset.
   
   Han trenger en ny Nyre!
   
   Heldigvis har fetteren hans Kåre to sunne Nyrer, og det er utført tester som tilsier at Kåre kan gi bort en av nyrene til Bernt og det vil være en høy suksessrate for overlevelse!
   
   Hjelp Bernt med å overleve!
   
   Finn ut hva vi kan lage som objekter, og hva man kan lage som metoder i dette tilfellet.
   
   Lag gjerne Consoll.WriteLine() - statements i koden slik at man ser hva som skjer!
 */