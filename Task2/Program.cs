using System.Data.Common;
using System.Numerics;
using System.Text;
using System.Transactions;

public class Student
    {
        //TODO Task 2.1 Ensure firstname, middlename and lastname can only be modified from within the class
        //TODO Task 2.2 Allow middlename to contain null values
        private string firstname;
        private string? middlename;
        private string lastname;
        public string FirstName{
            get=>firstname;
            private set{
                firstname=value;
            }
        }
        public string? MiddleName{
            get=>middlename;
            private set{
                middlename=value;
            }
        }
        public string LastName{
            get=>lastname;
            private set{lastname=value;}
        }
        public Student(string first, string? middle, string last)
        {
            firstname = first;
            middlename = middle;
            lastname = last;
        }
        //END OF TODO Task 2.1 and 2.2
   
        //TODO Task 2.3 Create overloaded constructor that accepts only first name and last name
         public Student(string first, string last):this(first,null,last)
        {
            ;
        }
        //END OF TODO Task 2.3
    }
class Program
{
    static void Main()
    {
        //TODO Task 2.4 Create an instance of the Student class called studentA with a firstname, middlename and lastname
        Student studentA=new("Ben","Sam","Smith");
        //END OF TODO Task 2.4
  
    }
}
