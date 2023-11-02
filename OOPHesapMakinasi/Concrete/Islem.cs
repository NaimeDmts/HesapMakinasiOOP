using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPHesapMakinasi.Concrete
{
    public class Islem
    {
        static double _sayi;
        public static double Toplam(double sayi)
        {
            return _sayi+= sayi;
        }
        public static double Cikarma(double sayi)
        {
            return _sayi-= sayi;
        }
        public static double Bol(double sayi)
        {
            return _sayi/= sayi;
        }
        public static double Carp(double sayi)
        {
            return _sayi*= sayi;
        }
    }
}
