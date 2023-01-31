namespace CsharpCourseOOP
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Notebook Asus = new Notebook();
            Asus.processor = "Intel";
            Asus.ozu = 32;
            Asus.videoCart = "Nvidia RTX3050Ti";
            Asus.screen = 16;
            Asus.battery = "90Wh";

            Phone Xiaomi = new Phone();
            Xiaomi.screen = 6;
            Xiaomi.battery = 5000;
            Xiaomi.memory = 128;
            Xiaomi.ozu = 4;

            TV Samsung = new TV();
            TV.screen = 55;
            TV.screenRaz = "1280x720";

            Magazine F5it = new Magazine();
            F5it.personal = 150;
            F5it.moneyInYear = 110000000;
            F5it.webSite = "www.f5it.ru";
            F5it.cityOfOffice = "Novosibirsk";
            F5it.cityOfOffice = "Moscow";

            Garnitura Lg = new Garnitura();
            Lg.withOutprovod = true;
            Lg.timeOfWorking = "1 week";
            Lg.color = "black";
            Lg.typeOfEarsIsIneer = false;
        }
    }

    internal class Garnitura
    {
        public bool typeOfEarsIsIneer { get; set; }
        public string color { get; set; }
        public string timeOfWorking { get; set; }
        public bool withOutprovod { get; set; }
    }

    internal class Magazine
    {
        public string cityOfOffice;
        public string webSite { get; set; }
        public int moneyInYear { get; set; }
        public int personal { get; set; }
    }

    internal class TV
    {
        public static string screenRaz { get; set; }
        public static int screen { get; set; }
    }

    internal class Phone
    {
        public int memory { get; set; }
        public int ozu { get; set; }
        public int screen { get; set; }
        public int battery { get; set; }
    }

    internal class Notebook
    {
        public int screen { get; set; }
        public string battery { get; set; }
        public string videoCart { get; set; }
        public int ozu { get; set; }
        public string processor { get; set; }
    }
}