using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Chili Cheese Fries Side
    /// </summary>
    public class ChiliCheeseFries : Side
    {
        /// <summary>
        /// The calories of the side based on the size
        /// </summary>
        public override uint Calories
        {
            get
            {

                switch (Size)
                {

                    case Size.Small:
                        return 433;
                    case Size.Medium:
                        return 524;
                    case Size.Large:
                        return 610;
                    default:
                        return 433;
                }
            }
        }
        /// <summary>
        /// The price of the side based on the size
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 1.99;
                    case Size.Medium:
                        return 2.99;
                    case Size.Large:
                        return 3.99;
                    default:
                        return 1.99;
                }
            }
        }
        /// <summary>
        /// Formats the toString to output a simplified description of the object
        /// </summary>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Size);
            sb.Append(" Chili Cheese Fries");
            return sb.ToString();
        }

    }
}
