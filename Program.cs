using System;

namespace cshrap
{
    class Customer
    {
        string _firstname;
        string _lastname;
        public Customer(string firstname,string lastname )
        {
            _firstname=firstname;
            _lastname=lastname;
        }
        public string PrintFullName()
        {
            return _firstname +" "+ _lastname;
        }
        ~Customer()
        {

        }
class program
{

        static void Main()
        {
          Customer c1=new Customer("navaneeth","mola");
          Console.WriteLine(c1.PrintFullName());  
        }
    }
}
}
