using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vendingmachine
{
	internal class Program
	{
		CoolDrinks A1 = new CoolDrinks();
		 void Main(string[] args)
		{
			assign_data();
			int moneypost = 0;
			while (true)
			{
				Console.WriteLine("Hello dear customer!!");
				Console.WriteLine("Enter 1 to Purchase");
				Console.WriteLine("Enter 2 to Showall");
				Console.WriteLine("Enter 3 to Add money");
				Console.WriteLine("Enter 4 to End Transaction");
				int choice= Convert.ToInt32(Console.ReadLine());
				switch (choice)
				{
					case 1:
						Purchase();
						break;
					case 2:
						Showall();
						break;
					case 3:
						Addmoney();
						break;
					case 4:
						Endtransaction();
						break;
					default:
						Console.WriteLine("Invalid option");
						break;
				}
			}

		  void Showall()
			{
				Console.WriteLine("Please select the product you like using its ID");
				Console.WriteLine("***Cooldrinks***");
				Console.WriteLine("ID: A1 : Product : Pepsi , Price: 10kr");
				Console.WriteLine("ID: A2 : Product : Fanta , Price: 12kr");
				Console.WriteLine("ID: A3 : Product : Sprite, Price: 15kr");
				Console.WriteLine("***Fruitjuice***");
				Console.WriteLine("ID: B1 : Product : Orange, Price: 10kr");
				Console.WriteLine("ID: B2 : Product : Mango,  Price: 15kr");
				Console.WriteLine("ID: B3 : Product : Apple,  Price: 20kr");
				Console.WriteLine("***Chocolates***");
				Console.WriteLine("ID: C1 : Product : Lindor, Price: 15kr");
				Console.WriteLine("ID: C2 : Product : Merci,  Price: 15kr");
				Console.WriteLine("ID: C1 : Product : Marabou,Price: 15kr");
			}

			void Purchase()
			{
				Console.WriteLine("Please enter the product ID that you would like to purchase");
				string productchoice= Console.ReadLine();
				bool result = true;
				while (result) 
				{
					switch (productchoice)
					{
						case "A1":
							int amount= A1.price();
							break;
					}
				}              

			}

			void Endtransaction()
			{ }

			void Addmoney()
			{ }

		}
		public void assign_data()
		{
			

			A1.name = "pepsi";
			Console.WriteLine(A1.usage);
			Console.WriteLine(A1.price = "10kr");
			Console.WriteLine(A1.info = "750ml");
			CoolDrinks fanta = new CoolDrinks();
			Console.WriteLine(fanta.usage);
			Console.WriteLine(fanta.price = "12kr");
			Console.WriteLine(fanta.info = "500ml" );
			CoolDrinks sprite = new CoolDrinks();
			Console.WriteLine(sprite.usage);
			Console.WriteLine(sprite.price = "15kr");
			Console.WriteLine(sprite.info = "1l");

			FruitJuice orange= new FruitJuice();
			Console.WriteLine(orange.usage);
			Console.WriteLine(orange.price = "10kr");
			Console.WriteLine(orange.info = "200ml");
			FruitJuice mango = new FruitJuice();
			Console.WriteLine(mango.usage);
			Console.WriteLine(mango.price = "15kr");
			Console.WriteLine(mango.info = "150ml");
			FruitJuice apple = new FruitJuice();
			Console.WriteLine(apple.usage);
			Console.WriteLine(apple.price = "20kr");
			Console.WriteLine(apple.info = "250ml");


			Chocolates lindor = new Chocolates();
			Console.WriteLine(lindor.usage);
			Console.WriteLine(lindor.price = "15kr");
			Console.WriteLine(lindor.info = "150ml");
			Chocolates merci = new Chocolates();
			Console.WriteLine(merci.usage);
			Console.WriteLine(merci.price = "15kr");
			Console.WriteLine(merci.info = "150ml");
			Chocolates marabou = new Chocolates();
			Console.WriteLine(marabou.usage);
			Console.WriteLine(marabou.price = "15kr");
			Console.WriteLine(marabou.info = "150ml");

		}
	}
}
