using StoreExercise.Infra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StoreExercise.Models;
using System.Diagnostics;

namespace StoreExercise.ViewModels
{
    class DataManagerService : IDataManager
    {
        public List<Car> GetAll()
        {
            try
            {
                using (var db = new CarsContext())
                {
                    return db.Cars.Select(c => c).ToList();
                }
            }
            catch (Exception ex)
            {
                LogToDebug(ex);
            }

            return null;
        }

        public List<Car> GetShoppingCard()
        {
            try
            {
                using (var db = new CarsContext())
                {
                    return db.ShoppingCard.Select(c => c).ToList();
                }
            }
            catch (Exception ex)
            {
                LogToDebug(ex);
            }

            return null;
        }

        public bool Insert(Car newCar)
        {
            try
            {
                using (var db = new CarsContext())
                {
                    db.Cars.Add(newCar);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                LogToDebug(ex);
                return false;
            }

            return true;
        }

        public bool AddToCard(Car shopCar)
        {
            try
            {
                using (var db = new CarsContext())
                {
                    db.ShoppingCard.Add(shopCar);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                LogToDebug(ex);
                return false;
            }

            return true;
        }

        private void LogToDebug (Exception ex)
        {
            Debug.WriteLine(ex.Message);
        }
    }
}
