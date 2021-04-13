using System;
using Xunit;

namespace GradeBook.Tests
{
    public class BookTests
    {
        [Fact] // attribut Fact is a piece of info attached to the next info
        public void BookCalculateAnAverageGrade()
        {
          // arrange section
          var book = new Book("");
          book.AddGrade(89.1);
          book.AddGrade(97.1);
          book.AddGrade(95.4);

          // act
          var result = book.GetStatistics();

          // assert
          Assert.Equal(93.9, result.Average,1);
          Assert.Equal(97.1, result.High,1);
          Assert.Equal(89.1, result.Low,1);
        }
    }
}

// Working with Reference Types and Value Types