using Configuration.DbSettings;
using Microsoft.Extensions.Logging;
using Models;
using MongoDB.Driver;

namespace Services
{

    interface IBookService 
    {
        Book Create();
    }
    class BookService: IBookService
    {
        private readonly IMongoCollection<Book> _book;

        public BookService (IDbSettings dbSettings) 
        {
            var client = new MongoClient(dbSettings.ConnectionString);
            var db = client.GetDatabase(dbSettings.DbName);
            _book = db.GetCollection<Book>("Book");
        }

        public Book Create()
        { 
            _book.InsertOneAsync()
        }
    }
} 