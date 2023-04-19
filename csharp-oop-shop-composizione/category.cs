using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace category
{
    internal class Category
    {
        private string name;
        private string code;

        public Category(string categoryName) 
        { 
            this.name = categoryName;
            this.code = randomizeCode();
        }
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

        internal string randomizeCode()
        {
            Random random = new Random();
            double probabilityDistributor = Math.Pow(10, random.Next(1, 9));
            int intCode = random.Next(1, Convert.ToInt32(probabilityDistributor));
            string formattedCode = (intCode.ToString()).PadLeft(8, '0');
            return formattedCode;
        }

        public string categoryRappresentationString()
        {
            string categoryRappresentation = this.name + " " + this.code;
            return categoryRappresentation;
        }
    }
}
