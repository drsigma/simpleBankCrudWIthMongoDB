using Microsoft.Extensions.Options;
using MongoDB.Driver;
using simpleBankWithMongoDB.models;
using simpleBankWithMongoDB.Settings;


namespace simpleBankWithMongoDB.services
{
    public class BankAccountServices
    {
        private readonly IMongoCollection<BankAccount> _bankingAccountCollection;

        public BankAccountServices(IOptions<BankAccountDatabaseSettings> bankingAccountServices)
        {
            var mongoClient = new MongoClient(bankingAccountServices.Value.ConnectionString);
            var mongoDatabase = mongoClient.GetDatabase(bankingAccountServices.Value.DatabaseName);

            _bankingAccountCollection = mongoDatabase.GetCollection<BankAccount>(bankingAccountServices.Value.BankAccountCollectionName);

        }

        public async Task<List<BankAccount>> GetAsync() => 
            await _bankingAccountCollection.Find(x => true ).ToListAsync();

        public async Task<BankAccount> GetAsync(string id) =>
            await _bankingAccountCollection.Find(x => x.Id == id).FirstOrDefaultAsync();

        public async Task CreateAsync(BankAccount bankAccount) =>
            await _bankingAccountCollection.InsertOneAsync(bankAccount);
        
        public async Task UpdateAsync(string id, BankAccount bankAccount) =>
            await _bankingAccountCollection.ReplaceOneAsync(x=> x.Id == id, bankAccount);

        public async Task RemoveAsync (string id) =>
            await _bankingAccountCollection.DeleteOneAsync(x => x.Id == id);          
    }
}
