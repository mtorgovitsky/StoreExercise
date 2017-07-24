using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreExercise.Models
{
    public class ShoppingItem : Car
    {
        public ShoppingItem()
        {
            Model = base.Model;
            Year = base.Year;
            Price = base.Price;
        }
    }
}
