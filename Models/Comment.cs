using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace JsonClientApi.Models
{
    public class Comment{
    
        public int postId {get; set;}
        
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string id {get; set;}
        
        [BsonElement("name")]        
        public string name {get; set;}
        
        [BsonElement("email")]
        public string email {get; set;}
        
        [BsonElement("body")]    
        public string body {get; set;}
    
    }
}