using System;

namespace NurayMarhanKosuOdev
{
    class Program
    {
        static void Main(string[] args)
        {
            Login();

            decimal adimMesafe = AdımMesafeHesapla();
            int adimSayi = AdımSayisiniHesapla();
            int kosuSure = KosuSureSaat();
            int kosuSure2 = KosuSureDakika();           
            decimal kosuHesapla = KosuMesafeHesapla(adimMesafe, adimSayi, kosuSure, kosuSure2);
           

            Console.WriteLine("------------------------------------------------");
            Console.WriteLine($"Adım mesafeniz {adimMesafe} cm'dir.");
            Console.WriteLine($"Koşu mesafe uzunluğunuz {kosuHesapla} m'dir.");
            Console.WriteLine("------------------------------------------------");
            DakikadaAdimSayiHesapla();
            Logout();
        }

        private static void DakikadaAdimSayiHesapla()
        {
               
            while (true)
            {
                int sayac = 0, adimSayisi = 0;

                Console.WriteLine("Lütfen dakika da attığınız adım sayısını giriniz.");
                bool sayiMi = int.TryParse(Console.ReadLine(), out int adimSayi);
                if (sayiMi == false)
                {
                    Console.WriteLine("Hatalı giriş yaptınız adım sayısını pozitif tam sayı şeklinde giriniz.");

                }
                adimSayisi += adimSayisi + adimSayi;
                Console.WriteLine($"Dakikada attığınız adım sayısı {adimSayi}");
                sayac++;
                Console.WriteLine("Çıkmak için X'e basınız");
                char harf = Convert.ToChar(Console.ReadLine());
                if (harf=='X'|| harf=='x')
                {
                    break;
                }
               
            }
            
           
        }

        private static void Login()
        {
            Console.WriteLine("Hoşgeldiniz.\nBu program attığınız adım ve koşu sürenizi belirttiğinizde size toplam mesafeyi verecektir.(Metre cinsinden.)");
        }

        private static decimal AdımMesafeHesapla()
        {
            Console.WriteLine("Lütfen boyunuzu santimetre cinsinden giriniz: ");

            int boy;
            bool sayiMi = int.TryParse(Console.ReadLine(), out boy);

            if (!sayiMi)
            {
                Console.WriteLine("Hatalı giriş yaptınız.");
                return AdımMesafeHesapla();
            }
               
            decimal adimUzunlugu = (decimal)boy * (decimal)0.42; //Adım mesafesi Bir insanın boyunun yüzde 42'si kadar olduğu için bu şekilde hesaplama yapıldı.
            return adimUzunlugu;
        
        
        }

        private static int AdımSayisiniHesapla()
        {

            Console.WriteLine("Lütfen dakika da attığınız adım sayısını giriniz.");
            int adimSayi;
            bool sayiMi = int.TryParse(Console.ReadLine(), out adimSayi);
            if (sayiMi == false)
            {
                Console.WriteLine("Hatalı giriş yaptınız adım sayısını pozitif tam sayı şeklinde giriniz.");
                return AdımSayisiniHesapla();

            }
            return adimSayi;

        }


        private static int KosuSureDakika()
        {
            Console.WriteLine("Lütfen koşu sürenizi dakika cinsinden giriniz.");
            int kosuSüre1;
            bool sayiMi = int.TryParse(Console.ReadLine(), out kosuSüre1);
            if (sayiMi == false)
            {
                Console.WriteLine("Hatalı giriş yaptınız adım koşu sayısını pozitif tam sayı şeklinde giriniz.");
                return KosuSureSaat();
            }

            if (kosuSüre1 > 59 || kosuSüre1<=0)
            {
                Console.WriteLine("Hatalı giriş yaptınız adım koşu süresini 60 dan az ve 0 dan büyük giriniz.");
                return KosuSureDakika ();
            }

            return kosuSüre1;
        }

        private static int KosuSureSaat()
        {

            Console.WriteLine("Lütfen koşu sürenizi saat cinsinden giriniz.");
            int kosuSüre;
            bool sayiMi = int.TryParse(Console.ReadLine(), out kosuSüre);
            if (sayiMi == false)
            {
                Console.WriteLine("Hatalı giriş yaptınız koşu sürenizi saat cinsinden giriniz.");
                return KosuSureSaat ();
            }

            return kosuSüre;

        }

        private static decimal KosuMesafeHesapla(decimal adimMesafe, int adimSayi, int saat, int dakika)
        {
            return (adimMesafe * Convert.ToDecimal(adimSayi) * ((decimal)(saat * 60) + (decimal)(dakika)))/100;
        }


        private static void Logout()
        {
            Console.WriteLine("Bu uygulamayı kullandığınız için teşekkür eder ve iyi günler dileriz :)");
        }



    }
}
