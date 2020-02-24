using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Jerked Soda drink
    /// </summary>
    public class JerkedSoda : Drink
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
                        return 110;
                    case Size.Medium:
                        return 146;
                    case Size.Large:
                        return 198;
                    default:
                        return 110;
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
                        return 1.59;
                    case Size.Medium:
                        return 2.10;
                    case Size.Large:
                        return 2.59;
                    default:
                        return 1.59;
                }
            }
        }
        /// <summary>
        /// determines the flavor of the drink
        /// </summary>
        public SodaFlavor Flavor { get; set; }


        public override bool Ice { get; set; } = true;

        /// <summary>
        /// Special instructions for the preparation of the drink
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!Ice) instructions.Add("Hold Ice");
             

                return instructions;
            }
        }



    }
}
