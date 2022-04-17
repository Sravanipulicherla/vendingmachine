using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vendingmachine
{
	
	internal class Products
    {
		//Declaring products variables in base class
		public int price = 10;
        public string info = "100ml";
        public string ID = "";
        public string usage = "you can drink it";
        public int count = 0;
		public string name = "";
	}

    class CoolDrinks : Products
    {
		public CoolDrinks(string aID, string aname, int aprice, string ainfo )
        {
			// constructor to assign varible names directly when Object created
			price = aprice;
			ID = aID;
			name = aname;
			info = ainfo;
	    }

	}
    class FruitJuice : Products
    {
		public FruitJuice(string aID, string aname, int aprice, string ainfo)
		{
			price = aprice;
			ID = aID;
			name = aname;
			info = ainfo;
		}
	}
    class Chocolates : Products
    {
		public Chocolates(string aID, string aname, int aprice, string ainfo)
		{
			price = aprice;
			ID = aID;
			name = aname;
			info = ainfo;
		}
	}

    class vendingMachine
    {
		int Moneypool = 0;
		int Bill = 0;
		private CoolDrinks pepsi; // Here cooldrink is a data type like "int"//
		private CoolDrinks fanta;
		private CoolDrinks sprite;
		private FruitJuice orange;
		private FruitJuice mango;
		private FruitJuice apple;
		private Chocolates lindor;
		private Chocolates merci;
		private Chocolates marabou;
		// Random rand;


		public vendingMachine() // Its a constructor syntax
        {
			// rand = new Random();
			pepsi = new CoolDrinks("A1", "pepsi", 10, "750ml"); // creating an object
			fanta = new CoolDrinks("A2", "fanta", 12, "500ml");
			sprite = new CoolDrinks("A3", "sprite", 15, "1l");
			orange = new FruitJuice("B1", "orange", 10, "200ml");
			mango = new FruitJuice("B2", "mango", 15, "150ml");
			apple = new FruitJuice("B3", "apple", 20, "250ml");
			lindor = new Chocolates("C1", "lindor", 15, "150ml");
			merci = new Chocolates("C2", "merci", 15, "150ml");
			marabou = new Chocolates("C3", "marabou", 15, "150ml");

		}

	public void Showall() // method
		{
			Console.WriteLine("Please select the product you like using its ID");
			Console.WriteLine("***Cooldrinks***");
			Show(pepsi); // function named show is called with the variable name pepsi. 
			Show(fanta);
			Show(sprite);
			Console.WriteLine("***Fruitjuice***");
			Show(orange);
			Show(mango);
			Show(apple);
			Console.WriteLine("***Chocolates***");
			Show(lindor);
			Show(merci);
			Show(marabou);
			Console.WriteLine($"Total amount Present in Bill = {Bill}");
			Console.WriteLine($"Total amount Present in moneyPool = {Moneypool}");
			Console.WriteLine("###########################################");			
		}

		public void Show(Products obj1)  //
        {
			Console.WriteLine($"ID: {obj1.ID} : Product : {obj1.name }, Price: {obj1.price}, Count: {obj1.count}");
		}

		public void Purchase()
		{
			if (Moneypool >= 10)
			{

				bool result = true;
				while (result)
				{
					Console.WriteLine("Please enter the product ID that you would like to purchase");
					string productchoice = Console.ReadLine();
					switch (productchoice)
					{
						case "A1":
							HandlePurchase(pepsi);
							break;
						case "A2":
							HandlePurchase(fanta);
							break;
						case "A3":
							HandlePurchase(sprite);
							break;
						case "B1":
							HandlePurchase(orange);
							break;
						case "B2":
							HandlePurchase(mango);
							break;
						case "B3":
							HandlePurchase(apple);
							break;
						case "C1":
							HandlePurchase(lindor);
							break;
						case "C2":
							HandlePurchase(merci);
							break;
						case "C3":
							HandlePurchase(marabou);
							break;
						default:
							break;
					}
					Console.WriteLine("Would you like to Purchase more? Yes/No");
					string choice2 = Console.ReadLine();
					if (choice2 != "Yes")
					{
						result = false;
						Endtransaction();
					}
				}
			}
			else
			{
				Addmoney();
			}						
		}

		public void Endtransaction()
		{
			int Remainingchange = Moneypool - Bill;
			Console.WriteLine("*****Please collect the remaining amount: " + Remainingchange);
			Console.WriteLine("Transaction Completed");
			Console.ReadLine();
			System.Environment.Exit(1);


		}
		public void Addmoney()
		{
			Console.WriteLine("Enter the amount in the denominations 1, 5, 10, 20, 50, 100, 500, 1000 only.");
			int Deposit = Int32.Parse(Console.ReadLine());
			if (Deposit == 1 || Deposit == 5 || Deposit == 10 || Deposit == 20 || Deposit == 50 || Deposit == 100 || Deposit == 500 || Deposit == 1000)
			{
				Moneypool = Moneypool + Deposit;
				if (Moneypool > 10)
				{
					Purchase();
				}
			}
			else
			{
				Console.WriteLine("****Invalid input**** #Please enter the amount in a valid denominations.");
				Addmoney();
			}
		}

		public void HandlePurchase(Products item) // HandlePurchase(pepsi)
		{
			if(Moneypool <= (Bill+item.price))
            {
				Console.WriteLine("Not Enough money in Moneypool");
				Addmoney();
            }
            else
            { 
				item.count++;
				Bill = Bill+item.price;

			}

		}

	}

}
