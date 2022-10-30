using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace OOPSchoolData
{
    public class Students
    {
        public int Student_Id { get; set; }
        public string Student_Name { get; set; }

        public int Student_Age { get; set; }  
        public bool isgreaterStudemts()
        {
            return Student_Age > 15;
        }
    }
}
