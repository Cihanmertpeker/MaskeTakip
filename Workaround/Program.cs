using Business.Concrete;
using Entities.Concrete;
using System;

namespace Workaround
{
    public class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            person1.FirsName = "Cihan Mert";
            person1.LastName = "Peker";
            person1.NationalIdentity = 12345678910;
            person1.YearOfBirth = 1991;


            SelamVer(isim:"Cihan");
            SelamVer(isim:"Mert");
            SelamVer(isim:"Şerife");

           int sonuc = Topla(3);

            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);

            Console.ReadLine();
        }

        static void SelamVer(string isim="isimsiz")
        {
            Console.WriteLine("Merhaba " + isim);
        }

        static int Topla(int sayi1,int sayi2=10)
        {
            int sonuc = sayi1 + sayi2;
            Console.WriteLine("Toplam: " +sonuc);
            return sonuc;
        }

    }
}
