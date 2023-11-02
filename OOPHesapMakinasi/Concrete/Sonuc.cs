using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPHesapMakinasi.Concrete
{
    public class Sonuc
    {
        static double _sonuc = 0;
        static double sayi = 0;
        static char _operator= ' ';
        static int sayac = 0;
        static int operatorsayac = 0;


        public static double Sonucu { get => _sonuc; set => _sonuc = value; }

        public static double SonucGoster(ConsoleKeyInfo keyInfo)
        {
            if (char.IsDigit(keyInfo.KeyChar))
            {
                sayi = 0;
                sayi = sayi * 10 + Convert.ToDouble(keyInfo.KeyChar.ToString());
                _sonuc= sayi;
                Console.Clear();
                sayac++;
                return sayi;
               
            }
            else if ( keyInfo.KeyChar == '+' || keyInfo.KeyChar == '-' || keyInfo.KeyChar == '*' || keyInfo.KeyChar == '/')
            {
                operatorsayac++;
                _operator = keyInfo.KeyChar;
                if(operatorsayac == 1)
                {
                    if (sayac > 1)
                    {
                        _sonuc = KarakterKontrol.Kontrol(_operator, sayi);

                    }
                    else
                    {
                        KarakterKontrol.Kontrol(_operator, sayi);
                    }

                }
                else
                {
                    Console.Clear();
                }




            }
            else if (keyInfo.KeyChar == '=' || keyInfo.Key == ConsoleKey.Enter) 
            {

                _sonuc = KarakterKontrol.Kontrol(_operator,sayi);
                operatorsayac = 0;
                return _sonuc ;
            }
            return _sonuc;
        }
      
    }
}
