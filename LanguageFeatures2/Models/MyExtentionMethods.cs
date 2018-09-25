using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LanguageFeatures2.Models
{
    public static class MyExtentionMethods
    {
        public static decimal TotalPrices(this IEnumerable<Product> productEnum)
        {
            decimal total = 0;
            foreach (Product prod in productEnum)
            {
                total += prod.Price;
            };
            return total;
        }
        public static IEnumerable<Product> FilterByCategory(this IEnumerable<Product> productEnum, string categoryParam)
        {
            foreach (Product prod in productEnum)
            {
                if (prod.Category == categoryParam)
                {
                    yield return prod;
                }
            }
        }
        public static IEnumerable<Product> Filter(
            this IEnumerable<Product> productEnum, Func<Product, bool> selectctorParam)
        {
            foreach (Product prod in productEnum)
            {
                if (selectctorParam(prod))
                {
                    yield return prod;
                }
            }
        }
    }
   
}