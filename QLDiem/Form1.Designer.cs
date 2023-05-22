namespace QLDiem
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.dgvbang = new System.Windows.Forms.DataGridView();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btntk = new System.Windows.Forms.Button();
            this.btnghi = new System.Windows.Forms.Button();
            this.btnhuy = new System.Windows.Forms.Button();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtht = new System.Windows.Forms.TextBox();
            this.lblten = new System.Windows.Forms.Label();
            this.lblid = new System.Windows.Forms.Label();
            this.lblns = new System.Windows.Forms.Label();
            this.dtpns = new System.Windows.Forms.DateTimePicker();
            this.txtdiem = new System.Windows.Forms.TextBox();
            this.lbldiem = new System.Windows.Forms.Label();
            this.txttk = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvbang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvbang
            // 
            this.dgvbang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvbang.Location = new System.Drawing.Point(607, 69);
            this.dgvbang.Name = "dgvbang";
            this.dgvbang.RowHeadersWidth = 51;
            this.dgvbang.RowTemplate.Height = 24;
            this.dgvbang.Size = new System.Drawing.Size(642, 480);
            this.dgvbang.TabIndex = 0;
            this.dgvbang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvbang_CellClick);
            this.dgvbang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvbang_CellContentClick);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(88, 348);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(75, 23);
            this.btnthem.TabIndex = 5;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(225, 348);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(75, 23);
            this.btnsua.TabIndex = 6;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(368, 348);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 23);
            this.btnxoa.TabIndex = 7;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btntk
            // 
            this.btntk.Location = new System.Drawing.Point(368, 481);
            this.btntk.Name = "btntk";
            this.btntk.Size = new System.Drawing.Size(75, 23);
            this.btntk.TabIndex = 8;
            this.btntk.Text = "Tìm kiếm";
            this.btntk.UseVisualStyleBackColor = true;
            this.btntk.Click += new System.EventHandler(this.btntk_Click);
            // 
            // btnghi
            // 
            this.btnghi.Enabled = false;
            this.btnghi.Location = new System.Drawing.Point(88, 420);
            this.btnghi.Name = "btnghi";
            this.btnghi.Size = new System.Drawing.Size(75, 23);
            this.btnghi.TabIndex = 9;
            this.btnghi.Text = "Ghi";
            this.btnghi.UseVisualStyleBackColor = true;
            this.btnghi.Click += new System.EventHandler(this.btnghi_Click);
            // 
            // btnhuy
            // 
            this.btnhuy.Enabled = false;
            this.btnhuy.Location = new System.Drawing.Point(225, 420);
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.Size = new System.Drawing.Size(75, 23);
            this.btnhuy.TabIndex = 10;
            this.btnhuy.Text = "Hủy bỏ";
            this.btnhuy.UseVisualStyleBackColor = true;
            this.btnhuy.Click += new System.EventHandler(this.btnhuy_Click);
            // 
            // txtid
            // 
            this.txtid.Enabled = false;
            this.txtid.Location = new System.Drawing.Point(184, 101);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(298, 22);
            this.txtid.TabIndex = 1;
            // 
            // txtht
            // 
            this.txtht.Enabled = false;
            this.txtht.Location = new System.Drawing.Point(184, 157);
            this.txtht.Name = "txtht";
            this.txtht.Size = new System.Drawing.Size(302, 22);
            this.txtht.TabIndex = 2;
            // 
            // lblten
            // 
            this.lblten.AutoSize = true;
            this.lblten.Location = new System.Drawing.Point(85, 163);
            this.lblten.Name = "lblten";
            this.lblten.Size = new System.Drawing.Size(46, 16);
            this.lblten.TabIndex = 12;
            this.lblten.Text = "Họ tên";
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(85, 104);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(20, 16);
            this.lblid.TabIndex = 11;
            this.lblid.Text = "ID";
            // 
            // lblns
            // 
            this.lblns.AutoSize = true;
            this.lblns.Location = new System.Drawing.Point(85, 225);
            this.lblns.Name = "lblns";
            this.lblns.Size = new System.Drawing.Size(67, 16);
            this.lblns.TabIndex = 13;
            this.lblns.Text = "Ngày sinh";
            // 
            // dtpns
            // 
            this.dtpns.CustomFormat = "dd/MM/yyyy";
            this.dtpns.Enabled = false;
            this.dtpns.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpns.Location = new System.Drawing.Point(188, 219);
            this.dtpns.Name = "dtpns";
            this.dtpns.Size = new System.Drawing.Size(155, 22);
            this.dtpns.TabIndex = 3;
            // 
            // txtdiem
            // 
            this.txtdiem.Enabled = false;
            this.txtdiem.Location = new System.Drawing.Point(188, 287);
            this.txtdiem.Name = "txtdiem";
            this.txtdiem.Size = new System.Drawing.Size(302, 22);
            this.txtdiem.TabIndex = 4;
            // 
            // lbldiem
            // 
            this.lbldiem.AutoSize = true;
            this.lbldiem.Location = new System.Drawing.Point(85, 293);
            this.lbldiem.Name = "lbldiem";
            this.lbldiem.Size = new System.Drawing.Size(38, 16);
            this.lbldiem.TabIndex = 14;
            this.lbldiem.Text = "Điểm";
            // 
            // txttk
            // 
            this.txttk.Location = new System.Drawing.Point(88, 482);
            this.txttk.Name = "txttk";
            this.txttk.Size = new System.Drawing.Size(212, 22);
            this.txttk.TabIndex = 15;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1277, 715);
            this.Controls.Add(this.txttk);
            this.Controls.Add(this.lbldiem);
            this.Controls.Add(this.txtdiem);
            this.Controls.Add(this.dtpns);
            this.Controls.Add(this.lblns);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.lblten);
            this.Controls.Add(this.txtht);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.btnhuy);
            this.Controls.Add(this.btnghi);
            this.Controls.Add(this.btntk);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.dgvbang);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvbang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvbang;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btntk;
        private System.Windows.Forms.Button btnghi;
        private System.Windows.Forms.Button btnhuy;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtht;
        private System.Windows.Forms.Label lblten;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Label lblns;
        private System.Windows.Forms.DateTimePicker dtpns;
        private System.Windows.Forms.TextBox txtdiem;
        private System.Windows.Forms.Label lbldiem;
        private System.Windows.Forms.TextBox txttk;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

