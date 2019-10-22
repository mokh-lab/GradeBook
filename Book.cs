
using System.Collections.Generic;

namespace GradeBook
{
    class Book
    {
        public Book(string name)
        {
            grades = new List<double>();
            this.name = name;
        }
         
       public void addgrade (double garde)
        {
            grades.Add(garde);
        }

       private  List<double> grades ;
        private string name;
    }
}
