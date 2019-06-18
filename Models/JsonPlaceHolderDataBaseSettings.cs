namespace JsonClientApi.Models
{
     public class JSonPlaceHolderDatabaseSettings : IJsonPlaceHolderDatabaseSettings
    {
        public string CommentsCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }
    public interface IJsonPlaceHolderDatabaseSettings
    {
        string CommentsCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}