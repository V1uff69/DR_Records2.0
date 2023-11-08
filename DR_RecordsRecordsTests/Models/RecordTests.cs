using Microsoft.VisualStudio.TestTools.UnitTesting;
using DR_Records.Models;
using DR_Records.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DR_Records.Models.Tests
{
    [TestClass()]
    public class RecordTests
    {
        //Objects
        private Record Record = new Record();
        private Record record = new Record { Id = 1, Title = "Test1", Artist = "TestX", Duration = 100, PublicationYear = 2000 };
        private Record recordTitleNull = new Record { Id = 1, Title = null, Artist = "TestX", Duration = 100, PublicationYear = 2000 };
        private Record recordArtistNull = new Record { Id = 1, Title = "Test1", Artist = null, Duration = 100, PublicationYear = 2000 };
        private Record recordDurationNull = new Record { Id = 1, Title = "Test1", Artist = "TestX", Duration = 0, PublicationYear = 2000 };
        private Record recordPublicationYearHigh = new Record { Id = 1, Title = "Test1", Artist = "TestX", Duration = 100, PublicationYear = 10000 };
        private Record recordPublicationYearLow = new Record { Id = 1, Title = "Test1", Artist = "TestX", Duration = 100, PublicationYear = 0 };

        [TestMethod()]
        public void ToStringTest()
        {
            string str = record.ToString();
            Assert.AreEqual($"Id: 1, Title: Test1, Artist: TestX, Duration: 100, Published: 2000", str);
        }


        [TestMethod()]
        public void ValidateTitleTest()
        {
            //Ac
            record.ValidateTitle();
            Assert.ThrowsException<ArgumentNullException>(() => recordTitleNull.ValidateTitle());
        }

        [TestMethod()]
        public void ValidateArtistTest()
        {
            record.ValidateArtist();
            Assert.ThrowsException<ArgumentNullException>(() => recordArtistNull.ValidateArtist());
        }

        [TestMethod()]
        public void ValidateDurationTest()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => recordDurationNull.ValidateDuration());
        }

        [TestMethod()]
        public void ValidatePublicationYearTest()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => recordPublicationYearHigh.ValidatePublicationYear());
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => recordPublicationYearLow.ValidatePublicationYear());
        }

        [TestMethod()]
        public void ValidationTest()
        {
            record.Validation();
            Assert.ThrowsException<ArgumentNullException>(() => recordTitleNull.ValidateTitle());
            Assert.ThrowsException<ArgumentNullException>(() => recordArtistNull.ValidateArtist());
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => recordDurationNull.ValidateDuration());
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => recordPublicationYearHigh.ValidatePublicationYear());
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => recordPublicationYearLow.ValidatePublicationYear());
        }
    }
}