using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentAPI_OneToOne_003
{
    // Principal Class
    public class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        
        public StudentAddress AddressId { get; set; }
    }
}
