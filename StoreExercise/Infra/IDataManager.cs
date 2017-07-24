using StoreExercise.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreExercise.Infra
{
    public interface IDataManager
    {
        List<Car> GetAll();

        bool Insert(Car newCar);

        List<ShoppingItem> GetShoppingCard();

        bool AddToCard(ShoppingItem newCar);

        bool RemoveFromCard(ShoppingItem carToRemove);
    }
}
