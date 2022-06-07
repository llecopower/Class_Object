using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Object
{
    public class Student
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }

        //complete form of a property
        private string lastName;
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }




    }
}
