    public class AdventureWorksService : DataService<AdventureWorksLTEntities>
    {
        // This method is called only once to initialize service-wide policies.
        public static void InitializeService(IDataServiceConfiguration config)
        {
            config.SetEntitySetAccessRule("SalesOrderHeaders", EntitySetRights.All);
        }
    }