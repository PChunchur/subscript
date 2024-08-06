using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;    
using System.Text.Json.Serialization;

namespace MongoDb.Models;

public class Tasks{
    
    [BsonId]                                            // [BsonId] helps us to specify the primary key of the collection
    [BsonRepresentation(BsonType.ObjectId)]             // BsonRepresentation helps us to convert the string to ObjectId
    public string? Id { get; set; }  // Unique identifier for the subscription

        [BsonElement("username")]
        public string Username { get; set; } = null!;  // The name of the user who created the subscription

        [BsonElement("subscriptionName")]
        [JsonPropertyName("subscriptionName")]
        public string SubscriptionName { get; set; } = null!;  // The name of the subscription

        [BsonElement("type")]
        public string Type { get; set; } = null!;  // The type of subscription

        [BsonElement("status")]
        public string Status { get; set; } = null!;  // The status of the subscription (e.g., active, inactive)

        [BsonElement("amount")]
        public decimal Amount { get; set; }  // The cost of the subscription

        [BsonElement("reminderFrequency")]
        public string ReminderFrequency { get; set; } = null!;  // The frequency of reminders (e.g., monthly, quarterly)

        [BsonElement("reminderDate")]
        public DateTime? ReminderDate { get; set; }  // Optional: The specific date for the reminder, if applicable
}                       //Store the amount of the bill


