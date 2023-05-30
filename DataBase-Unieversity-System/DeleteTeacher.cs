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
    public partial class DeleteTeacher : Form
    {
        public DeleteTeacher()
        {
            InitializeComponent();
        }

        private void DeleteTeacher_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string Id = txtIDTeacher.Text;
                SqlConnection sc = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Motri\\Documents\\GitHub\\DataBase-Unieversity-System\\DataBase-Unieversity-System\\Database1.mdf;Integrated Security=True");
                sc.Open();
                string query = "DELETE FROM Teacher WHERE IDTeacher ='" + Id + "'";
                SqlCommand cmd = new SqlCommand(query, sc);

                cmd.ExecuteNonQuery();

                sc.Close();
                MessageBox.Show("استاد حذف شد");
                txtIDTeacher.Text = "";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
