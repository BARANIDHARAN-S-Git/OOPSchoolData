using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPSchoolData;

namespace OOPSchoolData.Tests
{
    [TestFixture]
    public class SchoolDataTest
    {
        [TestCase(17,ExpectedResult =true)]
        [TestCase(10,ExpectedResult =false)]
        [TestCase(19, ExpectedResult = true)]
        [TestCase(8, ExpectedResult = false)]
        public  bool GetStudentAge(int age)
        {
            Students s=new Students();
            s.Student_Id = 1;
            s.Student_Name = "Buttler";
            s.Student_Age = age;
            bool ans = s.isgreaterStudemts();
            return ans;


        }


        [TestCase(101, ExpectedResult = true)]
        [TestCase(201, ExpectedResult = false)]
        [TestCase(301, ExpectedResult = false)]
        [TestCase(401, ExpectedResult = false)]
        public bool GetSubjectId(int SubjectId)
        {
            Subjects sub=new Subjects();
            sub.Subject_Id = SubjectId;
            sub.Subject_Name = "Tamil";
            bool ans=sub.isgreaterSubjects();
            return ans;
        }

        [TestCase(1, ExpectedResult = true)]
        [TestCase(2, ExpectedResult = false)]
        [TestCase(3, ExpectedResult = false)]
        [TestCase(4, ExpectedResult = false)]
        public bool GetTeacherId(int TeacherId)
        {
            Teachers t=new Teachers();
            t.Teacher_Id = TeacherId;
            t.Teacher_Name = "Baskar";
            bool ans = t.isTeacher();
            return ans;
        }

    }
}
