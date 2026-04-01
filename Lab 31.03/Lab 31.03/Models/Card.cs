using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_31._03.Models
{
    class Card
    {
        private static int _count = 0;
        public int Id { get; }
        public double Balance { get; set; }
        public double Bonus { get; set; }
        private string _cardNumber { get; set; }
        public string CardNumber
        {
            get
            {
                return _cardNumber;
            }
            set
            {
                if (value.Length==16 )
                {
                    _cardNumber = value;
                }
                else
                {
                    Console.WriteLine("Cart 16 reqemli olmalidir");
                }
            }
        }
        public EBank Bank;

        public bool WithDraw(double price)
        {
            if (price <= Balance)
            {
                Balance -= price;
                return true;
            }
            return false;
        }
        public Card()
        {
            _count++;
            Id = _count;
        }

    }
}
