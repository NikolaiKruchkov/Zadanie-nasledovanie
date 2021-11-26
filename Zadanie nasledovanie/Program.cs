using System;

namespace Zadanie_nasledovanie
{
    class Program
    {
        static void Main(string[] args)
        {
            Building zdanie1 = new Building("Первое шоссе 1", 27, 45, 18);
            MultiBuilding zdanie2 = new MultiBuilding("Первое шоссе 2", 35, 12, 21,5);
            zdanie1.Print();
            zdanie2.Print();

        }
    }

    class Building
    {
        public string address {get; set;}
        public double dlina { get; set; }
        public double shirina { get; set; }
        public double visota { get; set; }
        public void Print()
        {
            Console.WriteLine("Адрес здания: {0}", address);
            Console.WriteLine("Длина здания: {0:f2}", dlina);
            Console.WriteLine("Ширина здания: {0:f2}", shirina);
            Console.WriteLine("Высота здания: {0:f2}", visota);
        }
        public Building(string address, double dlina, double shirina, double visota)
        {
            this.address = address;
            this.dlina = dlina;
            this.shirina = shirina;
            this.visota = visota;
        }
             
    }
    sealed class MultiBuilding: Building
    {
        public int etagnost { get; set;}
        public void Print()
        {
            base.Print();
            Console.WriteLine("Этажность здания: {0}", etagnost);
        }
        public MultiBuilding(string address, double dlina, double shirina, double visota, int etagnost)
            :base (address, dlina,shirina, visota)
        {
            this.etagnost = etagnost;
        }

    }




}
