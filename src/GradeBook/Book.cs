using System;
using System.Collections.Generic;

namespace GradeBook
{
  class Book
  {
    // implicit constructor
    // same name as the class
    // has no return type
    public Book(string name)
    {
      grades = new List<double>();
      // since e can not use name = name, we can use this as example bellow
      // this is to use implicitly a member of the class
      this.name = name;
      numberOfBooks += 1;
    }
    public void AddGrade(double grade)
    {
      grades.Add(grade);
    }

    public void ShowStatistics()
    {
      var result = 0.0;
      var highGrade = double.MinValue;
      var lowGrade = double.MaxValue;
      foreach (double number in grades)
      {
          highGrade = Math.Max(number, highGrade);
          lowGrade = Math.Min(number, lowGrade);
          result += number;
      }
      result /= grades.Count;
      Console.WriteLine($"The highest grade is {highGrade}");
      Console.WriteLine($"The lowest grade is {lowGrade}");
      Console.WriteLine($"The average grade is {result}");
    }
    // when you have a field we can not use implicit typing (we cannot use var)
    // one way to instatiate
    //List<double> grades = new List<double>();
    // second way is to use the construcor
    // when we don't use a modifier it is private as default
    private List<double> grades;
    private string name;
    static int numberOfBooks = 0;
  }
}