using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.Tavisca.LibraryManagementSystem
{
    public class Book
    {
        public  string Name  { get; set; }
        public string Author  { get; set; }
        public Category Generes { get; set; }
        public String PublishYear { get; set; }
       public BookCondition Status { get; set; }
       
        public override string ToString()
        {
            return Name + " " + Author + " " + Generes + " " + PublishYear;
        }



    }
}
