using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetodDemo
{
    class MusteriManager
    {
        //Musteri ekleme, listeleme,silme gibi metotları simule ediniz.
        public void adding(Musteri musteri)
        {
            Console.WriteLine("Müşteri Adı Giriniz:");
            musteri.Name = Console.ReadLine();
            Console.WriteLine("Müşteri Soyadını Giriniz:");
            musteri.Surname = Console.ReadLine();
            Console.WriteLine("Müşterinin Yaşını Giriniz:");
            musteri.Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Müşteri Id Giriniz:");
            musteri.Id =Convert.ToInt32(Console.ReadLine());
            Musteri[] ekle = new Musteri[] { musteri };
        }
        public void deletion(Musteri musteri)
        {
            int sil;
            Console.WriteLine("Silinecek Musteri Id'sini Girin:");
            sil= Convert.ToInt32(Console.ReadLine());
            if (sil == musteri.Id)
            {
                musteri = null;
            }
            else
            {
                Console.WriteLine("Böyle bir Müşteri bulunmadı...");
            }
        }
        public void ranking(Musteri musteri)
        {
            Console.WriteLine("Müşterinin Adı:" + musteri.Name);
            Console.WriteLine("Müşterinin Soyadı:" + musteri.Surname);
            Console.WriteLine("Müşterinin Yaşı:" + musteri.Age);
            Console.WriteLine("Müşterinin Id:" + musteri.Id);
  
        }
    }
}
