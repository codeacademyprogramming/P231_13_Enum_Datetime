using System;
using System.Collections.Generic;
using System.Text;

namespace Homework
{
    internal class BravoMarket : IStore
    {
        private Product[] _products = new Product[0];
        public Product[] Products => _products;
        public Drink[] Drinks => _getDrinks();
        public Dairy[] Dairies => _getDairies();
        public int DairyProductCount => _getDairiesCount();
        public double AlcoholPercentLimit = 40;
        public int DairyProductCountLimit = 20;

        public void Add(Product product)
        {
            if (HasProductByNo(product.No))
                throw new Exception($"{product.No} nomreli product marketde var!");

            if(product is Drink)
            {
                Drink drink = (Drink)product;
                if (drink.AlcoholPercent > AlcoholPercentLimit)
                    throw new Exception($"Alkoqol limiti asildi");
            }
            else if(product is Dairy)
            {
                Dairy dairy = (Dairy)product;
                if (DairyProductCount >= DairyProductCountLimit)
                    throw new Exception($"Sud mehsulu say limiti asildi");
            }

            Array.Resize(ref _products, _products.Length + 1);
            _products[_products.Length - 1] = product;
        }

        public Product GetproductByNo(int no)
        {
            foreach (var item in _products)
            {
                if (item.No == no)
                    return item;
            }

            return null;
        }

        public bool HasProductByNo(int no)
        {
            foreach (var item in _products)
            {
                if (item.No == no)
                    return true;
            }
          
            return false;
        }
        private Drink[] _getDrinks()
        {
            Drink[] drinks = new Drink[0];

            foreach (var item in _products)
            {
                if(item is Drink)
                {
                    Drink drink = item as Drink;
                    Array.Resize(ref drinks, drinks.Length + 1);
                    drinks[drinks.Length - 1] = drink;
                }
            }

            return drinks;
        }

        private Dairy[] _getDairies()
        {
            Dairy[] dairies = new Dairy[0];

            foreach (var item in _products)
            {
                if (item is Dairy)
                {
                    Dairy dairy = item as Dairy;
                    Array.Resize(ref dairies, dairies.Length + 1);
                    dairies[dairies.Length - 1] = dairy;
                }
            }

            return dairies;
        }


        private int _getDairiesCount()
        {
            int count = 0;
            foreach (var item in _products)
            {
                if (item is Dairy)
                {
                    count++;
                }
            }

            return count;
        }



    }
}
