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
    public partial class EditStudent : Form
    {
        public EditStudent()
        {
            InitializeComponent();
        }

        private void EditStudent_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            try
            {
                string cod = txtCOD.Text;
                string NPhone = txtNEWPhone.Text;

                SqlConnection sc = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Motri\\Documents\\GitHub\\DataBase-Unieversity-System\\DataBase-Unieversity-System\\Database1.mdf;Integrated Security=True");
                sc.Open();
                string query = "UPDATE Student SET Phone = " + NPhone + " WHERE IDStudent = " + cod + " ";
                SqlCommand cmd = new SqlCommand(query,sc);

                cmd.ExecuteNonQuery();

                sc.Close();
                MessageBox.Show("شماره با موفقیت ویرایش شد");
                txtCOD.Text = txtNEWPhone.Text = "";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
