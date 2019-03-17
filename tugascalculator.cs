using System;
namespace kalkulator
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Console.Title = "APLIKASI KALKULATOR";
			
			double bil1, bil2, pilih;
			
			Console.WriteLine("Silahkan Pilih Menu Dibawah ini : ");
			Console.WriteLine();
			Console.WriteLine("1.penambahan");
			Console.WriteLine("2.pengurangan");
			Console.WriteLine("3.perkalian");
			Console.WriteLine("4.pembagian");
			Console.WriteLine();
			Console.Write("masukan pilihan [1 - 4] : ");
			pilih = int.Parse(Console.ReadLine());
			Console.WriteLine("\n");
			
			if(pilih == 1)
			{
				Console.Write("Masukan nilai a = ");
				bil1 = Convert.ToDouble(Console.ReadLine());
				Console.Write("Masukan nilai b = ");
				bil2 = Convert.ToDouble(Console.ReadLine());
				Console.WriteLine("Hasilnya adalah {0} + {1} = {2}", bil1, bil2, tambah(bil1, bil2)));
			}
			
			else if (pilih == 2)
				{
				Console.Write("Masukan nilai a = ");
				bil1 = Convert.ToDouble(Console.ReadLine());
				Console.Write("Masukan nilai b = ");
				bil2 = Convert.ToDouble(Console.ReadLine());
				Console.WriteLine("Hasilnya adalah {0} - {1} = {2}", bil1, bil2, kurang(bil1, bil2)));
			}
			else if (pilih == 3)
				{
				Console.Write("Masukan nilai a = ");
				bil1 = Convert.ToDouble(Console.ReadLine());
				Console.Write("Masukan nilai b = ");
				bil2 = Convert.ToDouble(Console.ReadLine());
				Console.WriteLine("Hasilnya adalah {0} * {1} = {2}", bil1, bil2, kali(bil1, bil2)));
			}
			else if (pilih == 4)
				{
				Console.Write("Masukan nilai a = ");
				bil1 = Convert.ToDouble(Console.ReadLine());
				Console.Write("Masukan nilai b = ");
				bil2 = Convert.ToDouble(Console.ReadLine());
				Console.WriteLine("Hasilnya adalah {0} / {1} = {2}", bil1, bil2, bagi(bil1, bil2)));
			}
			else
			{
				Console.WriteLine(maaf,menu yg anda pilih tidak tersedia");
			}
			
			}
			Static double tambah(double a, double b)
			{
				return a + b;
			}
			
			Static double kurang(double a, double b)
			{
				return a - b;
			}
			Static double kali(double a, double b)
			{
				return a * b;
			}
			Static double bagi(double a, double b)
			{
				return a / b;
			}
}				