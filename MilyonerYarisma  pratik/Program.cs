using System;

namespace MilyonerYarisma__pratik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Bu uygulam 3 sorudan ikisini bilenin kazandığı, 2 doğru veya 2 yanlış yapıldığında 3. soruya gerek olmadan sonuca varan bir yarışmadır.
            //Örnekte 2 şıkla yapılmıştı ben 3 şık yaparak biraz işimi zorlaştırmak istedim.
            //Koddaki string ifadelerin doğallığı ile uğraşırken verimlilik ve kendimi tekrar etme sıklığımın çok olduğunu fark ettim. ChatGPT'den destek alarak daha sade halini elde ettim
            //Ama öğrenme sürecinde görmediğim kısımları da içerdiği için onun yerine verimliliği mükemmel olmayan kendi kodumu paylaşmayı tercih ettim.
            // Kodu incelemenin yanında kendiniz de çalıştırırsanız sevinirim :)

            // Başka çözümleri de gördükten sonra daha verimlisi için tekrar uğraşacağım. :)



            string answer1 = "";
            string answer2 = "";
            string answer3 = "";


            Console.WriteLine("MERHABA YARIŞMAMIZA HOŞ GELDİNİZ!");
            Console.WriteLine("Öcelikle sizi tanıyalım: ");

            Console.Write("İsminiz: ");
            string name = Console.ReadLine();
            Console.Write("Soyadınız: ");
            string surname = Console.ReadLine();

            Console.WriteLine($"Teşekkürler, {name} yarışmamıza tekrar hoş geldin!!!!");
            Console.WriteLine();
            Console.WriteLine("Kuralları biliyor musun? (evet veya hayır şeklinde cevaplanacak)");
            string rulesResult = Console.ReadLine().ToLower();

            if (rulesResult == "evet")
            {
                Console.WriteLine();
                Console.WriteLine("Güzel, yine de senin için tekrr edelim; ");
                Console.WriteLine("Yarışmamız toplamda 3 sorudan oluşuyor, ve bu 3 sorudan ikisini doğru bilirsen büyük ödülü kazanıyorsun.");
                Console.WriteLine("En az ikisini bilemezsen maalesef seni eli boş uğurluyoruz. ");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Senin için hatırlatalım.");
                Console.WriteLine("Yarışmamız toplamda 3 sorudan oluşuyor, ve bu 3 sorudan ikisini doğru bilirsen büyük ödülü kazanıyorsun.");
                Console.WriteLine("En az ikisini bilemezsen maalesef seni eli boş uğurluyoruz. ");
            }

            int correctCounter = 0;
            Console.WriteLine();
            Console.WriteLine("Hazır olduğunu var sayarak ilk soruu soruyorum.");

            Console.WriteLine("Japonya'nın başkenti neresidir? \nA:) Tokyo \nB:) Kyoto \nC:) Osaka");
            answer1 = Console.ReadLine().ToLower();
            if (answer1 == "a")
            {
                correctCounter++;
                Console.WriteLine($"Tebrikler ilk sorunun cevabını doğru bildin {name}.");
                Console.WriteLine(correctCounter);
            }
            else
            {
                Console.WriteLine($"Maalesef bu soruyu doğru bilemedin {name}, sonraki iki soruda şansını denemek zorundasın.");
            }
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Öyleyse gelsin ikinci sorumuz.");
            Console.WriteLine();
            Console.WriteLine("Hangisi bir Türk yemeği değildir? \nA:) İçli Köfte \nB:) Lahmcun \nC:) Lazanya ");
            answer2 = Console.ReadLine().ToLower();
            if ((answer2 == "c") && (correctCounter == 1))
            {
                correctCounter++;
                Console.WriteLine($"Tebrikler ikinci soruya da doğru cevap vererek büyük ödülü kazanmaya hak kazanmış oldun {name}.");
                Console.WriteLine("İşte ödülün.");
                Console.WriteLine("**** 1.000.000.000 TL ****");
                Console.WriteLine("Güzel günlerde kullanmn dileğiyle.");
            }
            else if ((answer2 == "c") && (correctCounter == 0))
            {
                Console.WriteLine();
                correctCounter++;
                Console.WriteLine($"Tebrikler bu soruya doğru cevap vererek ödüle bir adım daha yaklaştın {name}.");
                Console.WriteLine("------------------------------------------------");
                Console.WriteLine("Öyleyse gelsin üçüncü ve son sorumuz.");
                Console.WriteLine();
                Console.WriteLine("Beş adedi 5 kuruştan 5 Yumurtanın fiyatı kaç kuruştur? \nA:) 25 Kuruş \nB:) 5 Kuruş \nC:) 15 Kuruş  ");
                answer3 = Console.ReadLine().ToLower();

                if ((answer3 == "b") && (correctCounter >= 1))
                {
                    correctCounter++;
                    Console.WriteLine($"Tebrikler ikinci doğru cevabını da vererek büyük ödülü kazanmaya hak kazanmış oldun {name}.");
                    Console.WriteLine("İşte ödülün.");
                    Console.WriteLine("**** 1.000.000.000 TL ****");
                    Console.WriteLine("Güzel günlerde kullanmn dileğiyle.");
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine($"Maalesef bu soruya da yanlış cevap vererek kazanma şansını tamamen kaybettin {name}.");
                    Console.WriteLine("Üzülerek seni eli boş uğurluyoruz. Umarız bundan sonra hayatta daha başarılı olursun. \n Görüşmek Üzere.");
                }


            }
            else if ((answer2 == "a") && (correctCounter == 0))
            {
                Console.WriteLine();
                correctCounter++;
                Console.WriteLine($"Maalesef bu soruya da yanlış cevap vererek kazanma şansını tamamen kaybettin {name}.");
                Console.WriteLine("Üzülerek seni eli boş uğurluyoruz. Umarız bundan sonra hayatta daha başarılı olursun. \nGörüşmek Üzere.");

            }
            else if ((answer2 == "a") && (correctCounter == 1))
            {
                Console.WriteLine();
                Console.WriteLine($"Maalesef bu soruya yanlış cevap verdin {name}, kaderimizi son soru belirleyecek.");
                Console.WriteLine("------------------------------------------------");
                Console.WriteLine("Öyleyse gelsin üçüncü ve son sorumuz.");
                Console.WriteLine();
                Console.WriteLine("Beş adedi 5 kuruştan 5 Yumurtanın fiyatı kaç kuruştur? \nA:) 25 Kuruş \nB:) 5 Kuruş \nC:) 15 Kuruş  ");
                answer3 = Console.ReadLine().ToLower();

                if ((answer3 == "b") && (correctCounter >= 1))
                {
                    correctCounter++;
                    Console.WriteLine($"Tebrikler ikinci doğru cevabını da vererek büyük ödülü kazanmaya hak kazanmış oldun {name}.");
                    Console.WriteLine("İşte ödülün.");
                    Console.WriteLine("**** 1.000.000.000 TL ****");
                    Console.WriteLine("Güzel günlerde kullanmn dileğiyle.");
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine($"Maalesef bu soruya da yanlış cevap vererek kazanma şansını tamamen kaybettin {name}.");
                    Console.WriteLine("Üzülerek seni eli boş uğurluyoruz. Umarız bundan sonra hayatta daha başarılı olursun. \n Görüşmek Üzere.");
                }

            }

            else if ((answer2 == "b") && (correctCounter == 0))
            {
                Console.WriteLine();
                correctCounter++;
                Console.WriteLine($"Maalesef bu soruya da yanlış cevap vererek kazanma şansını tamamen kaybettin {name}.");
                Console.WriteLine("Üzülerek seni eli boş uğurluyoruz. Umarız bundan sonra hayatta daha başarılı olursun. \nGörüşmek Üzere.");

            }
            else if ((answer2 == "b") && (correctCounter == 1))
            {
                Console.WriteLine();
                Console.WriteLine($"Maalesef bu soruya yanlış cevap verdin {name}, kaderimizi son soru belirleyecek.");
                Console.WriteLine("------------------------------------------------");
                Console.WriteLine("Öyleyse gelsin üçüncü ve son sorumuz.");
                Console.WriteLine();
                Console.WriteLine("Beş adedi 5 kuruştan 5 Yumurtanın fiyatı kaç kuruştur? \nA:) 25 Kuruş \nB:) 5 Kuruş \nC:) 15 Kuruş  ");
                answer3 = Console.ReadLine().ToLower();

                if ((answer3 == "b") && (correctCounter >= 1))
                {
                    correctCounter++;
                    Console.WriteLine($"Tebrikler ikinci doğru cevabını da vererek büyük ödülü kazanmaya hak kazanmış oldun {name}.");
                    Console.WriteLine("İşte ödülün.");
                    Console.WriteLine("**** 1.000.000.000 TL ****");
                    Console.WriteLine("Güzel günlerde kullanmn dileğiyle.");
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine($"Maalesef bu soruya da yanlış cevap vererek kazanma şansını tamamen kaybettin {name}.");
                    Console.WriteLine("Üzülerek seni eli boş uğurluyoruz. Umarız bundan sonra hayatta daha başarılı olursun. \nGörüşmek Üzere.");
                }

            }


            Console.Read();
        }
    }
}
