using System;
using Xunit;

namespace GradeBook.Tests
{
    public class UnitTest1
    {
        [Fact] // attribut Fact is a piece of info attached to the next info
        public void Test1()
        {
          // arrange section
          var x = 5;
          var y = 2;
          var expected = 7;

          // act section
          var actual = x * y;

          // assert section
          Assert.Equal(expected, actual);
        }
    }
}
