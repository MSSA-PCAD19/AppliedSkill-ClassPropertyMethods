using System.Data.Common;
using System.Numerics;
using System.Text;
using System.Transactions;

public class Student
    {
        //TODO Task 2.1 Ensure firstname, middlename and lastname can only be modified from within the class
        //TODO Task 2.2 Allow middlename to contain null values
        public string firstname;
        public string middlename;
        public string lastname;
        public Student(string first, string middle, string last)
        {
            firstname = first;
            middlename = middle;
            lastname = last;
        }
        //END OF TODO Task 2.1 and 2.2

        //TODO Task 2.3 Create overloaded constructor that accepts only first name and last name

        //END OF TODO Task 2.3
    }
class Program
{
    static void Main()
    {
        //TODO Task 2.4 Create an instance of the Student class called studentA with a firstname, middlename and lastname

        //END OF TODO Task 2.4
    }
}
