
namespace Assignment_No_7
{
    partial class frm_Show_Image_Details
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_Header = new System.Windows.Forms.Label();
            this.lbl_Image = new System.Windows.Forms.Label();
            this.lbl_Image_list = new System.Windows.Forms.Label();
            this.pb_Image = new System.Windows.Forms.PictureBox();
            this.dgv_Image_List = new System.Windows.Forms.DataGridView();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_Insert_Image = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Image_List)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Header
            // 
            this.lbl_Header.AutoSize = true;
            this.lbl_Header.BackColor = System.Drawing.Color.AliceBlue;
            this.lbl_Header.Font = new System.Drawing.Font("Modern No. 20", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Header.ForeColor = System.Drawing.Color.Black;
            this.lbl_Header.Location = new System.Drawing.Point(305, 69);
            this.lbl_Header.Name = "lbl_Header";
            this.lbl_Header.Size = new System.Drawing.Size(262, 48);
            this.lbl_Header.TabIndex = 51;
            this.lbl_Header.Text = "Show Image";
            // 
            // lbl_Image
            // 
            this.lbl_Image.AutoSize = true;
            this.lbl_Image.Font = new System.Drawing.Font("Lucida Bright", 21.75F, System.Drawing.FontStyle.Bold);
            this.lbl_Image.Location = new System.Drawing.Point(137, 184);
            this.lbl_Image.Name = "lbl_Image";
            this.lbl_Image.Size = new System.Drawing.Size(130, 42);
            this.lbl_Image.TabIndex = 52;
            this.lbl_Image.Text = "Image";
            // 
            // lbl_Image_list
            // 
            this.lbl_Image_list.AutoSize = true;
            this.lbl_Image_list.Font = new System.Drawing.Font("Lucida Bright", 21.75F, System.Drawing.FontStyle.Bold);
            this.lbl_Image_list.Location = new System.Drawing.Point(623, 193);
            this.lbl_Image_list.Name = "lbl_Image_list";
            this.lbl_Image_list.Size = new System.Drawing.Size(208, 42);
            this.lbl_Image_list.TabIndex = 53;
            this.lbl_Image_list.Text = "Image List";
            // 
            // pb_Image
            // 
            this.pb_Image.BackColor = System.Drawing.Color.White;
            this.pb_Image.Location = new System.Drawing.Point(67, 250);
            this.pb_Image.Margin = new System.Windows.Forms.Padding(4);
            this.pb_Image.Name = "pb_Image";
            this.pb_Image.Size = new System.Drawing.Size(327, 266);
            this.pb_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Image.TabIndex = 54;
            this.pb_Image.TabStop = false;
            // 
            // dgv_Image_List
            // 
            this.dgv_Image_List.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Image_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Image_List.Location = new System.Drawing.Point(526, 258);
            this.dgv_Image_List.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_Image_List.Name = "dgv_Image_List";
            this.dgv_Image_List.RowHeadersWidth = 51;
            this.dgv_Image_List.Size = new System.Drawing.Size(355, 258);
            this.dgv_Image_List.TabIndex = 55;
            this.dgv_Image_List.SelectionChanged += new System.EventHandler(this.dgv_Image_List_SelectionChanged);
            // 
            // btn_Search
            // 
            this.btn_Search.Font = new System.Drawing.Font("Lucida Bright", 21.75F, System.Drawing.FontStyle.Bold);
            this.btn_Search.ForeColor = System.Drawing.Color.Tomato;
            this.btn_Search.Location = new System.Drawing.Point(42, 561);
            this.btn_Search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(328, 66);
            this.btn_Search.TabIndex = 56;
            this.btn_Search.Text = "Search Image";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // btn_Insert_Image
            // 
            this.btn_Insert_Image.Font = new System.Drawing.Font("Lucida Bright", 21.75F, System.Drawing.FontStyle.Bold);
            this.btn_Insert_Image.ForeColor = System.Drawing.Color.Tomato;
            this.btn_Insert_Image.Location = new System.Drawing.Point(565, 559);
            this.btn_Insert_Image.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Insert_Image.Name = "btn_Insert_Image";
            this.btn_Insert_Image.Size = new System.Drawing.Size(288, 71);
            this.btn_Insert_Image.TabIndex = 57;
            this.btn_Insert_Image.Text = "Insert Image";
            this.btn_Insert_Image.UseVisualStyleBackColor = true;
            this.btn_Insert_Image.Click += new System.EventHandler(this.btn_Insert_Image_Click);
            // 
            // frm_Show_Image_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 715);
            this.Controls.Add(this.btn_Insert_Image);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.dgv_Image_List);
            this.Controls.Add(this.pb_Image);
            this.Controls.Add(this.lbl_Image_list);
            this.Controls.Add(this.lbl_Image);
            this.Controls.Add(this.lbl_Header);
            this.Name = "frm_Show_Image_Details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Show_Image_Details";
            this.Load += new System.EventHandler(this.frm_Show_Image_Details_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Image_List)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Header;
        private System.Windows.Forms.Label lbl_Image;
        private System.Windows.Forms.Label lbl_Image_list;
        private System.Windows.Forms.PictureBox pb_Image;
        private System.Windows.Forms.DataGridView dgv_Image_List;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Button btn_Insert_Image;
    }
}