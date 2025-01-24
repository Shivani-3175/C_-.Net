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
    public partial class UC_User_Management : UserControl
    {
        public UC_User_Management()
        {
            InitializeComponent();
        }

        private void btn_Add_User_Click(object sender, EventArgs e)
        {
            UC.UC_Add_User obj = new UC.UC_Add_User();

            frm_Main_Form.pnl_Container.Controls.Clear();

            frm_Main_Form.pnl_Container.Controls.Add(obj);
            obj.Show();

        }

        private void btn_Delet_User_Click(object sender, EventArgs e)
        {
            UC.Uc_Delet_User1 obj = new UC.Uc_Delet_User1();

            frm_Main_Form.pnl_Container.Controls.Clear();

            frm_Main_Form.pnl_Container.Controls.Add(obj);
            obj.Show();
        }

        private void btn_Update_User_Click(object sender, EventArgs e)
        {
            UC.Uc_Update_User1 obj = new UC.Uc_Update_User1();

            frm_Main_Form.pnl_Container.Controls.Clear();

            frm_Main_Form.pnl_Container.Controls.Add(obj);
            obj.Show();
        }
    }
}
