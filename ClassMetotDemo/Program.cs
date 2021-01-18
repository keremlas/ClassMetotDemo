using System;
using System.Collections.Generic;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            bool process = true; bool adding = true; bool deleting = true;
            var musteriler = new List<Musteri>();

            while (process)
            {
                Console.WriteLine("Hangi işlemi yapmak istiyorsunuz? müşteri ekle: 1/müşteri sil: 2/müşterileri listele: 3/çık: 4");
                var answer = Console.ReadLine();
                
                if (answer=="1")
                {
                    MusteriManager.Add(musteriler, adding);
                                                                                      
                }
                else if(answer=="2")
                {
                    MusteriManager.Delete(musteriler, deleting);
                                          
                }
                else if(answer=="3")
                {
                    MusteriManager.List(musteriler);
                }
                else if(answer=="4")
                {
                    process = false;
                }
                else
                {
                    Console.WriteLine("Lütfen geçerli bir değer giriniz.");
                }

            }
            
        }
    }

    

    
}
