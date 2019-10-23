using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelTakip
{
    class Departman
    {
        public int Id { get; set; }
        public string Ad { get; set; }

        public override string ToString()
        {
            return Ad;
        }
    }
}
