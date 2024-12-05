using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region double değişkenler
            //double number;
            //number = 2.34;
            //Console.WriteLine(number);

            //Console.WriteLine("***** Fiyat Listesi*****");
            //Console.WriteLine();

            //double ApplePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;

            //ApplePrice = 14.85;
            //orangePrice = 20.95;
            //strawberryPrice = 45;
            //potatoPrice = 9.74;
            //tomatoPrice = 6.88;

            //Console.WriteLine("----Elma Birim Fiyatı:" + ApplePrice +   "TL");
            //Console.WriteLine("----Portakal Birim Fiyatı:" + orangePrice + "TL");
            //Console.WriteLine("----Çilek Birim Fiyatı:" + strawberryPrice + "TL");      
            //Console.WriteLine("----Patates Birim Fiyatı:" + potatoPrice + "TL" );
            //Console.WriteLine("----Domates Birim Fiyatı:" + tomatoPrice + "TL");

            //double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;

            //appleGram = 1.245;
            //orangeGram = 2.650;
            //strawberryGram = 0.750;
            //potatoGram = 4.859;
            //tomatoGram = 3.745;

            //Console.WriteLine("-------------------------------------------");
            //Console.WriteLine();

            //double appleTotalPrice = ApplePrice * appleGram;
            //double orangeTotalPrice = orangePrice * orangeGram;
            //double strawberryTotalPrice= strawberryPrice*strawberryGram;
            //double potatoTotalPrice= potatoPrice*potatoGram;
            //double tomatoTotalPrice= tomatoPrice*tomatoGram;
            //Console.WriteLine("Elmanın Toplam Fiyatı:" +  appleTotalPrice + "TL");
            //Console.WriteLine("Portakalın Toplam Fiyatı:" +  orangeTotalPrice + "TL");
            //Console.WriteLine("Çileğin Toplam Fiyatı:" +  strawberryTotalPrice + "TL");
            //Console.WriteLine("Patatesin Toplam Fiyatı:" +  potatoTotalPrice + "TL");
            //Console.WriteLine("Domatesin Toplam Fiyatı:" +  tomatoTotalPrice + "TL");

            //double shoppingTotalPrice=appleTotalPrice+orangeTotalPrice+strawberryTotalPrice+potatoTotalPrice+tomatoTotalPrice;

            //Console.WriteLine("------------------------------------------");
            //Console.WriteLine();

            //Console.WriteLine("Toplam Tutar:" + shoppingTotalPrice + "TL");






            #endregion

            #region Char Değişkenler

            //char symbol;
            //symbol = 'a';
            //Console.WriteLine(symbol);

            #endregion

            #region Klavyeden Veri Girişleri String Değişkenleri

            //Console.WriteLine("**** CSharp Hava Yolları Yolcu Bilgisi ****");
            //Console.WriteLine();
            //string passengerName, passengerSurName, passengerDistrict, passengerCity, passengerAge, passengerIdentityNumber;
            //Console.Write("Yolcu Adı: ");
            //passengerName= Console.ReadLine();

            //Console.Write("Yolcu Soyadı: ");
            //passengerSurName= Console.ReadLine();

            //Console.Write("İlçe bilgisi: ");
            //passengerDistrict= Console.ReadLine();

            //Console.Write("Şehir Bilgisi: ");
            //passengerCity= Console.ReadLine();

            //Console.Write("Yolcu Yaş: ");
            //passengerAge= Console.ReadLine();

            //Console.Write("Yolcu TC Kimlik no: ");
            //passengerIdentityNumber= Console.ReadLine();

            //Console.WriteLine();
            //Console.WriteLine("---------------------");

            //Console.WriteLine("Yolcu kimlik no: " + passengerIdentityNumber  + " " + "-Yolcu Ad Soyad: "+passengerName + " " + passengerSurName+ " " + passengerDistrict + "/" + passengerCity + " " + passengerAge + " " );
            #endregion

            #region Klavyeden Tam Sayı Girişleri ve Dönüşümler

            //int shoesPrice, computerPrice, chairPrice, tvPrice;
            //shoesPrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12000;

            //int shoesCount, computerCount, chairCount, tvCount;
            //Console.Write("Lütfen aldığınız ayakkabı sayısını giriniz: ");
            //shoesCount=int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız bilgisayar sayısını giriniz: ");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız sandalye sayısını giriniz: ");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız televizyon sayısını giriniz: ");
            //tvCount = int.Parse(Console.ReadLine());

            //int totalPrice=shoesCount*shoesPrice+ computerCount*computerPrice+ chairCount*chairPrice + tvPrice*tvCount;

            //Console.WriteLine();
            //Console.WriteLine("Toplam ödemeniz gereken tutar:" + totalPrice + "TL");



            #endregion

            #region Klavyeden Ondalıklı Sayı İşlemleri

            //double exam1, exam2, exam3, result;
            //Console.Write("Lütfen 1.Sınav notunuzu giriniz: ");
            //exam1=double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2.Sınav notunuzu giriniz: ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 3.Sınav notunuzu giriniz: ");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine();
            //Console.WriteLine("Sınav ortalamanız:" + result);               



            #endregion

            #region Klavyeden Karakter Girişleri

            char gender;
            Console.Write("Lütfen Cinsiyet seçiniz: ");
            gender=char.Parse(Console.ReadLine());

            Console.WriteLine("Seçtiğiniz Cinsiyet: " + gender);


            #endregion
            Console.Read();
                
        }
    }
}
