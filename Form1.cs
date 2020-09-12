using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShakilUniversity
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void UnderGradStudent_Click(object sender, EventArgs e)
        {
            UnderGradStudentForm under = new UnderGradStudentForm();
            
            under.ShowDialog();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.Controls)
            {
                ctrl.BackColor = Color.LightSteelBlue;
            }
        }
    }
}
