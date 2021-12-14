using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary
{
    public class PrizeModel
    {
        /// <summary>
        /// The unique identifier for the prize
        /// </summary>
        public int Id {get; set; }
        public int PlaceNumber { get; set; }
        public string PlaceName { get; set; }
        public int PrizeAmount { get; set; }
        public double PrizePercentage { get; set; }

    }
}
