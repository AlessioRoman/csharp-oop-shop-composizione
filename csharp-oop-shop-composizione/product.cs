using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using category;

namespace product
{
    public class Product
    {
        //ATTRIBUTI
        private string code;
        private string name;
        private string description;
        private Category category;
        private float price;
        private float taxation;

        //COSTRUTTORE
        public Product(float price, string name = "", string description = "", string categoryName = "", float taxation = 0.22f) 
        {
            this.code = randomizeCode();
            this.name = name;
            this.description = description;
            this.category = new Category(categoryName);
            this.price = price;
            this.taxation = taxation;
        }


        //PROPRIETÀ
        public string Code
        {
            get
            {
                return this.code;
            }
        }
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public string Description
        {
            get
            {
                return this.description;
            }
            set
            {
                this.description = value;
            }
        }

        public float Price
        {
            get
            {
                return this.price;
            }
            set
            {
                this.price = value;
            }
        }

        public float Taxation
        {
            get
            {
                return this.taxation;
            }
            set
            {
                this.taxation = value;
            }
        }
        

        //METODI
        internal string randomizeCode()
        {
            Random random = new Random();
            double probabilityDistributor = Math.Pow(10, random.Next(1, 9));
            int intCode = random.Next(1, Convert.ToInt32(probabilityDistributor));
            string formattedCode = (intCode.ToString()).PadLeft(8, '0');
            return formattedCode;
        }

        public string getFullName()
        {
            return this.code + " " + this.name;
        }

        public float getTaxedPrice() 
        {
            return this.price + (this.price * this.taxation);
        }

        public string productRappresentationString() 
        {
            string productRappresentation =
            "-----------------------------------------------\n" +
            $"Product code: {this.code}\n" +
            $"Product name: {this.name}\n" +
            $"Product description: {this.description}\n" +
            $"Product category: {this.category.categoryRappresentationString()}\n" +
            $"Product price: {this.price}\n" +
            $"Taxes: {this.taxation}\n" +
            "-----------------------------------------------";

            return productRappresentation;
        }
    }
}