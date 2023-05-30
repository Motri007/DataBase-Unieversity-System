using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBase_Unieversity_System
{
    public partial class Teacher : Form
    {
        public Teacher()
        {
            InitializeComponent();
        }

        private void Teacher_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }
        AddTeacher ath = new AddTeacher();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            ath.Show();
        }

        private void btnAllTeacher_Click(object sender, EventArgs e)
        {

            try
            {
                listBox1.Items.Clear();
                SqlConnection sc = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Motri\\Documents\\GitHub\\DataBase-Unieversity-System\\DataBase-Unieversity-System\\Database1.mdf;Integrated Security=True");
                sc.Open();
                string query = "SELECT * FROM Teacher";
                SqlCommand cmd = new SqlCommand(query, sc);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string firstname = reader["FNameT"].ToString();
                    string lastname = reader["LNameT"].ToString();
                    string IdTeacher = reader["IDTeacher"].ToString();
                    listBox1.Items.Add(firstname + " " + lastname + " با کد استاد: " + IdTeacher);
                }


                sc.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        DeleteTeacher dth= new DeleteTeacher();
        private void btnDelete_Click(object sender, EventArgs e)
        {
            dth.Show();
        }
    }
}
