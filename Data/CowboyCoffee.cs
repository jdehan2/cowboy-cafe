using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Cowboy Coffee drink
    /// </summary>
    public class CowboyCoffee : Drink
    {
        /// <summary>
        /// The calories of the drink based on the size
        /// </summary>
        public override uint Calories
        {
            get
            {

                switch (Size)
                {

                    case Size.Small:
                        return 3;
                    case Size.Medium:
                        return 5;
                    case Size.Large:
                        return 7;
                    default:
                        return 3;
                }
            }
        }
        /// <summary>
        /// The price of the drink based on the size
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 0.60;
                    case Size.Medium:
                        return 1.10;
                    case Size.Large:
                        return 1.60;
                    default:
                        return 0.60;
                }
            }
        }

        /// <summary>
        /// determines if the drink has room for cream
        /// </summary>
        public bool RoomForCream { get; set; } = false;

        /// <summary>
        /// determines if the drink has lemon
        /// </summary>
        public bool Decaf { get; set; } = false;

        /// <summary>
        /// determines if the drink has ice
        /// </summary>
        public override bool Ice { get; set; } = false;

        /// <summary>
        /// Special instructions for the preparation of the drink
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (Ice) instructions.Add("Add Ice");
                if (RoomForCream) instructions.Add("Room for Cream");

                return instructions;
            }
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Size);
            if (Decaf)
            {
                sb.Append("Decaf");
            }
           
            sb.Append(" Cowboy Coffee");
            return sb.ToString();
        }

    }
}
