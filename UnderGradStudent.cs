using System;
using System.Collections.Generic;
using System.Text;

namespace ShakilUniversity
{
    class UnderGradStudent : FullTimeStudent
    {
        public UnderGradStudent()
        {

        }

        public UnderGradStudent(int id, string fname, string lname, int idcard, string adress, string citi, int phon, int t1, int t2)
            :base(id, fname, lname, idcard, adress, citi, phon, t1, t2)
        {

        }
        public override string ComputeGrade()
        {
            string resut = "";

            if (Test1 >= 0.40 && Test2 >= 0.50)
            {
                resut = "A";
            }
            else if (Test1 >= 0.30 && Test2 >= 0.40)
            {
                resut = "B";
            }
            else if (Test1 >= 0.25 && Test2 >= 0.35)
            {
                resut = "C";
            }
            else if (Test1 >= 0.25 && Test2 >= 0.30)
            {
                resut = "D";
            }
            else if (Test1 >= 0.20 && Test2 >= 0.25)
            {
                resut = "E";
            }
            else
            {
                resut = "F";
            }
            return resut;
        }
    }
}
