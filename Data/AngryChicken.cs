﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Angry Chicken entree
    /// </summary>
    public class AngryChicken : Entree
    {


        private bool bread = true;
        /// <summary>
        /// If the entree includes bread
        /// </summary>
        public bool Bread
        {
            get { return bread; }
            set { bread = value; }
        }

        private bool pickle = true;
        /// <summary>
        /// If the entree includes a pickle
        /// </summary>
        public bool Pickle
        {
            get { return pickle; }
            set { pickle = value; }
        }

        // can be done with public bool Bread { get; set; } = true;

        /// <summary>
        /// The price of the entree
        /// </summary>
        public override double Price
        {
            get
            {
                return 5.99;
            }
        }

        /// <summary>
        /// The calories of the entree
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 190;
            }
        }


        /// <summary>
        /// Special instructions for the preparation of the entree
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!bread) instructions.Add("hold bread");
                if (!pickle) instructions.Add("hold pickle");
                
                return instructions;
            }
        }
        /// <summary>
        /// Formats the toString to output a simplified description of the object
        /// </summary>
        public override string ToString()
        {
            return "Angry Chicken";
        }

    }
}
