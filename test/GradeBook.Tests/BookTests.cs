using System;
using Xunit;

namespace GradeBook.Tests
{
    public class TypeTests
    {
        [Fact]
        public void CSharpIsPassByRef()
        {
            // arrange section
          var book1 = GetBook("Book 1");
          GetBookSetName(ref book1, "New Name");

          // act
          

          // assert
          Assert.Equal("New Name", book1.Name);
        
        }

        [Fact]
        public void CSharpIsPassByName()
        {
            // arrange section
          var book1 = GetBook("Book 1");
          GetBookSetName(book1, "New Name");

          // act
          

          // assert
          Assert.Equal("Book 1", book1.Name);
        
        }

        private void GetBookSetName(Book book, string name)
        {
          book = new Book(name);
          book.Name = name;
        }
        private void GetBookSetName(ref Book book, string name)
        {
          book = new Book(name);
          book.Name = name;
        }

        [Fact]
        public void CanSetNameFromReference()
        {
          // arrange section
          var book1 = GetBook("Book 1");
          SetName(book1, "New Name");
          // act
          
          // assert
          Assert.Equal("New Name", book1.Name);
          
        }

        private void SetName(Book book1, string name)
        {
          book1.Name = name;
        }

        [Fact] // attribut Fact is a piece of info attached to the next info
        public void GetBookReturnDifferentObjects()
        {
          // arrange section
          var book1 = GetBook("Book 1");
          var book2 = GetBook("Book 2");
          // act
          
          // assert
          Assert.Equal("Book 1", book1.Name);
          Assert.Equal("Book 2", book2.Name);
          Assert.NotSame(book1, book2);
          
        }

        [Fact] // attribut Fact is a piece of info attached to the next info
        public void TwoVarsCanReferenceSameObject()
        {
          // arrange section
          var book1 = GetBook("Book 1");
          var book2 = book1;
          // act
          
          // assert
          Assert.Equal("Book 1", book1.Name);
          Assert.Equal("Book 1", book2.Name);
          Assert.Same(book1, book2);
          // Object.ReferenceEquals verifies if the object are exactly the same
          Assert.True(Object.ReferenceEquals(book1, book2));
        }

        private Book GetBook(string name)
        {
          return new Book(name);
        }
  }
}

//returning object references