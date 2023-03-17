using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders14KalitimInheritance
{
    internal class Urun : OrtakOzellikler
    {
        public String TeknikOzellikler { get; set; }
        public decimal Fiyat { get; set; }
        public int Kdv { get; set; }
        public int İskonto { get; set; }
    }
}
