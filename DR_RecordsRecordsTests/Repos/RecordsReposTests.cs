using Microsoft.VisualStudio.TestTools.UnitTesting;
using DR_Records.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DR_Records.Models;

namespace DR_Records.Repos.Tests
{
    [TestClass()]
    public class RecordsReposTests
    {
        private RecordsRepos _repo;
        [TestInitialize]
        public void Init()
        {
            _repo = new RecordsRepos();
        }

        [TestMethod()]
        public void GetAllTest()
        {
            // act
            IEnumerable<Record> result = _repo.GetAll();

            //assert
            Assert.IsNotNull(result);
            Assert.AreEqual(3, result.Count()); //expected number of books.
        }
    }
}