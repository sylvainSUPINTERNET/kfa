using System;
using System.Collections.Generic;
using Microsoft.Extensions.Logging;

namespace Configuration.DbSettings 

{
    public interface IDbSettings
    {
        string ConnectionString { get; set; }
        string DbName { get; set; }

        Dictionary<string, double> Collections {get; set;}

    }

    public class DbSettings : IDbSettings
    {
        public string ConnectionString { get; set;}
        public string DbName { get; set;}
        public Dictionary<string, double> Collections { get; set; }
    }
}