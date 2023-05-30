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
    public partial class Student : Form
    {

        public Student()
        {
            InitializeComponent();
        }

        private void Student_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }
        AddStudent ads = new AddStudent();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            ads.Show();
        }
        EditStudent es = new EditStudent();
        private void btnEdit_Click(object sender, EventArgs e)
        {
            es.Show();
        }
        DeleteStudent ds = new DeleteStudent();
        private void btnDelete_Click(object sender, EventArgs e)
        {
            ds.Show();
        }

        private void btnAllStudent_Click(object sender, EventArgs e)
        {
            try
            {
                listBox1.Items.Clear();
                SqlConnection sc = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Motri\\Documents\\GitHub\\DataBase-Unieversity-System\\DataBase-Unieversity-System\\Database1.mdf ;Integrated Security=True");
                sc.Open();
                string query = "SELECT * FROM Student";
                SqlCommand cmd= new SqlCommand(query,sc);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                   string firstname = reader["FirstName"].ToString();
                    string lastname = reader["LastName"].ToString();
                    string IdStudent = reader["IDStudent"].ToString();
                    listBox1.Items.Add(firstname + " " + lastname + " با کد دانشجویی: " + IdStudent);
                }
               

                sc.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
