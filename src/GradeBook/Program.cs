using System;
using System.Collections.Generic;
using System.Linq;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
          var book = new Book("Manuel's Grade Book");
          book.AddGrade(89.1);
          book.AddGrade(90.5);
          book.AddGrade(53.7);
          book.AddGrade(30.5);
          book.ShowStatistics();
        }
    }
}