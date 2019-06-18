using MongoDB.Driver;
using JsonClientApi.Models;
using System.Collections.Generic;
namespace JsonClientApi.Services
{

    public class CommentService{

        private readonly IMongoCollection<Comment> _comments;

        public CommentService(IJsonPlaceHolderDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _comments = database.GetCollection<Comment>(settings.CommentsCollectionName);
        }

        public List<Comment> Get() =>
            _comments.Find(Comment => true).ToList();

        public Comment Get(string id) =>
            _comments.Find<Comment>(comment => comment.id == id).FirstOrDefault(); 

        public Comment Create(Comment comment)
        {
            _comments.InsertOne(comment);
            return comment;
        } 

        public void Update(string id, Comment commentIn) =>
            _comments.ReplaceOne(comment => comment.id == id, commentIn);

        public void Remove(Comment commentIn) =>
            _comments.DeleteOne(comment => comment.id == commentIn.id);

        public void Remove(string id) => 
            _comments.DeleteOne(comment => comment.id == id);              

    }
}