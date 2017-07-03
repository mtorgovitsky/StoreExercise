using StoreExercise.Infra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StoreExercise.Models;

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
            catch (Exception)
            {
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
            catch (Exception)
            {
            }
            return true;
        }
    }
}
