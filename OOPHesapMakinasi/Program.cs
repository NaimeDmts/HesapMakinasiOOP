using OOPHesapMakinasi.Concrete;

namespace OOPHesapMakinasi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HesapMakinasi hesapMakinasi = new HesapMakinasi();

            while (true)
            {
               
                
                
                
                ConsoleKeyInfo keyInfo = Console.ReadKey();


                Console.WriteLine(hesapMakinasi.SayiAl(keyInfo));
            
            }
        }

    }
}
