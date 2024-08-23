using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_polymorphism.CSharp.Main
{
    public class Basket
    {
        List<IItem> items = new List<IItem>();

        public void add(IItem item)
        {
            this.items.Add(item);
        }

        //public void add(Drink drink)
        //{
        //    this.drinks.Add(drink);
        //}

        //public void add(Book book)
        //{
        //    this.books.Add(book);
        //}

        public int getTotal()
        {
            int total = 0;

            foreach (IItem item in this.items)
            {
                total += item.getPrice();
            }

            //foreach (Drink drink in this.drinks)
            //{
            //    total += drink.getPrice();
            //}

            //foreach (Book book in this.books)
            //{
            //    total += book.getPrice();
            //}

            return total;
        }

        public bool isInBasket(String name)
        {
            foreach (IItem item in this.items)
            {
                if (item.getName().Equals(name))
                {
                    return true;
                }
            }

            //foreach (Drink drink in this.drinks)
            //{
            //    if (drink.getName().Equals(name))
            //    {
            //        return true;
            //    }
            //}

            //foreach (Book book in this.books)
            //{
            //    if (book.getName().Equals(name))
            //    {
            //        return true;
            //    }
            //}

            return false;
        }
    }
}
