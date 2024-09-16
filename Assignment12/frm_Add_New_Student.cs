using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Assignment31
{
    public partial class frm_Add_New_Student : Form
    {
        public frm_Add_New_Student()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-C6QNIHGF\MSSQLSERVER01;Initial Catalog=Assginment1.DB;Integrated Security=True");
        void con_open()
        {
            if (con.State != ConnectionState.Open)

            {
                con.Open();
            }

        }
        void con_Close()
        {
            if (con.State != ConnectionState.Closed)
            {
                con.Close();
            }
        }
        void clear_Fields()
        {
            tb_Roll_No.Clear();
            tb_Name.Clear();
            tb_Mob_No.Clear();
            dtp_DOB.Text = "02-12-2003";
            cmb_Course.SelectedIndex = -1;
        }


        private void frm_Add_New_Student_Load(object sender, EventArgs e)
        {
            lbl_Username.Text = "Welcome " + Shared_Contain.Uname;
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            //Clear_Fields();
        }

        private void btn_Student_List_Click(object sender, EventArgs e)
        {
            Frm_Student_List ANS = new Frm_Student_List();
            ANS.Show();
            this.Hide();

        }

        private void btn_log_out_Click(object sender, EventArgs e)
        {
            Frm_login_form obj = new Frm_login_form();
            obj.Show();
            this.Hide();
        }

        private void btn_Search_Student_Click(object sender, EventArgs e)
        {
            frm_Search_student_By_Roll_No obj = new frm_Search_student_By_Roll_No();
            obj.Show();
            this.Hide();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            con_open();

            if (tb_Roll_No.Text != "" && tb_Name.Text != "" && tb_Mob_No.Text != "" && cmb_Course.Text != "")
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;
                cmd.CommandText = "Insert Into Student_Details values (@Rno,@Nm,@Mno,@dob,@course)";

                cmd.Parameters.Add("Rno", SqlDbType.Int).Value = tb_Roll_No.Text;
                cmd.Parameters.Add("Nm", SqlDbType.VarChar).Value = tb_Name.Text;
                cmd.Parameters.Add("Dob", SqlDbType.Date).Value = dtp_DOB.Text;
                cmd.Parameters.Add("Mno", SqlDbType.Decimal).Value = tb_Mob_No.Text;
                cmd.Parameters.Add("Course", SqlDbType.NVarChar).Value = cmb_Course.Text;

                cmd.ExecuteNonQuery();

                MessageBox.Show("Record Saved Successfully...");
                clear_Fields();
            }

            else
            {
                MessageBox.Show("Incomplete Data");
            }
            con_Close();
        }
    }
}
