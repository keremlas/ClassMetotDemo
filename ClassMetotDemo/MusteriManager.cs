using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public static void Add(List<Musteri> musteriler, bool adding)
        {
            while (adding)
            {
                try
                {
                    var yeniMusteri = new Musteri();

                    yeniMusteri.Id = Util.Console.AskInt("Lütfen müşterinin ID'sini giriniz.");
                    yeniMusteri.adSoyad = Util.Console.Ask("Lütfen müşteri adı ve soyadını giriniz.");
                    musteriler.Add(yeniMusteri);

                    Console.WriteLine("\nMüşteri ID: {0}, Müşteri ad ve soyadı: {1}\n", yeniMusteri.Id, yeniMusteri.adSoyad);
                    Console.WriteLine("Yeni müşteri eklemek istiyor musunuz? e/h");
                    var addingAnswer = Console.ReadLine();
                    if (addingAnswer == "h")
                    {
                        adding = false;
                    }
                }
                catch(FormatException msg)
                {
                    Console.WriteLine(msg.Message);
                }
                catch (Exception)
                {

                    Console.WriteLine("Müşteri eklerken bir hata meydana geldi. Lütfen tekrar deneyiniz.");
                }
                
            }


        }
        public static void Delete(List<Musteri> musteriler, bool deleting)
        {
            while (deleting)
            {
                Console.WriteLine("Kaçıncı müşteriyi silmek istiyorsunuz?");
                int countAnswer = int.Parse(Console.ReadLine()) - 1;
                musteriler.Remove(musteriler[countAnswer]);
                Console.WriteLine("Başka müşteri silmek ister misiniz? e/h");
                var deletingAnswer = Console.ReadLine();

                if (deletingAnswer != "e")
                {
                    deleting = false;
                }
            }

        }
        public static void List(List<Musteri> musteriler)
        {
            foreach (var musteri in musteriler)
            {
                Console.WriteLine("------------------------------------------------------------------------");
                Console.WriteLine("Müşteri ID: {0}, Müşteri ad ve soyadı: {1}", musteri.Id, musteri.adSoyad);
                Console.WriteLine("------------------------------------------------------------------------");
            }
        }

    }
}
