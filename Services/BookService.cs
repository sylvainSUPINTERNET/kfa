using System.Threading.Tasks;
using Configuration.DbSettings;
using Microsoft.Extensions.Logging;
using Models;
using MongoDB.Driver;

namespace Services
{

    interface IBookService 
    {
        void Create();
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

        public async void Create()
        { 
            Book b1 = new Book();
            b1.Author = "Sylvain";
            b1.Title = "Le bookin";
            await _book.InsertOneAsync(b1);
        }
    }
} 