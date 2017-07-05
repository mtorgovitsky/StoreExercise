using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreExercise.Models
{
    public class Car : INotifyPropertyChanged
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public string Firm { get; set; }
        public int Year { get; set; }
        public int Price { get; set; }
        public string ImageURI { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnNotify(string memberName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(memberName));
        }
    }
}
