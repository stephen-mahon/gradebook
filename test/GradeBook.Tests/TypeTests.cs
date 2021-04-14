using System;
using Xunit;

namespace GradeBook.Tests
{
    public class TypeTests
    {
        [Fact]
        public void ValueTypeAlsoPassByValue()
        {
            // arrange
            var x = GetInt();
            
            // act
            SetInt(ref x);
            
            // assert
            Assert.Equal(42, x);
        }
        private void SetInt(ref int x)
        {
            x = 42;
        }

        private int GetInt()
        {
            return 3;
        }

       [Fact]
        public void CSharpeCanPassByReference()
        {
            // arrange

            // act
            var book1 = GetBook("Book 1");
            GetBookSetName(ref book1, "New Name");

            // assert
            Assert.Equal("New Name", book1.Name);
        }

        private void GetBookSetName(ref Book book, string name)
        {
            book = new Book(name);
        }

        [Fact]
        public void CSharpePassByValue()
        {
            // arrange

            // act
            var book1 = GetBook("Book 1");
            GetBookSetName(book1, "New Name");

            // assert
            Assert.Equal("Book 1", book1.Name);
        }

        private void GetBookSetName(Book book, string name)
        {
            book = new Book(name);
        }

        [Fact]
        public void CanSetNameFromReference()
        {
            // arrange

            // act
            var book1 = GetBook("Book 1");
            SetName(book1, "New Name");

            // assert
            Assert.Equal("New Name", book1.Name);
        }

        private void SetName(Book book, string name)
        {
            book.Name = name;
        }

        [Fact]
        public void StringsBehavesLikeValueTypes()
        {
            //arrange
            string name = "Steve";

            //act
            var upper = MakeUppercase(name);

            //assert
            Assert.Equal("Steve", name);
            Assert.Equal("STEVE", upper);

        }
        private string MakeUppercase(string parameter)
        {
            return parameter.ToUpper();
        }

        [Fact]
        public void GetBookReturnsDifferentObjects()
        {
            // arrange

            // act
            var book1 = GetBook("Book 1");
            var book2 = GetBook("Book 2");

            // assert
            Assert.Equal("Book 1", book1.Name);
            Assert.Equal("Book 2", book2.Name);
            Assert.NotSame(book1, book2);
        }

        [Fact]
        public void TwoVariablesCanReferenceSameObject()
        {
            // arrange

            // act
            var book1 = GetBook("Book 1");
            var book2 = book1;

            // assert
            Assert.Same(book1, book2);

        }

        Book GetBook(string name)
        {
            return new Book(name);
        }
    }
}
