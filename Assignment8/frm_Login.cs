using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment8
{
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }

        private void lbl_Welcome_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frm_Login_Load(object sender, EventArgs e)
        {
            cmb_User_Role.SelectedIndex = 0;
            cmb_User_Name.Text = "Shiv";

            tb_Password.Focus();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            frm_Main_Form obj = new frm_Main_Form();
            obj.Show();
            this.Hide();
        }
    }
}
