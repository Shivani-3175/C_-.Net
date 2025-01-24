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
    public partial class frm_Main_Form : Form
    {
        public frm_Main_Form()
        {
            InitializeComponent();
        }

        private void frm_Main_Form_Load(object sender, EventArgs e)
        {

        }

        private void btn_Customer_Click(object sender, EventArgs e)
        {

        }

        private void btn_User_Management_Click(object sender, EventArgs e)
        {
            UC.UC_Add_User Obj = new UC.UC_Add_User();

            pnl_Container.Controls.Clear();
            pnl_Container.Controls.Add(Obj);
            Obj.Show();

            UC_User_Management obj = new UC_User_Management();
            pnl_Head.Controls.Clear();
            pnl_Head.Controls.Add(obj);
            obj.Show();
        }

        private void btn_User_Name_Click(object sender, EventArgs e)
        {

        }
    }
}
