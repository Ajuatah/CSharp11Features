using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequiredMembers
{
    internal class Student
    {
        public  required string Name { get; set; }

        //previoously we could do the following 

        //1
        //public string? Name1 { get; set; }
        //2
        //public string Name1 { get; set; } = string.Empty;
        //3
        //public string Name1 { get; set; }

        //public Student(string Name1)
        //{
        //    Name = Name1;
            
        //}

    }
}
