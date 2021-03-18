using System;
using System.Collections.Generic;
using System.Data.Services;
using System.Data.Services.Common;
using System.Linq;
using System.ServiceModel.Web;
using System.Web;

namespace AdventureWorksService
{
    //<Snippet1>
    public class AdventureWorksService : DataService<AdventureWorksLTEntities>
    {
        // This method is called only once to initialize service-wide policies.
        public static void InitializeService(IDataServiceConfiguration config)
        {
            config.SetEntitySetAccessRule("SalesOrderHeaders", EntitySetRights.All);
        }
    }
    //</Snippet1>
}
