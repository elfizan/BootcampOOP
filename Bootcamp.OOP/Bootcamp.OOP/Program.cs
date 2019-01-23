using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp.OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Bangun2D panggil;

            Console.WriteLine("======= Perhitungan Luas =======");
            Console.WriteLine("1. Lingkaran");
            Console.WriteLine("2. Segitiga");
            Console.WriteLine("3. Persegi");
            Console.WriteLine("4. Persegi Panjang");
            Console.WriteLine("======= ============== =======");
            Console.Write("Pilihan mu : ");
            char s = Convert.ToChar(Console.ReadLine());
         
            switch (s){
                case '1':
                    Console.Write("Masukkan jari jari lingkaran: ");
                    double jari = Convert.ToDouble(Console.ReadLine());
                    panggil = new Lingkaran(jari);
                    panggil.CetakLuas("Lingkaran");
                    break;
                case '2':
                    Console.Write("Masukkan alas segitiga: ");
                    double alas=Convert.ToDouble(Console.ReadLine());
                    Console.Write("Masukkan tinggi segitiga: ");
                    double tinggi = Convert.ToDouble(Console.ReadLine());
                    panggil = new Segitiga(alas, tinggi);
                    panggil.CetakLuas("Segitiga");
                    break;
                case '3':
                    Console.Write("Masukkan sisi persegi: ");
                    double sisi = Convert.ToDouble(Console.ReadLine());
                    panggil = new Persegi(sisi);
                    panggil.CetakLuas("Persegi");
                    break;
                case '4':
                    Console.Write("Masukkan panjang persegi panjang: ");
                    double panjang = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Masukkan lebar persegi pannjang: ");
                    double lebar = Convert.ToDouble(Console.ReadLine());
                    panggil = new Persegi_Panjang(panjang, lebar);
                    panggil.CetakLuas("Persegi Panjang");
                    break;
      
                default:
                    Console.WriteLine("Your choise is not found, try again you latter GOOD BYE");
                    break;

            }
            Console.Read();
        }
    }
}
