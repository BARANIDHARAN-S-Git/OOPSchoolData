using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSchoolData
{
    public  class Subjects
    {
        public int Subject_Id { get; set; }

        public string Subject_Name { get; set; }

        public bool isgreaterSubjects()
        {
            return Subject_Id == 101;
        }
    }
}
