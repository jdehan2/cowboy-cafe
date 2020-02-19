﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
/// <summary>
/// A base class representing a drink
/// </summary>
{
    public abstract class Drink
    {

        /// <summary>
        /// Gets the size of the drink
        /// </summary>
        public virtual Size Size { get; set; } = Size.Small;

        /// <summary>
        /// Gets the price of the drink
        /// </summary>
        public abstract double Price { get; }

        /// <summary>
        /// Gets the calories of the drink
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// Determines if the drink has ice
        /// </summary>
        public bool Ice { get; set; } = true;


        /// <summary>
        /// Gets the instructions of the drink
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }

    }
}