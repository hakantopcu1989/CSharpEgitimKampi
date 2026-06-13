using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Yazdırma Komutları
            //Console.WriteLine("Merhaba Dünya");
            //Console.Write("Merhaba Hakan");

            //Console.WriteLine("***** Yemek Kategorileri *****");
            //Console.WriteLine();
            //Console.WriteLine("1-Çorbalar");
            //Console.WriteLine("2-Ana Yemekler");
            //Console.WriteLine("3-Soğuk Başlangıçlar");
            //Console.WriteLine("4-Salatalar");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("6-İçecekler");
            //Console.WriteLine();
            //Console.WriteLine("***** Yemek Kategorileri *****");

            #endregion

            #region String_Değişkenler

            //string
            //Değişken_türü değişken_adı;

            //string name;
            //name = "Hakan";
            //Console.Write(name);

            //string passangerName;
            //string passangerSurName;
            //string cusmtomerPhone;
            //string passangerEmail, district, city;

            //passangerName = "Hakan";
            //passangerSurName = "Topcu";
            //cusmtomerPhone = "222 333 00 22";
            //passangerEmail = "deneme@gmail.com";
            //district = "Esenyurt";
            //city = "İstanbul";

            //Console.WriteLine("***** Rezervasyon Kartı *****");
            //Console.WriteLine();
            //Console.WriteLine("-------------------------------");
            //Console.WriteLine("Müşteri: " + passangerName + " " + passangerSurName);
            //Console.WriteLine("İletişim: " + cusmtomerPhone);
            //Console.WriteLine("Email Adresi: " + passangerEmail);
            //Console.WriteLine("Adres: " + district + "/"+ city);
            //Console.WriteLine("-------------------------------") ;


            //passangerName = "İsimsiz";
            //passangerSurName = "Yok";
            //cusmtomerPhone = "+90 500 400 30 20";
            //district = "Kadıköy";
            //city = "İstanbul";
            //Console.WriteLine("-------------------------------");
            //Console.WriteLine("Müşteri: " + passangerName + " " + passangerSurName);
            //Console.WriteLine("İletişim: " + cusmtomerPhone);
            //Console.WriteLine("Email Adresi: " + passangerEmail);
            //Console.WriteLine("Adres: " + district + "/" + city);
            //Console.WriteLine("-------------------------------");

            #endregion


            #region int_Değişkenler

            // int

            int number = 74;
            Console.WriteLine(number);

            int hamburgerPrice = 300;
            int cokePrice = 35;
            int waterPrice = 10;
            int friesPrice = 50;
            int pizzaPrice = 250;
            int lemonadePrice = 30;

            Console.WriteLine("**** Restoran Menü Fiyatı ****");
            Console.WriteLine();
            Console.WriteLine("------Hamburger Fiyatı: " + hamburgerPrice + " TL ");
            Console.WriteLine("------Pizza Fiyatı: " + pizzaPrice + " TL ");
            Console.WriteLine("------Kola Fiyatı: " + cokePrice + " TL ");
            Console.WriteLine("------Limonata Fiyatı: " + lemonadePrice + " TL ");
            Console.WriteLine("------Kızartma Fiyatı: " + friesPrice + " TL ");
            Console.WriteLine("------Su Fiyatı: " + waterPrice + " TL ");
            Console.WriteLine();
            Console.WriteLine("**** Restoran Menü Fiyatı ****");

            Console.WriteLine();
            int hamburgerCount;
            int cokeCount;
            int waterCount;
            int friesCount;
            int pizzaCount;
            int lemonadeCount;

            int totalHamburgerPrice = 0;
            int totalCokePrice = 0;
            int totalWaterPrice;
            int totalFriesPrice = 0;
            int totalPizzaPrice= 0;
            int totalLemonadePrice;

            hamburgerCount = 3;
            cokeCount = 3;
            waterCount = 3;
            friesCount = 1;
            pizzaCount = 0;
            lemonadeCount = 0;

            totalHamburgerPrice = hamburgerCount * hamburgerPrice;
            totalCokePrice = cokeCount * cokePrice;
            totalWaterPrice = waterCount * waterPrice;
            totalFriesPrice = friesCount * friesPrice;
            totalPizzaPrice = pizzaCount * pizzaPrice;
            totalLemonadePrice = lemonadeCount * lemonadePrice;

            Console.WriteLine("------------------------------");
            Console.WriteLine("Hamburger Tutarı: " + totalHamburgerPrice + " TL");
            Console.WriteLine("Kola Tutarı: " + totalCokePrice + " TL");
            Console.WriteLine("Su Tutarı: " + totalWaterPrice + " TL");
            Console.WriteLine("Kızartma Tutarı: " + totalFriesPrice + " TL");
            Console.WriteLine("Pizza Tutarı: " + totalPizzaPrice + " TL");
            Console.WriteLine("Limonata Tutarı: " + totalLemonadePrice + " TL");

            Console.WriteLine();

            int totalPrice=totalCokePrice+ totalFriesPrice+ totalLemonadePrice+totalHamburgerPrice+totalPizzaPrice+totalWaterPrice;

            Console.WriteLine("Toplam Ödenecek Tutar: " + totalPrice + " TL");
            #endregion

            Console.Read();
        }
    }
}

https://www.youtube.com/watch?v=mTIMjg5Z1jY&list=PLKnjBHu2xXNPmFMvGKVHA_ijjrgUyNIXr&index=2

