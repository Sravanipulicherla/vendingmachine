using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vendingmachine
{
    internal class Products
    {
        public string price = "10kr";
        public string info = "100ml";
        public string name = "";
        public string usage = "you can drink it";
        public int count = 0;
    }

    class CoolDrinks : Products
    { 

    }
    class FruitJuice : Products
    { 
    
    }
    class Chocolates : Products
    {
    
    }
}
