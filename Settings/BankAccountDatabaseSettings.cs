namespace simpleBankWithMongoDB.Settings
{
    public class BankAccountDatabaseSettings
    {
        public string ConnectionString { get; set; } = null;
        public string DatabaseName { get; set; } = null;
        public string BankAccountCollectionName { get; set; } = null;
        
    }
}
