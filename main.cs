using System;

class SayiTahminOyunu
{
    static void Main(string[] args)
    {
        // Rastgele bir sayı oluşturucu
        Random rastgele = new Random();
        int tutulanSayi = rastgele.Next(1, 101); // 1 ile 100 arasında bir sayı tut
        int tahmin = 0;  // Oyuncunun tahminini saklayacak değişken
        int denemeSayisi = 0;  // Kaç deneme yapıldığını takip eden değişken

        Console.WriteLine("Sayı Tahmin Oyununa Hoşgeldiniz!");
        Console.WriteLine("1 ile 100 arasında bir sayı tuttum. Bakalım tahmin edebilecek misiniz?");

        // Doğru tahmin edilene kadar oyunu döngüde tut
        while (tahmin != tutulanSayi)
        {
            Console.Write("Tahmininizi girin: ");
            try
            {
                tahmin = Convert.ToInt32(Console.ReadLine());
                denemeSayisi++;

                if (tahmin < tutulanSayi)
                {
                    Console.WriteLine("Daha büyük bir sayı tahmin edin.");
                }
                else if (tahmin > tutulanSayi)
                {
                    Console.WriteLine("Daha küçük bir sayı tahmin edin.");
                }
                else
                {
                    Console.WriteLine($"Tebrikler, doğru tahmin! Tutulan sayı {tutulanSayi}. {denemeSayisi} denemede bildiniz.");
                }
            }
            catch
            {
                Console.WriteLine("Lütfen geçerli bir sayı girin.");
            }
        }
    }
}
