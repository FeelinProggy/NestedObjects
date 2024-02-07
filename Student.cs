using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedObjects
{
    public class Student
    {
        /// <summary>
        ///Legal First name
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        ///Legal Last name
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        ///Assigned school email address
        /// </summary>
        public string SchoolEmail { get; set; }

        /// <summary>
        /// Student's date of birth
        /// </summary>
        public DateOnly DateOfBirth { get; set; }

        /// <summary>
        /// Student's preferred contact number
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Student's assigned advisor
        /// </summary>
        public Advisor AssignedAdvisor { get; set; }
    }
}
