using System;
using System.Collections.Generic;
using System.Text;

using System.ComponentModel;

namespace CowboyCafe.Data
{
    public abstract class Entree : IOrderItem, INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// Gets the instructions of the entree
        /// </summary>
        public abstract List<string> SpecialInstructions { get;  }


        /// <summary>
        /// Gets the price of the entree
        /// </summary>
        public abstract double Price { get; }

        /// <summary>
        /// Gets the calories of the entree
        /// </summary>
        public abstract uint Calories { get; }


        protected void NotifyPropertyChanged(string propertyChanged)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyChanged));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
        }

    }
}
