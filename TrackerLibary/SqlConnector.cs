using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibary
{
    public class SqlConnector : IDataConnection
    {
        
        public PrizeModel CreatePrize(PrizeModel model)
        {
            //TODO - Make the CreatePrize method actually save to the database
            
            model.Id = 1;
            return model;
        }
    }
}
