using MongoDB.Bson.Serialization.Attributes;
using System.ComponentModel.DataAnnotations.Schema;

namespace simpleBankWithMongoDB.models
{
    public class Client
    {
        public string? Id { get; set; }
        public string Name { get; set; } 
    }
}
