using DR_Records.Models;

namespace DR_Records.Repos
{
    public class RecordsRepos
    {
        private static int _nextId = 1;

        public List<Record> Records = new List<Record>()
        {   
            new Record(_nextId++,"Enter Sandman","Metalica",180,2010),
            new Record(_nextId++, "Thriller","Michael Jackson", 70,2008),
            new Record(_nextId++, "Køb bananer","Kim Larsen", 60, 2007),
        };

        public List<Record> GetAll()
        { 
            List<Record> Result = new List<Record>(Records);
            return Result;
        }
        
    }
}
