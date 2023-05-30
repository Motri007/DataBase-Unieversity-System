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
    public partial class AddTeacher : Form
    {
        public AddTeacher()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {

            try
            {
                string Fname = txtFName.Text;
                string Lname = txtLName.Text;
                string codm = txtCODM.Text;
                string phone = txtPhone.Text;
                string BDay = txtBDay.Text;
                string Evidence = txtEvidence.Text;
                if (Fname == "" || Lname == "" || codm == "" || phone == "" || BDay == "" || Evidence == "")
                {
                    MessageBox.Show("اطلاعات را کامل وارد کنید");
                }
                else
                {
                    SqlConnection sc = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Motri\\Documents\\GitHub\\DataBase-Unieversity-System\\DataBase-Unieversity-System\\Database1.mdf;Integrated Security=True");
                    sc.Open();
                    string query = "INSERT INTO Teacher (FNameT,LNameT,NationalCod,Phone,Date,Evidence) VALUES ('" + Fname + "','" + Lname + "','" + codm + "','" + phone + "','" + BDay + "','" + Evidence + "')";
                    SqlCommand cmd = new SqlCommand(query, sc);

                    cmd.ExecuteNonQuery();

                    sc.Close();
                    MessageBox.Show("استاد جدید با موفقیت اضافه شد");
                    txtFName.Text = txtLName.Text = txtCODM.Text = txtPhone.Text = txtBDay.Text = txtEvidence.Text = "";


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AddTeacher_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        private void txtCODM_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        private void txtBDay_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsPunctuation(e.KeyChar);

        }
    }
}
