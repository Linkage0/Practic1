using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR1
{
    class Product
    {
        private string name;
        private string cipher;
        private int amount;

        public Product()
        {
            name = "";
            cipher = "";
            amount = 0;
        }

        public void ShowName()
        {
            Console.WriteLine("The current product name = " + name);
        }

        public void ShowCipher()
        {
            Console.WriteLine("The current product cipher = " + cipher);
        }

        public void ShowAmount()
        {
            Console.WriteLine("The current product amount = " + amount);
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public string Cipher
        {
            get
            {
                return cipher;
            }
            set
            {
                cipher = value;
            }
        }

        public int Amount
        {
            get
            {
                return amount;
            }
            set
            {
                amount = value;
            }
        }
    }
}
