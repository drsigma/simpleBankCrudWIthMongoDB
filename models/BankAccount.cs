using MongoDB.Bson.Serialization.Attributes;
using System.ComponentModel.DataAnnotations.Schema;

namespace simpleBankWithMongoDB.models
{
    public class BankAccount
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string? Id { get; set; }

        [BsonElement("Client")]
        public Client Client { get; set; }

        [BsonElement("AccountManager")]
        public AccountManager AccountManager { get; set; }

        [BsonElement("Balance")]
        public double Balance { get; set; }
    }
}
