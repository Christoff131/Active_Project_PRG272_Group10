using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace First_Form_Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Registration form2 = new Registration();
            form2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student_Information form3 = new Student_Information();
            form3.Show();
        }
    }
}
