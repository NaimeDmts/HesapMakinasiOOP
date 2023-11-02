using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPHesapMakinasi.Concrete
{
    public class KarakterKontrol
    {
        static double _sonuc = 0;
      
        static double _sayi = 0;
        static char operatorChar = ' ';
        public static double Kontrol(char operatorChar, double sayi)
        {
        _sonuc = sayi;
           if ( operatorChar == '+')
            {
                _sonuc = Islem.Toplam(_sonuc);
                Console.Clear();
                return _sonuc;
            }
            else if ( operatorChar == '-')
            {

                _sonuc = Islem.Cikarma(_sonuc);
                Console.Clear();
                return _sonuc;
            }
            else if (operatorChar == '*')
            {
                _sonuc = Islem.Carp(_sonuc);
                Console.Clear();
                return _sonuc;
            }
            else if (operatorChar == '/')
            {
                _sonuc = Islem.Bol(_sonuc);
                Console.Clear();
                return _sonuc;
            }
            else
            {
                return _sonuc;
            }
            return _sayi;
        }

    }
}
