using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoletckimlikdogrulama
{
    class Program
    {
        static void Main(string[] args)
        {
            //tanımlamalar
            long tc;
            string ad, soyad;
            int yil;

            Console.WriteLine("Tc giriniz: ");      //Ekrana yazdırılacak olan kısım
            tc = long.Parse(Console.ReadLine());    //Ekrana yazılanı ReadLine komutu ile değişkene atama

            Console.WriteLine("Adınızı giriniz: ");
            ad = Console.ReadLine();

            Console.WriteLine("Soyadınızı giriniz: ");
            soyad = Console.ReadLine();

            Console.WriteLine("Dogum yılınızı giriniz:");
            yil = Convert.ToInt32(Console.ReadLine());

            //Referansı alma
            tckimlikdogrulama.KPSPublicSoapClient kontrol = new tckimlikdogrulama.KPSPublicSoapClient();

            //Durum değişkeni parametrelerin tamamı sağlanırsa true sağlanmazsa false değerini alır
            bool durum;
            durum = kontrol.TCKimlikNoDogrula(tc, ad, soyad, yil);      
            if (durum == true)
            {
                Console.WriteLine("Bu kimlikte birey bulunmaktadır.");      //Ekran çıktısı
            }
            else
            {
                Console.WriteLine("Bu bilgiler yanlıştır.");
            }
            Console.ReadLine();     //Ekranda tutma

        }
    }
}
