﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Rustlers Ribs entree
    /// </summary>
    public class RustlersRibs : Entree
    {

        /// <summary>
        /// The price of the ribs
        /// </summary>
        public override double Price
        {
            get
            {
                return 7.50;
            }
        }

        /// <summary>
        /// The calories of the ribs
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 894;
            }
        }
        /// <summary>
        /// Special instructions not included but tests require an empty test
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                return instructions;
            }
        }

    }
}
