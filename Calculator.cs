using System;
namespace Calculator
{
	class Calculator
	{
		static void Main(string[]args)
		{
			int a=0;
			int b=0;
			
			Console.WriteLine("Pilih Menu Calculator\n");
			Console.WriteLine("1. Penambahan\n");
			Console.WriteLine("2. Pengurangan\n");
			Console.WriteLine("3. Perkalian\n");
			Console.WriteLine("4. Pembagian\n");
			
			Console.WriteLine("Inputkan nomor menu[1..4] :");
			int pilihan = int.Parse(Console.ReadLine());
				if(pilihan == 1){
					
					Console.WriteLine("Inputkan Nilai a = ");
					a=int.Parse(Console.ReadLine());
					Console.WriteLine("Inputkan Nilai b = ");
					b=int.Parse(Console.ReadLine());
					Console.WriteLine("Hasil Penambahan: {0}+{1}={2}", a, b, Penambahan(a, b) );
				}
				else if(pilihan == 2){
					Console.WriteLine("Inputkan Nilai a = ");
					a=int.Parse(Console.ReadLine());
					Console.WriteLine("Inputkan Nilai b = ");
					b=int.Parse(Console.ReadLine());
					Console.WriteLine("Hasil Pengurangan: {0}-{1}={2}", a, b, Pengurangan(a, b) );
				}
				else if(pilihan == 3){
					Console.WriteLine("Inputkan Nilai a = ");
					a=int.Parse(Console.ReadLine());
					Console.WriteLine("Inputkan Nilai b = ");
					b=int.Parse(Console.ReadLine());
					Console.WriteLine("Hasil Perkalian: {0}*{1}={2}", a, b, Perkalian(a, b) );
				}
				else if(pilihan == 4){
					Console.WriteLine("Inputkan Nilai a = ");
					a=int.Parse(Console.ReadLine());
					Console.WriteLine("Inputkan Nilai b = ");
					b=int.Parse(Console.ReadLine());
					Console.WriteLine("Hasil Pembagian: {0}/{1}={2}", a, b, Pembagian(a, b) );
				}
				else{
					Console.WriteLine("Maaf, menu yang anda pilih tidak tersedia");
				}
				
			
		
		Console.WriteLine("\nTekan sembarang key untuk keluar");
		Console.ReadKey();
		}
		
		static int Penambahan(int a, int b)
		{
			return a+b;
		}
		
		static int Pengurangan( int a, int b)
		{
			return a-b;
		}
		
		static int Perkalian( int a, int b)
		{
			return a*b;
		}
		
		static int Pembagian( int a, int b)
		{
			return a/b;
		}
	}
}