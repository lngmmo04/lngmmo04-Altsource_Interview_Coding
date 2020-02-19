using System;

namespace Altsource_Interview_Coding.Web
{
    abstract class Clothing
    {
        public abstract string Type { get; }
        public abstract double Price { get; set; }
        public abstract string Size { get; set; }
        public abstract string Color { get; set; }
    }

    class TShirt : Clothing
    {
        private readonly string _type;
        private double _price;
        private string _size;
        private string _color;

        public TShirt(double price, string size, string color)
        {
            _type = "T-Shirt";
            _price = price;
            _size = size;
            _color = color;
        }

        public override string Type
        {
            get { return _type; }
        }

        public override double Price
        {
            get { return _price; }
            set { _price = value; }
        }

        public override string Size
        {
            get { return _size; }
            set { _size = value; }
        }

        public override string Color
        {
            get { return _color; }
            set { _color = value; }
        }
    }

    class DressShirt : Clothing
    {
        private readonly string _type;
        private double _price;
        private string _size;
        private string _color;

        public DressShirt(double price, string size, string color)
        {
            _type = "Dress Shirt";
            _price = price;
            _size = size;
            _color = color;
        }

        public override string Type
        {
            get { return _type; }
        }

        public override double Price
        {
            get { return _price; }
            set { _price = value; }
        }

        public override string Size
        {
            get { return _size; }
            set { _size = value; }
        }

        public override string Color
        {
            get { return _color; }
            set { _color = value; }
        }
    }

    abstract class BuyingClothing
    {
        public abstract Clothing Buying();
    }

    abstract class SellingClothing
    {
        public abstract Clothing Selling();
    }

    class TShirtBuyingBehaviour : BuyingClothing
    {
        private double _price;
        private string _size;
        private string _color;

        public TShirtBuyingBehaviour(double price, string size, string color)
        {
            _price = price;
            _size = size;
            _color = color;
        }

        public override Clothing Buying()
        {
            return new TShirt(_price, _size, _color);
        }        
    }

    class TShirtSellingBehaviour : SellingClothing
    {
        private double _price;
        private string _size;
        private string _color;

        public TShirtSellingBehaviour(double price, string size, string color)
        {
            _price = price;
            _size = size;
            _color = color;
        }

        public override Clothing Selling()
        {
            return new TShirt(_price, _size, _color);
        }
    }

    class DressShirtBuyingBehaviour : BuyingClothing
    {
        private double _price;
        private string _size;
        private string _color;

        public DressShirtBuyingBehaviour(double price, string size, string color)
        {
            _price = price;
            _size = size;
            _color = color;
        }

        public override Clothing Buying()
        {
            return new DressShirt(_price, _size, _color);
        }        
    }

    class DressShirtSellingBehaviour : SellingClothing
    {
        private double _price;
        private string _size;
        private string _color;

        public DressShirtSellingBehaviour(double price, string size, string color)
        {
            _price = price;
            _size = size;
            _color = color;
        }

        public override Clothing Selling()
        {
            return new DressShirt(_price, _size, _color);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            BuyingClothing buy = null;
            SellingClothing sell = null;

            Console.Write("Do you want to buy or sell:");
            string behaviour = Console.ReadLine();

            if (behaviour.ToLower() == "buy")
            {
                Console.Write("Enter the clothing type you would like to buy: ");
                string buying = Console.ReadLine();

                switch (buying.ToLower())
                {
                    case "t-shirt":
                        buy = new TShirtBuyingBehaviour(6, "medium", "red");
                        break;
                    case "dress shirt":
                        buy = new DressShirtBuyingBehaviour(8, "small", "blue");
                        break;
                    default:
                        Console.WriteLine("Wrong Choice");
                        break;
                }

                Clothing clothing = buy.Buying();
                Console.WriteLine("\nBuying detail information : \n");
                Console.WriteLine("Type: {0}\nPrice: {1}\nSize: {2}\nColor: {3}",
                    clothing.Type, clothing.Price, clothing.Size, clothing.Color);
            }
            else if (behaviour.ToLower() == "sell")
            {
                Console.Write("Enter the clothing type you would like to sell: ");
                string selling = Console.ReadLine();

                switch (selling.ToLower())
                {
                    case "t-shirt":
                        sell = new TShirtSellingBehaviour(12, "small", "green");
                        break;
                    case "dress shirt":
                        sell = new DressShirtSellingBehaviour(20, "Medium", "yellow");
                        break;
                    default:
                        Console.WriteLine("Wrong Choice");
                        break;
                }

                Clothing clothing = sell.Selling();
                Console.WriteLine("\nSelling detail information : \n");
                Console.WriteLine("Type: {0}\nPrice: {1}\nSize: {2}\nColor: {3}",
                    clothing.Type, clothing.Price, clothing.Size, clothing.Color);
            }
           
            Console.ReadKey();            
        }
    }

    
}
