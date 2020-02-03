using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the 
    /// </summary>
    public class ChiliCheeseFries : Side
    {

        public override uint calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 433;
                    case Size.Medium:
                        return 534;
                    case Size.Large:
                        return 610;
                }
            }
        }

    }
}
