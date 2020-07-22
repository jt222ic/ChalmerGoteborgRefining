using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._5SortingClass
{
    class Program
    {
        static void Main(string[] args)
        {

            /// there is alternative path such as using orderby,descending and ascending 
            /// find name write out ICompare and Icomparer

            List<int> number = new List<int>();
            List<string> name = new List<string>();
            List<Student> studentClass = new List<Student>();
            studentClass.Add (new Student("jan", 1000));
            studentClass.Add(new Student("tran", 100));
            studentClass.Add(new Student("a", 130));
            studentClass.Add(new Student("ac", 9900));
            studentClass.Add(new Student("a", 100));
            studentClass.Add(new Student("be", 120));
            studentClass.Add(new Student("ba", 100));
            studentClass.Add(new Student("ab", 180));
            studentClass.Add(new Student("aRG", 180));
            studentClass.Add(new Student("a", 130));
            studentClass.Add(new Student("a", 300));
            Console.WriteLine("Unsorted Added student");
            foreach (Student student in studentClass)
            {

                Console.WriteLine("Name:{0} Year:{1}", student.Name,student.Age);
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Sorting by name and year");
            studentClass.Sort();
            foreach (Student student in studentClass)
            {

                Console.WriteLine("Name:{0}  Year:{1}", student.Name, student.Age);
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Sorting year");
            studentClass.Sort(new MyStudentComparer());  // sorting by year
            foreach (Student student in studentClass)
            {
                Console.WriteLine("Name:{0}  Year:{1}", student.Name, student.Age);
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Sorting name");
            studentClass.Sort(new NameLengthComparer());  // sorting by name
            foreach (Student student in studentClass)
            {
                Console.WriteLine("Name:{0}  Year:{1}", student.Name, student.Age);
            }
        }
    }
    class Student : IComparable<Student>
    {
        // field
        private string name;
        private int age;

        //properties

            public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public int Age
        {

            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }
        public Student(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
        public int CompareTo(Student other)     // return negative number im less, return higher im above, return neutral = Equal
        {
            if(this.Name ==other.Name)
            {                                                   // seems to sort by descending, the smaller number is the priority
                return Age.CompareTo(other.Age);                
            }
            return Name.CompareTo(other.Name);
        }
        
    }
    class MyStudentComparer : IComparer<Student>
    {
        static int jan = 0;
        public int Compare(Student x, Student y)              // same principle  as above   you can set your own custimsable ifstatement to compare
        {
            return x.Age - y.Age;                                  // if x >  y => return 1;  if x<y = return -1  else return 0
        }
    }
    class NameLengthComparer : IComparer<Student>
    {
       
        
        public int Compare(Student x, Student y)              // same principle  as above   you can set your own custimsable ifstatement to compare
        {
            if (x.Name.Length < y.Name.Length)
            {
                return -1;
            }
            if (x.Name.Length > y.Name.Length)
            {
                return 1;
            }
            return 0;                                                     // if x >  y => return 1;  if x<y = return -1  else return 0
        }
    }
}
