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
using System.IO;

namespace Assignment_No_7
{
    public partial class frm_Picture_Box : Form
    {
        public frm_Picture_Box()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-C6QNIHGF\MSSQLSERVER01;Initial Catalog=Assginment1.DB;Integrated Security=True");

        void Con_Open()
        {
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
        }

        void Con_Close()
        {
            if (con.State != ConnectionState.Closed)
            {
                con.Close();
            }
        }

        private void Only_Numeric(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == '.')))
            {
                e.Handled = true;
            }
        }

        void Clear_Controls()
        {
            tb_Image_ID.Clear();
            tb_Image_Description.Clear();
            pb_Image.Image = null;
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            Clear_Controls();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Con_Open();

            if (tb_Image_ID.Text != "" && tb_Image_Description.Text != "" && pb_Image.Image != null)
            {
                SqlCommand cmd = new SqlCommand("Insert Into Image_Details Values (@ID, @Image_Details, @Image) ", con);

                cmd.Parameters.Add("@ID", SqlDbType.Int).Value = tb_Image_ID.Text;
                cmd.Parameters.Add("@Image_Details", SqlDbType.NVarChar).Value = tb_Image_Description.Text;

                ImageConverter IC = new ImageConverter();

                byte[] imgArray = (byte[])IC.ConvertTo(pb_Image.Image, typeof(byte[]));

                cmd.Parameters.Add("@Image", SqlDbType.Image).Value = imgArray;

                cmd.ExecuteNonQuery();

                MessageBox.Show("Details Saved Successfully");
                Clear_Controls();
            }
            else
            {
                MessageBox.Show("1st Fill All The Fields!!!");
            }

            Con_Close();
        }

        private void btn_Search_Image_Click(object sender, EventArgs e)
        {

            frm_Search_Image_Details obj = new frm_Search_Image_Details();
            obj.Show();
            this.Hide();
        }

        private void btn_Show_Image_Click(object sender, EventArgs e)
        {
            frm_Show_Image_Details obj = new frm_Show_Image_Details();
            obj.Show();
            this.Hide();
        }

        private void frm_Picture_Box_Load(object sender, EventArgs e)
        {
            tb_Image_ID.Focus();
        }

        private void btn_Browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog();

            OFD.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";

            if (OFD.ShowDialog() == DialogResult.OK)
            {
                pb_Image.Image = new Bitmap(OFD.FileName);
            }
        }
    }
}
