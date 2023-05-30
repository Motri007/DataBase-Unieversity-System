using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBase_Unieversity_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Student st = new Student();
        private void btnStudent_Click(object sender, EventArgs e)
        {
            st.Show();
        }
        Teacher th = new Teacher();
        private void btnTeacher_Click(object sender, EventArgs e)
        {
            th.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("موردی یافت نشد", "به زودی");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("موردی یافت نشد", "به زودی");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("موردی یافت نشد", "به زودی");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("موردی یافت نشد", "به زودی");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("موردی یافت نشد", "به زودی");
        }

    }
}
