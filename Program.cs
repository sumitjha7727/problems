using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program2
{
    internal class Program
    {
        public class Students
        {
            private string course;
            private int feepaid;
            private string name;
            private int rollno;
            private string servicetax;

            public string Course { get { return course; } set { course = value; } }
            public int Feepaid { get { return feepaid; } set { feepaid = value; } }
            public string Name { get { return name; } set { name = value; } }
            public int Rollno { get { return rollno; } set { rollno = value; } }
            public string Servicetax { get { return servicetax; } set { servicetax = value; } }

            public int DueAmount { get; set; }
            public int ServiceTax { get; set; }
            public int TotalFee { get; set; }

            public void Payment() { Console.WriteLine("Payment method invoked"); }
            public void Print() { Console.WriteLine("Print Method Invoked"); }
            public Students(int Rollno, string Name, string Course)
            {
                Console.WriteLine("Student Constructor Invoked");
                this.Rollno = Rollno;
                this.Name = Name;
                this.Course = Course;
            }

        }


        static void Main(string[] args)
        {

        }
    }
}