using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organ_transplant
{
    public class Organ
    {
        public string _OrganName { get; set; }

        public Organ(string organName)
        {
            _OrganName = organName;
        }
    }
}
