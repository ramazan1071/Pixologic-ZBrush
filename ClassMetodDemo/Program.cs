using System;

namespace ClassMetodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri = new Musteri();
            MusteriManager manager = new MusteriManager();
            manager.adding(musteri);

            manager.ranking(musteri);
            manager.deletion(musteri);
            manager.ranking(musteri);
        }
    }
}
