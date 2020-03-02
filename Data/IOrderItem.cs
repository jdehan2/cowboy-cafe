using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public interface IOrderItem
    {
        /// <summary>
        /// Gets the price of the entree
        /// </summary>
        public double Price { get; }

        /// <summary>
        /// Gets the instructions of the entree
        /// </summary>
        public List<string> SpecialInstructions { get; }


    }
}
