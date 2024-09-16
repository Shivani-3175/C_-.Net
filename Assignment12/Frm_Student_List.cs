using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment31
{
    public partial class Frm_Student_List : Form
    {
        public Frm_Student_List()
        {
            InitializeComponent();
        }

        private void btn_Add_New_student_Click(object sender, EventArgs e)
        {
            frm_Add_New_Student ANS = new frm_Add_New_Student();
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

        private void Frm_Student_List_Load(object sender, EventArgs e)
        {
            lbl_Username.Text = "Welcome " + Shared_Contain.Uname;
            // TODO: This line of code loads data into the '_Assginment1_DBDataSet.Student_Details' table. You can move, or remove it, as needed.
            this.student_DetailsTableAdapter.Fill(this._Assginment1_DBDataSet.Student_Details);

        }
    }
}
