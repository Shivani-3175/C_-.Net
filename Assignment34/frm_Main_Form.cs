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
    public partial class frm_Main_Form : Form
    {
        public frm_Main_Form()
        {
            InitializeComponent();
        }

        private void studentToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addNewStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Add_New_Student obj = new frm_Add_New_Student();
            obj.MdiParent = this;
            obj.Show();
        }

        private void searchStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Search_student_By_Roll_No obj = new frm_Search_student_By_Roll_No();
            obj.MdiParent = this;

            obj.Show();
        }

        private void studentListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Student_List obj = new Frm_Student_List();
            obj.MdiParent = this;
            obj.Show();
        }

        private void updateStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void frm_Main_Form_Load(object sender, EventArgs e)
        {
            lbl_Username.Text = "Welcome " + Shared_Contain.Uname;
        }

        private void btn_log_out_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are you sure want to Logout", "Warning", MessageBoxButtons.YesNo);
            Frm_login_form obj = new Frm_login_form();
            obj.Show();
            this.Hide();
        }
    }
}
