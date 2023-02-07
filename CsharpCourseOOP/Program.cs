using System;
using System.Collections.Generic;

namespace CsharpCourseOOP
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var asus = new Notebook<int>();
            asus.processor = "Intel core i7 11800h";
            asus.ozu = 32;
            asus.videoCart = "Nvidia RTX3050Ti";
            asus.screen = 16;
            asus.battery = "90Wh";
            asus.price = 150000;

            var xiaomi = new Phone();
            xiaomi.screen = 6;
            xiaomi.battery = 5000;
            xiaomi.memory = 128;
            xiaomi.ozu = 4;
            xiaomi.price = 20000;

            var samsung = new Tv();
            samsung.screen = 55;
            samsung.screenRaz = "1280x720";
            samsung.price = 30000;

            var f5it = new Magazine();
            f5it.personal = 150;
            f5it.moneyInYear = 110000000;
            f5it.webSite = "www.f5it.ru";
            f5it.cityOfOffice = "Novosibirsk";
            f5it.cityOfOffice = "Moscow";

            var lg = new Garnitura();
            lg.withOutprovod = true;
            lg.timeOfWorking = "1 week";
            lg.color = "black";
            lg.typeOfEarsIsIneer = false;
            lg.price = 2500;

            int stockPrice1(int nbCount, int phoneCount, int tvCount, int earsCount)
            {
                int totalPrice = 0;
                int nbPrice = asus.price * nbCount;
                int phonePrice = xiaomi.price * phoneCount;
                int tvPrice = samsung.price * tvCount;
                int earsPrice = lg.price * earsCount;
                totalPrice = nbPrice + phonePrice + tvPrice + earsPrice;
                return totalPrice;
            }

            var firstStockAdding = stockPrice1(15, 45, 30, 50);
            Console.WriteLine($"На склад поступило товара на сумму {firstStockAdding} рублей");

            var acer = new Notebook<int>();
            acer.processor = "Intel core i5";
            acer.ozu = 8;
            acer.price = 74900;

            int stockPrice2(int nbCount)
            {
                int totalPrice = 0;
                int nbPrice = acer.price * nbCount;
                totalPrice += nbPrice;
                return totalPrice;
            }
            var secondStockAdding = stockPrice2(78);
            
            var allStockMoney = firstStockAdding + secondStockAdding;
            Console.WriteLine($"второе поступление товара на склад на сумму {secondStockAdding}. Теперь на складе товара в сумме на {allStockMoney}");
        }
    }

    public class Garnitura
    {
        public int price { set; get; }
        public bool typeOfEarsIsIneer { get; set; }
        public string color { get; set; }
        public string timeOfWorking { get; set; }
        public bool withOutprovod { get; set; }
    }

    public class Magazine
    {
        public string cityOfOffice { get; set; }
        public string webSite { get; set; }
        public int moneyInYear { get; set; }
        public int personal { get; set; }
    }

    public class Tv
    {
        public int price { get; set; }
        public string screenRaz { get; set; }
        public int screen { get; set; }
    }

    public class Phone
    {
        public int price { set; get; }
        public int memory { get; set; }
        public int ozu { get; set; }
        public int screen { get; set; }
        public int battery { get; set; }
    }

    public class Notebook<T>
    {
        public int price { get; set; }
        public T screen { get; set; }
        public string battery { get; set; }
        public string videoCart { get; set; }
        public int ozu { get; set; }
        public string processor { get; set; }
    }
  
}

