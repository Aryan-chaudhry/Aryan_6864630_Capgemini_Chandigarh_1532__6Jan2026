using System;
using System.Collections.Generic;
using System.Text;
using LibraryManagementSystem;
using NUnit.Framework;

namespace LibraryTesting.Tests
{
    [TestFixture]
    internal class LibraryTest
    {
        private Library library;

        [SetUp]

        public void SetUp()
        {
            library = new Library();
            library.Addbooks("C# Books", 2);
        }

        [Test]

        public void AddBook_NewBook_IncreaseCount()
        {
            // Arrange
            string title = "ASP.NET Core";
            int quantity = 3;

            // Act
            library.Addbooks(title, quantity);

            // Assert
            Assert.AreEqual(2, library.GetBookCount(title));
        }
    }
}
