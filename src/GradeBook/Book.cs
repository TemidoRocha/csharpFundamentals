using System;
using System.Collections.Generic;

namespace GradeBook
{
  public class Book
  {
    // implicit constructor
    // same name as the class
    // has no return type
    public Book(string name)
    {
      grades = new List<double>();
      // since e can not use name = name, we can use this as example bellow
      // this is to use implicitly a member of the class
      Name = name;
      numberOfBooks += 1;
    }
    public void AddGrade(double grade)
    {
      grades.Add(grade);
    }

    public Statistics GetStatistics()
    {
      var result = new Statistics();
      result.Average= 0.0;
      result.High = double.MinValue;
      result.Low = double.MaxValue;
      foreach (var grade in grades)
      {
          result.High = Math.Max(grade, result.High);
          result.Low = Math.Min(grade, result.Low);
          result.Average += grade;
      }
      result.Average /= grades.Count;
      return result;
    }
    // when you have a field we can not use implicit typing (we cannot use var)
    // one way to instatiate
    //List<double> grades = new List<double>();
    // second way is to use the construcor
    // when we don't use a modifier it is private as default
    private List<double> grades;
    public string Name;
    static int numberOfBooks = 0;
  }
}