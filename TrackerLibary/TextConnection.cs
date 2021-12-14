using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibary
{
    public class TextConnection : IDataConnection
    {
        public PrizeModel CreatePrize(PrizeModel model)
        {
            //TODO - Wire up the CreatePrize for text  files
            model.Id = 1;
            return model;
        }
    }
}
