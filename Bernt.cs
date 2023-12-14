using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Organ_transplant
{
    public class Bernt
    {
        public string _Name { get; set; }
        public List<Organ> _BerntsOrgan { get; set; }
        public Bernt(string name, List<Organ> berntsorgan)
        {
            _Name = name;
            _BerntsOrgan = berntsorgan;
        }

        public void berntinfo()
        {
            if (_BerntsOrgan.Any(organ => organ._OrganName.Equals($"Nyre(ødelagt)")))
            {
                Console.WriteLine($"{_Name} sin helse tilstand er dårlig");
                Console.WriteLine($"{_Name} trenger en ny nyre ");
                Console.WriteLine();
                BerntsOrganinfo();
                
            }
            else
            {
                Console.WriteLine("Bernt har fått ny nyre og han føler seg nå mye bedre!");
                BerntsOrganinfo();
            }

        }

      void BerntsOrganinfo()
        {
            Console.WriteLine($"organ informasjon til {_Name}:");
            Console.WriteLine(".............................");
            foreach (var organ in _BerntsOrgan)
            {
                Console.WriteLine(organ._OrganName);
            }
        }
    }
}
