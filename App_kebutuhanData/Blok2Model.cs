using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_kebutuhanData
{
    class Blok2Model
    {
        public List<int> tingkatKepuasan { get; set; }
        public List<int> tingkatKepentingan { get; set; }

        public string csvFormat()
        {
            string anu = "[";
            anu += string.Join(",", tingkatKepentingan);
            anu += "];[";
            anu += string.Join(",", tingkatKepuasan);
            anu += "]";
            return anu;
        }
    }
}
