using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Windows.Forms;

namespace ShakilUniversity
{
    abstract class FullTimeStudent
    {
        [Key]
        int id;
        [MaxLength(15)]
        string firstname;
        [MaxLength(15)]
        string lastname;
        int nationalidcard;
        [MaxLength(100)]
        string address;
        [MaxLength(15)]
        string city;
        [DataType(DataType.PhoneNumber)]
        int phonenumber;
        int test1;
        int test2;

        public int Id { get => id; set => id = value; }
        public string Firstname { get => firstname; set => firstname = value; }
        public string Lastname { get => lastname; set => lastname = value; }
        public int Nationalidcard { get => nationalidcard; set => nationalidcard = value; }
        public string Address { get => address; set => address = value; }
        public string City { get => city; set => city = value; }
        public int Phonenumber { get => phonenumber; set => phonenumber = value; }
        public int Test2 { get => test2; set => test2 = value; }
        public int Test1 { get => test1; set => test1 = value; }

        public FullTimeStudent()
        { }

        public FullTimeStudent(int idd, string fname, string lname, int idcard, string addres, string citi, int phone, int t1, int t2)
        {
            this.id = idd;
            this.firstname = fname;
            this.lastname = lname;
            this.nationalidcard = idcard;
            this.address = addres;
            this.city = citi;
            this.phonenumber = phone;
            this.Test1 = t1;
            this.Test2 = t2;

        }

        public virtual string ComputeGrade()
        {
            string resut = "";

            if (Test1 >= 0.45 && Test2 >= 0.55)
            {
                resut = "A";
            }
            else if (Test1 >= 0.35 && Test2 >= 0.44)
            {
                resut = "B";
            }
            else if (Test1 >= 0.30 && Test2 >= 0.40)
            {
                resut = "C";
            }
            else if (Test1 >= 0.30 && Test2 >= 0.35)
            {
                resut = "D";
            }
            else if (Test1 >= 0.25 && Test2 >= 0.30)
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


