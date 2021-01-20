using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soruCevapUygulama
{
    class Program
    {
        static void Main(string[] args)
        {
            int puan = 0;
            char[] cevaplar = { 'c', 'e', 'c' ,'e','e','d','d','a','d','a'};

            //soruları cevapları dosyadan oku
            Encoding kod = Encoding.GetEncoding("windows-1254");
            StreamReader reader = new StreamReader("C:\\Users/onure/source/repos/ÖDEVLER/31.03.19/soruCevapUygulama/sorular.txt", kod);

            //soruların yazdırılması - cevapların kontrolü
            for (int i = 0; i < cevaplar.Length; i++)
            {
                Console.Clear();
                Console.WriteLine("Toplam Puan: " + puan);
                for (int j = 0; j < 8; j++)
                {
                    Console.WriteLine(reader.ReadLine());
                }

                here:
                try
                {
                    char verilenCevap = Convert.ToChar(Console.ReadLine());
                    if (verilenCevap == cevaplar[i])
                    {
                        Console.WriteLine("Doğru cevap verdiniz.  +10 puan");
                        puan += 10;
                    }
                    else
                    {
                        Console.WriteLine("Yanlış cevap verdiniz.  -5 puan");
                        Console.WriteLine("Doğru cevap: "+cevaplar[i]);
                        puan -= 5;
                    }
                    Console.WriteLine("Bir sonraki soruya geçmek için bir tuşa basın.");
                    Console.ReadLine();
                }
                catch
                {
                    Console.WriteLine("Lütfen yalnızca harf giriniz.");
                    goto here;
                }

                //son olark alınan puanı göster
                Console.Clear();
                Console.WriteLine("///////////////////////////////////////////////////////");
                Console.WriteLine("\tTest bitmiştir.\n\tAldığınız Puan: " + puan);
                Console.WriteLine("///////////////////////////////////////////////////////");
            }
        }
    }
}
