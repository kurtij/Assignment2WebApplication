using System;
using Xunit;
using Assignment2WebApplication.Controllers;
using Assignment2WebApplication.Models;
using Assignment2WebApplication.Data;
using Microsoft.EntityFrameworkCore;

namespace UnitTestAssignment2WebApplication
{
    public class UnitTestRoom
    {
        [Fact]
        public void TestSuiteNumber()
        {
            Assert.Throws<InvalidOperationException>(
            () =>
            {
                Room r = new Room();
                r.SuiteNumber = -1;
            }
            );
        }

        [Fact]
        public void TestRoomNumber()
        {
            Assert.Throws<InvalidOperationException>(
            () =>
            {
                Room r = new Room();
                r.RoomNumber = -1;
            }
            );
        }

        [Fact]
        public void TestRentAmount()
        {
            Assert.Throws<InvalidOperationException>(
            () =>
            {
                Room r = new Room();
                r.RentAmount = -1;
            }
            );
        }

        [Fact]
        public void TestOccupied()
        {
            Assert.Throws<Exception>(
            () =>
            {
                Room r = new Room();
                r.Occupied = "NotYesOrNo";
            }
            );
        }

        [Fact]
        public void TestWindow()
        {
            Assert.Throws<Exception>(
            () =>
            {
                Room r = new Room();
                r.Window = "NotYesOrNo";
            }
            );
        }

        [Fact]
        public void TestClosit()
        {
            Assert.Throws<Exception>(
            () =>
            {
                Room r = new Room();
                r.Closit = "NotYesOrNo";
            }
            );
        }

        [Fact]
        public void TestBathroom()
        {
            Assert.Throws<Exception>(
            () =>
            {
                Room r = new Room();
                r.Bathroom = "NotYesOrNo";
            }
            );
        }

        public class DatabaseContext : DbContext
        {
            public DatabaseContext(DbContextOptions<DatabaseContext> options)
                : base(options)
            {
            }
        }

        [Fact]
        public void TestUpdateToDatabase()
        {
            var database = new DbContextOptionsBuilder<DatabaseContext>()
                .UseInMemoryDatabase(databaseName: "TestUpdateToDatabase")
                .Options;
            
            using (var context = new DatabaseContext(database))
            {
                var room = new Room();
                room.Bathroom = "yes";
                context.SaveChanges();
                String bathroom = room.Bathroom;
                Assert.Equal("yes", bathroom);
            }
        }
        
    }
}
