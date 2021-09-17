using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Models
{
    public class Book 
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id {get; set;}
        public string Title {get;   set;}
        
        public string Author {get; set;}

        public int EditedIn { get; set; }

        public DateTime Created {   get;    set;    }
        public DateTime UpdatedAt {   get;    set;    }


    }
}