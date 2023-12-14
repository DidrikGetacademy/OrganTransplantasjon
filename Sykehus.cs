using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Organ_transplant
{
    public class Sykehus
    {
        private Kåre _kåre;
        private Bernt _bernt;

        public Sykehus(Bernt bernt, Kåre kåre)
        {
            _bernt = bernt;
            _kåre = kåre;
        }



        public void UtførTransplantasjon()
        {
           

            bool test = true;
            if (test)
            {

                Console.WriteLine("skriv inn navnet ditt");
                var name = Console.ReadLine();
                if (name == "Kåre")
                {
                    Console.WriteLine();
                    Console.WriteLine($"Godkjent underskrift {name}");
                    Console.WriteLine();
                    test = false;
                    int suksessrate = new Random().Next(0, 101);
                    Console.WriteLine();
                    Console.WriteLine("Informasjon om test:");
                    Console.WriteLine("........................................");
                    Console.WriteLine($"testen viser suksessrate: {suksessrate}");
                    if (suksessrate > 10 && test == false)
                    {
                        transplanterNyre();
                        Console.WriteLine($"transplantsasjonen var velykket! {_bernt._Name} har fått en ny nyre");
                    }
                    else if (test == true && suksessrate > 10)
                    {
                        Console.WriteLine("transplantasjon mislyktes. Suksessraten var ikke tilstrekkelig");
                    }
                }
                else if(name != "Kåre")
                {
                    Console.WriteLine("Test er ikke godkjent");
                   UtførTransplantasjon();
                   
                }
              
            }
    

            void transplanterNyre()
            {
                
                if (_kåre._kåresorgan.Any(organ => organ._OrganName.Equals("Nyre")))
                {
                    Organ nyre = _kåre._kåresorgan.First(organ => organ._OrganName.Equals("Nyre"));
                    _kåre._kåresorgan.Remove(nyre);
                  
                   Organ BerntSinOrgan = _bernt._BerntsOrgan.First(organ => organ._OrganName.Equals("Nyre(ødelagt)"));
                   _bernt._BerntsOrgan.Remove(BerntSinOrgan);
                   _bernt._BerntsOrgan.Add(nyre);
                }
            }


        
        }
    }
}
