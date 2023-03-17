using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders10ÖzgenlerProperties
{
    public class kisi
    {
        public string Adi;
        public string Soyadi;
        private int yas;
        private string doğumyeri;
        private string meslek;
        private double maas;
        public double Maas
        {
            get 
            {
                return maas;
            }
            set
            {
                if (value <= 8500) // en düşük maaşımız 8500 , eğer altında değer girilmişse  
                {
                    maas = 8500; // maas değerini 8500 yap
                }
                else maas = value;  // 8500 üzeri değer gönderilmişse bu değeri kabul et.
            }
        }
        public int Yas
        {
            get { return yas; }
            set
            {
                if (value >= 18) // eğer Yas özelliğine gelen değer 18 ve üzeriyse değri kabul et
                    yas = value;
                else yas = 18; // 18 den küçük ise değeri 18 yap
            }
        }
    }
}
