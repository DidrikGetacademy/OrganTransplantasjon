using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organ_transplant
{
    public class Kåre
    {
        public string _Name { get; set; }
        public List<Organ> _kåresorgan { get; set; }
        public Kåre(string name, List<Organ> kåresorgan)
        {
            _Name = name;
            _kåresorgan = kåresorgan;

        }

        
        public  void OrganinfoKåre()
        {
         Console.WriteLine($"organer til {_Name}");
            foreach (var Organ in _kåresorgan)

            {
                Console.WriteLine(Organ._OrganName);
            }


        }
    }
}
