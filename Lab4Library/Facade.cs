using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4Library
{
    public class BigMac
    {
        public void Prepare()
        {
            Console.WriteLine("Preparing your BigMac");
        }
    }
    public class Fries
    {
        public void Prepare()
        {
            Console.WriteLine("Roasting potatoes");
        }
    }
    public class Beverage
    {
        public void Prepare()
        {
            Console.WriteLine("Pouring a drink");
        }
    }
    public class Sauce
    {
        public void Preaper()
        {
            Console.WriteLine("Preparing a sauce");
        }
    }
    public class Wrapper
    {
        public void Wrap()
        {
            Console.WriteLine("Packing in burger paper");
        }
    }
    public class Napkin
    {
        public void Add()
        {
            Console.WriteLine("Adding a napkin");
        }
    }
    public class Bag
    {
        public void Pack()
        {
            Console.WriteLine("Packing food in a bag");
        }
    }
    public class Price
    {
        private double _price;
        private string _currency;
        public Price(double price, string currency)
        {
            _price = price;
            _currency = currency;
        }

        public void OrderInvoice()
        {
            Console.WriteLine($"Total price: {_price} {_currency}");
        }
    }
    public class BigMacMenu
    {
        private BigMac? bigMac;
        private Fries? fries;
        private Beverage? beverage;
        private Wrapper? wrapper;
        private Napkin? napkin;
        private Bag? bag;
        private Price? price;
        private Sauce? sauce;

        public BigMacMenu(BigMac? bigMac, Fries? fries, Beverage? beverage, Wrapper? wrapper, Napkin? napkin, Bag? bag, Price? price, Sauce? sauce)
        {
            this.bigMac = bigMac;
            this.fries = fries;
            this.beverage = beverage;
            this.wrapper = wrapper;
            this.napkin = napkin;
            this.bag = bag;
            this.price = price;
            this.sauce = sauce;
        }
        public void PrepareMenu()
        {
            Console.WriteLine("Start preparing the BigMac Menu:");
            bigMac?.Prepare();
            fries?.Prepare();
            beverage?.Prepare();
            sauce?.Preaper();
            wrapper?.Wrap();
            bag?.Pack();
            napkin?.Add();
            Console.WriteLine();
            price?.OrderInvoice();
        }
    }
}
