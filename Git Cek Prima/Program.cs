using System;

namespace Git_Cek_Prima
{
    class Program
    {
        static void Main(string[] args)
        {
			while(true)
            {
				Console.WriteLine("Cek Prima = ");
				int angka = Convert.ToInt32(Console.ReadLine());
				int faktor = 0;
				for (int i = 1; i <= angka; i++)
				{
					if (angka % i == 0)
					{
						faktor++;
					}
				}
				if (faktor == 2)
				{
					Console.WriteLine("Merupakan Bilangan Prima");
				}
				else
				{
					Console.WriteLine("Bukan Bilangan Prima");
				}

				Console.Write("Cek Prima Lagi? (y/n) ");
				string input = Console.ReadLine();
				while (input != "y" && input != "n")
				{
					Console.Write("Ulangi ? (y/n) ");
					input = Console.ReadLine();
				}

				if (input == "n")
				{
					break;
				}
			}
			
		}
    }
}
