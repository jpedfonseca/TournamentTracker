using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibary
{
    public static class GlobalConfig
    {
        public static List<IDataConnection> Connections { get; private set; }

        public static void InitializeConnections(bool database, bool textFiles)
        {
            if(database)
                {
                    //TODO - Set up the SQL Connector properly
                    SqlConnector sql = new SqlConnector();
                    Connections.Add(sql);
                }
            if(textFiles)
                {
                    //TODO - Create the text connection
                    TextConnection text = new TextConnection();
                    Connections.Add(text);
                }

        }
    }
}
