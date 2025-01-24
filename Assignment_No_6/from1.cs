using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_No_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lb_Output_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Hobbies_Error_Click(object sender, EventArgs e)
        {

        }

        private void cb_Marathi_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cb_French_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            tb_Employee_Name.Clear();
            cmb_Dept.SelectedIndex = -1;
            rb_Male.Checked = false;
            rb_Female.Checked = false;
            cb_Marathi.Checked = false;
            cb_English.Checked = false;
            cb_Hindi.Checked = false;
            cb_French.Checked = false;

            for (int i = 0; i < clb_Hobbies.Items.Count; i++)
            {
                clb_Hobbies.SetItemChecked(i, false);
            }

            lbl_Dept_Error.Visible = false;




        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            String Output = "";
            bool Flag = true, LFlag = true;

            if (tb_Employee_Name.Text != "")
            {
                Output += tb_Employee_Name.Text + "IS FROM Department";
                lbl_Name_Error.Visible = false;
            }
            else
            {
                lbl_Name_Error.Text = "Enter Employee Name";
                lbl_Name_Error.Visible = true;
                Flag = false;
            }

            if (cmb_Dept.Text != "")
            {
                Output += cmb_Dept.Text;
                lbl_Dept_Error.Visible = false;
            }
            else
            {
                lbl_Dept_Error.Text = " Select Dept";
                lbl_Dept_Error.Visible = true;
                Flag = false;
            }
            if (rb_Male.Checked == true)
            {
                Output += ",is" + rb_Male.Text + "And He Knows";
                lbl_Gender_Error.Visible = false;
            }
            else if (rb_Female.Checked == true)
            {
                Output += ",is" + rb_Female.Text + "And She Knows";
                lbl_Gender_Error.Visible = false;
            }
            else
            {
                lbl_Gender_Error.Text = "Select Gender";
                lbl_Gender_Error.Visible = true;
                Flag = false;
            }
            if (cb_Marathi.Checked == true)
            {
                Output += cb_Marathi.Text + ",";
                lbl_Lang_Error.Visible = false;
                LFlag = false;
            }
            if (cb_Hindi.Checked == true)
            {
                Output += cb_Hindi.Text + ",";
                lbl_Lang_Error.Visible = false;
                LFlag = false;
            }
            if (cb_English.Checked == true)
            {
                Output += cb_English.Text + ",";
                lbl_Lang_Error.Visible = false;
                LFlag = false;
            }
            if (cb_French.Checked == true)
            {
                Output += cb_French.Text + ",";
                lbl_Lang_Error.Visible = false;
                LFlag = false;
            }
            if (LFlag == true)
            {
                lbl_Lang_Error.Text = " Select Known Lang ";
                lbl_Lang_Error.Visible = true;
                Flag = false;
            }
            int Cnt = clb_Hobbies.CheckedItems.Count;

            if (Cnt > 0)
            {
                lbl_Hobby_Error.Visible = false;
                Output += " And Has Hobbies as ";

                for (int i = 0; i < clb_Hobbies.Items.Count; i++)
                {
                    if (clb_Hobbies.GetItemChecked(i))
                    {
                        if (Cnt > 1)
                        {
                            Output += clb_Hobbies.Items[i] + ",";
                        }
                        else
                        {
                            Output += clb_Hobbies.Items[i] + ",";
                            break;
                        }
                        Cnt--;
                    }
                }
            }

            else
            {
                lbl_Hobby_Error.Text = "Select atleast 1 Hobby";
                lbl_Hobby_Error.Visible = true;
                Flag = false;
            }
            if (Flag == false)
            {
                lbl_Out.Visible = false;
            }
            else
            {
                lbl_Out.Text = Output;
                lbl_Out.Visible = true;
            }
        }

        private void lb_Gender_Click(object sender, EventArgs e)
        {

        }

        private void lb_Employee_Department_Click(object sender, EventArgs e)
        {

        }

        private void lb_Employee_Name_Click(object sender, EventArgs e)
        {

        }
    }

}