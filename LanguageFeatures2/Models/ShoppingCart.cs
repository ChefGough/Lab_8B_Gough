using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections;

namespace LanguageFeatures2.Models
{
    public class ShoppingCart : IEnumerable<Product>
    {
        public List<Product> Products { get; set; }
        public IEnumerator<Product> GetEnumerator()
        {
            return Products.GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

    }
}