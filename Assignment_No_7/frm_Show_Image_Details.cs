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
    public partial class frm_Show_Image_Details : Form
    {
        public frm_Show_Image_Details()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=LAPTOP-C6QNIHGF\MSSQLSERVER01;Initial Catalog=Assginment1.DB;Integrated Security=True");

        void Con_Open()
        {
            if (Con.State != ConnectionState.Open)
            {
                Con.Open();
            }
        }
        void Con_Close()
        {
            if (Con.State != ConnectionState.Closed)
            {
                Con.Close();
            }

        }
        void Bind_Grid(string Query, DataGridView DGV)
        {
            Con_Open();

            DGV.DataSource = "";

            SqlDataAdapter SDA = new SqlDataAdapter(Query, Con);

            DataTable dt = new DataTable();

            SDA.Fill(dt);

            DGV.DataSource = dt;

            Con_Close();
        }
        void View_Image(string Query, PictureBox pb)
        {
            Con_Open();

            SqlCommand Cmd = new SqlCommand(Query, Con);

            SqlDataAdapter da = new SqlDataAdapter(Cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            if (ds.Tables[0].Rows.Count > 0)
            {
                MemoryStream ms = new MemoryStream((byte[])ds.Tables[0].Rows[0]["Image"]);
                pb.Image = new Bitmap(ms);
            }
            else
            {
                MessageBox.Show("Invalid Image ID!!!");
            }

            Con_Close();
        }

        private void dgv_Image_List_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frm_Show_Image_Details_Load(object sender, EventArgs e)
        {
            Bind_Grid("Select Image_Id, Image_Description from Image_Details ", dgv_Image_List);
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            frm_Search_Image_Details Obj = new frm_Search_Image_Details();
            Obj.Show();
            this.Hide();
        }


        private void btn_Insert_Image_Click(object sender, EventArgs e)
        {
            frm_Picture_Box Obj = new frm_Picture_Box();
            Obj.Show();
            this.Hide();
        }

        private void dgv_Image_List_SelectionChanged(object sender, EventArgs e)
        {

            Int32 selectedRowCount = dgv_Image_List.Rows.GetRowCount(DataGridViewElementStates.Selected);

            if (selectedRowCount == 1)
            {
                string value = dgv_Image_List.SelectedCells[0].RowIndex.ToString();

                int Index = Convert.ToInt32(value);

                int ID = Convert.ToInt32(dgv_Image_List.Rows[Index].Cells[0].Value);

                View_Image("Select Image From Image_Details where Image_Id = " + ID + "", pb_Image);
            }

        }
    }
}
