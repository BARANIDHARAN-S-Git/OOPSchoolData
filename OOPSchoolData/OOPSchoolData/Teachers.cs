using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSchoolData
{
    public class Teachers
    {
        public int Teacher_Id { get; set; }

        public string Teacher_Name { get; set; }

        public bool isTeacher()
        {
            return Teacher_Id == 1;
        }
    }
}
