using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ShakilUniversity
{
    public partial class UnderGradStudentForm : Form
    {
        public UnderGradStudentForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UnderGradStudentForm_Load(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.Controls)
            {
                ctrl.BackColor = Color.AliceBlue;
            }
        }

       
        private void btngrade_Click(object sender, EventArgs e)
        {
            UnderGradStudent underGrad = new UnderGradStudent

            {
                Firstname = txtfname.Text,
                Lastname = txtfname.Text,
                Address = txtaddrs.Text,
                City = txtcity.Text,
                Phonenumber = int.Parse(txttelephone.Text),
                Test1 = int.Parse(txttest1.Text),
                Test2 = int.Parse(txttest2.Text)
            };

            UnderGradStudent under = new UnderGradStudent();
            string result =  under.ComputeGrade();
            txtgrade.Text = result.ToString();

        }
    }
}

     
