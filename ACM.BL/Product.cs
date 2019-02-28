using Acme.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Product : EntiyiBase
    {
        public Product()
        {

        }

        public Product(int productId)
        {
            this.ProductId = productId;
        }

        public Decimal? CurrentPrice { get; set; } //The '?' makes this propperty nullable
        public int ProductId { get; private set; }
        public string ProductDescription { get; set; }

        private string _ProductName;

        public string ProductName
        {
            get
            {
                return _ProductName.InsertSpaces();
            }

            set
            {
                _ProductName = value;
            }
        }


        /// <summary>
        /// Validates the product data
        /// </summary>
        /// <returns></returns>
        public override bool Validate()
        {
            bool isValid = true;

            if (string.IsNullOrWhiteSpace(ProductName))
            {
                isValid = false;
            }

            if (CurrentPrice == null)
            {
                isValid = false;
            }

            return isValid;
        }


        public override string ToString() //Overrides the ToString method of the base class (Object class)
        {
            return ProductName;
        }
    }
}
