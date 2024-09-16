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
    public partial class Frm_login_form : Form
    {
        public Frm_login_form()
        {
            InitializeComponent();
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            if(tb_Username.Text == "s" && tb_Password.Text == "s")
            {
                MessageBox.Show("Login Successful", "WELCOME");

                Shared_Contain.Uname = tb_Username.Text;

                frm_Add_New_Student ANS = new frm_Add_New_Student();
                ANS.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login Failed,Enter correct Username/Password.", "Failure");
            }
            tb_Username.Clear();
            tb_Password.Clear();

            tb_Username.Focus();

            
        }

        private void Frm_login_form_Load(object sender, EventArgs e)
        {

        }
    }
}
