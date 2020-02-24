using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Texas Tea drink
    /// </summary>
    public class TexasTea : Drink
    {
        /// <summary>
        /// The calories of the drink based on the size
        /// </summary>
        public override uint Calories
        {
            get
            {
                if (Sweet)
                {
                    switch (Size)
                    {

                        case Size.Small:
                            return 10;
                        case Size.Medium:
                            return 22;
                        case Size.Large:
                            return 36;
                        default:
                            return 10;
                    }
                }
                else
                {
                    switch (Size)
                    {

                        case Size.Small:
                            return 5;
                        case Size.Medium:
                            return 11;
                        case Size.Large:
                            return 18;
                        default:
                            return 5;
                    }
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
                        return 1.00;
                    case Size.Medium:
                        return 1.50;
                    case Size.Large:
                        return 2.00;
                    default:
                        return 1.00;
                }
            }
        }

        /// <summary>
        /// determines if the drink is sweet
        /// </summary>
        public bool Sweet { get; set; } = true;

        /// <summary>
        /// determines if the drink has lemon
        /// </summary>
        public bool Lemon { get; set; } = false;

        /// <summary>
        /// determines if the drink has ice
        /// </summary>
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
                if (Lemon) instructions.Add("Add Lemon");

                return instructions;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Size);
            if (!Sweet)
            {
                sb.Append("Unsweetened");
            }
            sb.Append(" Texas Tea");
            return sb.ToString();
        }
    }
}
