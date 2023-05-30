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
    public partial class AddStudent : Form
    {
        public AddStudent()
        {
            InitializeComponent();
        }

        private void AddStudent_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            try
            {
                string cod = txtCOD.Text;
                string Fname = txtFName.Text;
                string Lname = txtLName.Text;
                string father = txtFather.Text;
                string codm = txtCODM.Text;
                string phone = txtPhone.Text;
                string BDay = txtBDay.Text;
                string gender = txtGender.Text;
                if (cod == "" || Fname == "" || Lname == "" || father == "" || codm == "" || phone == "" || BDay == "" || gender == "")
                {
                    MessageBox.Show("اطلاعات را کامل وارد کنید");
                }
                else
                {
                    SqlConnection sc = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Motri\\Documents\\GitHub\\DataBase-Unieversity-System\\DataBase-Unieversity-System\\Database1.mdf;Integrated Security=True");
                    sc.Open();
                    string query = "INSERT INTO Student (IDStudent,FirstName,LastName,Father,NationalCod,Phone,Date,Gender) VALUES ('" + cod + "','" + Fname + "','" + Lname + "','" + father + "','" + codm + "','" + phone + "','" + BDay + "','" + gender + "')";
                    SqlCommand cmd = new SqlCommand(query, sc);

                    cmd.ExecuteNonQuery();

                    sc.Close();
                    MessageBox.Show("دانشجو جدید با موفقیت اضافه شد");
                    txtCOD.Text = txtFName.Text = txtLName.Text = txtFather.Text = txtCODM.Text = txtPhone.Text = txtBDay.Text = txtGender.Text = "";


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtCOD_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtCODM_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtBDay_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsPunctuation(e.KeyChar);

        }
    }
}
