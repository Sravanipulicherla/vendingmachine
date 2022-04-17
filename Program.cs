using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vendingmachine
{
	internal class Program
	{

		static void Main(string[] args)
		{
		
			
			vendingMachine Machine1 = new vendingMachine();

			while (true)
			{
				Console.WriteLine("Hello dear customer!!");
				Console.WriteLine("Enter 1 to Purchase");
				Console.WriteLine("Enter 2 to Showall");
				Console.WriteLine("Enter 3 to Add money");
				Console.WriteLine("Enter 4 to End Transaction");
				int choice = Convert.ToInt32(Console.ReadLine());
				switch (choice)
				{
					case 1:
						Machine1.Purchase();
						break;
					case 2:
						Machine1.Showall();
						break;
					case 3:
						Machine1.Addmoney();
						break;
					case 4:
						Machine1.Endtransaction();
						break;
					default:
						Console.WriteLine("Invalid option");
						break;
				}
			}
		}
	}
}
