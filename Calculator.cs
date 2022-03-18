using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //judul console 
            Console.Title = "Aplikasi Calculator";

            Console.WriteLine("  ====================");
            Console.WriteLine("  |    Calculator    |");
            Console.WriteLine("  ====================\n");

            //menu calculator yang tersedia
            Console.WriteLine("-------------------------");
            Console.WriteLine("| Pilih menu calculator |");
            Console.WriteLine(" -----------------------");
            Console.WriteLine("|    1. Penjumlahan     |");
            Console.WriteLine("|    2. Pengurangan     |");
            Console.WriteLine("|    3. Perkalian       |");
            Console.WriteLine("|    4. Pembagian       |");
            Console.WriteLine("-------------------------\n");
			
			//perintah input menu nomor
            Console.Write("Input nomor menu [1..4] : ");
            int var = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            if (var == 1)
            {
                Console.Write(" Inputkan nilai a : ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.Write(" Inputkan nilai b : ");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\n Hasil penjumlahan {0} + {1} = {2}", a, b, Penjumlahan(a, b));
            } 
            else if (var == 2)
            {
                Console.Write(" Inputkan nilai a : ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.Write(" Inputkan nilai b : ");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\n Hasil Pengurangan {0} - {1} = {2}", a, b, Pengurangan(a, b));
            }
            else if (var == 3)
            {
                Console.Write(" Inputkan nilai a : ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.Write(" Inputkan nilai b : ");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\n Hasil Perkalian {0} * {1} = {2}", a, b, Perkalian(a, b));
            }
            else if (var == 4)
            {
                Console.Write(" Inputkan nilai a : ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.Write(" Inputkan nilai b : ");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\n Hasil Pembagian {0} / {1} = {2}", a, b, Pembagian(a, b));
            }
            else if (var > 4 ){
                Console.WriteLine(" Maaf menu yang anda pilih tidak tersedia");
            }
			
            Console.WriteLine("\n Tekan sembarang tombol untuk keluar");
            Console.ReadKey();
        }

        //method Penjumlahan, Pengurangan, Perkalian, dan Pembagian
        static int Penjumlahan(int a, int b)
        {
            return a + b;
        }
        static int Pengurangan(int a, int b)
        {
            return a - b;
        }
        static int Perkalian(int a, int b)
        {
            return a * b;
        }
        static int Pembagian(int a, int b)
        {
            return a / b;
        }
    }
}


