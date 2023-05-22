using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDiem
{
    public partial class Form1 : Form
    {
        public static string connectionString = "data source= localhost; database = QLDiem; user id=sa; password= 11122003;TrustServerCertificate=true";
        public static String Status="";
        public Form1()
        {
            InitializeComponent();
            Set("Resert");
            BindingData();
        }
        public void Set(string State)
        {
            switch (State)
            {
                case "Resert":
                    btnthem.Enabled = true;
                    btnsua.Enabled = true;
                    btnxoa.Enabled = true;
                    btnghi.Enabled = false;
                    btnhuy.Enabled = false;
                    txtid.Enabled = false;
                    txtht.Enabled = false;
                    txtdiem.Enabled = false;
                    dtpns.Enabled = false;
                    break;
                case "Insert":
                    btnthem.Enabled = false;
                    btnsua.Enabled = false;
                    btnxoa.Enabled = false;
                    btnghi.Enabled = true;
                    btnhuy.Enabled = true;

                    txtid.Enabled = true;
                    txtht.Enabled = true;
                    txtdiem.Enabled = true;
                    dtpns.Enabled = true;

                    txtid.Text = "";
                    txtht.Text = "";
                    txtdiem.Text = "";
                    dtpns.Enabled = true;
                    txtid.Focus();
                    break;
                case "Edit":
                    btnthem.Enabled = false;
                    btnsua.Enabled = false;
                    btnxoa.Enabled = false;
                    btnghi.Enabled = true;
                    btnhuy.Enabled = true;

                    txtid.Enabled = false;
                    txtht.Enabled = true;
                    txtdiem.Enabled = true;
                    dtpns.Enabled = true;
                    txtid.Focus();
                    break;
            }
        }
        public void BindingData()
        {
            try
            {
                SqlConnection conn = new SqlConnection(connectionString);
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string query = "Select * from tbl_Diem";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    dgvbang.DataSource = ds.Tables[0];

                    txtid.Text = ds.Tables[0].Rows[0]["id"].ToString();
                    txtht.Text = ds.Tables[0].Rows[0]["tensv"].ToString();
                    txtdiem.Text = ds.Tables[0].Rows[0]["diem"].ToString();
                    dtpns.Value = Convert.ToDateTime(ds.Tables[0].Rows[0]["ngaysinh"]);
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnthem_Click(object sender, EventArgs e)
        {
            Status = "Insert";
            Set(Status);

        }

        private void btnghi_Click(object sender, EventArgs e)
        {
            try
            {
                //ID
                bool a = true; int b; int c = 0;
                
                errorProvider1.Clear();
                if (txtid.Text == "")
                {
                    a = false;
                    errorProvider1.SetError(txtid, "Chưa nhập ID");
                }
                else
                {
                    if(int.TryParse(txtid.Text, out b)==false)
                    {
                        a = false;
                        errorProvider1.SetError(txtid, "ID sai định dạng");
                    }
                }
                //HT
                if(txtht.Text == "")
                {
                    a = false;
                    errorProvider1.SetError(txtht, "Chưa nhập họ tên");
                }
                else
                {
                    string s= txtht.Text;
                    for(int i=0;i<s.Length; i++)
                    {
                        if ((s[i] <= 'z' && s[i]>= 'a') || (s[i] <= 'Z' && s[i] >= 'A'))
                        {
                            c++;
                        }
                    }
                    if (c != s.Length)
                    {
                        a=false;
                        errorProvider1.SetError(txtht, "Họ tên sai định dạng");
                    }
                    //if (int.TryParse(txtht.Text, out b) == true)
                    //{
                    //    a = false;
                    //    errorProvider1.SetError(txtht, "Họ tên sai định dạng");
                    //}
                }
                // Diem
                if (txtdiem.Text == "")
                {
                    a = false;
                    errorProvider1.SetError(txtdiem, "Chưa nhập điểm");
                }
                else
                {
                    if(int.TryParse(txtdiem.Text, out b) == false){
                        a = false;
                        errorProvider1.SetError(txtdiem, "Điểm sai định dạng");
                    }
                    else if((int.Parse(txtdiem.Text) < 0) || (int.Parse(txtdiem.Text) >= 10))
                    {
                        a = false;
                        errorProvider1.SetError(txtdiem, "Điểm sai định dạng");
                    }
                    
                } 

                if (Status == "Insert"&&a==true)
                {
                    SqlConnection conn = new SqlConnection(connectionString);
                    if(conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }
                    string query = "INSERT INTO tbl_diem VALUES('" + txtid.Text.Trim() + "',N'" + txtht.Text.Trim() + "','" + dtpns.Value.ToString("MM/dd/yyyy") + "',N'" + txtdiem.Text.Trim() + "')";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    var result= cmd.ExecuteNonQuery();
                    if (result > 0) {
                        MessageBox.Show("Insert success");
                        Status = "Resert";
                        Set(Status);
                        BindingData();
                    }
                    else
                    {
                        MessageBox.Show("Insert error");
                    }
                }
                else if (Status == "Edit" && a == true)
                {
                    SqlConnection conn = new SqlConnection(connectionString);
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }
                    string query = "UPDATE dbo.tbl_diem SET tensv= N'" + txtht.Text.Trim() + "',ngaysinh='" + dtpns.Value + "',diem='" + txtdiem.Text.Trim() + "'WHERE id='"+txtid.Text.Trim()+"'";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    var result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Edit success");
                        Status = "Resert";
                        Set(Status);
                        BindingData();
                    }
                    else
                    {
                        MessageBox.Show("Edit error");
                    }
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            Status = "Edit";
            Set(Status);
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            if(conn.State == ConnectionState.Closed)
            {
                conn.Open() ;
            }
            string query = "DELETE dbo.tbl_diem WHERE id='" + txtid.Text.Trim() + "'";
            SqlCommand cmd= new SqlCommand(query, conn);
            var result = cmd.ExecuteNonQuery();
            if (result > 0)
            {
                MessageBox.Show("Delete success");
                Status = "Resert";
                Set(Status);
                BindingData();
            }
            else
            {
                MessageBox.Show("Delete error");
            }
        }

        private void dgvbang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvbang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = (DataGridViewRow)dgvbang.Rows[e.RowIndex];
            txtid.Text = row.Cells["id"].Value.ToString();
            txtht.Text = row.Cells["tensv"].Value.ToString();
            dtpns.Value = Convert.ToDateTime(row.Cells["ngaysinh"].Value);
            txtdiem.Text = row.Cells["diem"].Value.ToString();
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            Status = "Resert";
            Set(Status );
        }

        private void btntk_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(connectionString);
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string query = "SELECT *FROM dbo.tbl_diem WHERE tensv LIKE N'%" + txttk.Text.Trim() + "%'";
                SqlCommand cmd = new SqlCommand(query,conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
               // string a = txttk.Text;
                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    Status = "Resert";
                    Set(Status);
                    txttk.Focus();
                    dgvbang.DataSource = ds.Tables[0];
                    txtid.Text = ds.Tables[0].Rows[0]["id"].ToString();
                    txtht.Text = ds.Tables[0].Rows[0]["tensv"].ToString();
                    txtdiem.Text = ds.Tables[0].Rows[0]["diem"].ToString();
                    dtpns.Value = Convert.ToDateTime(ds.Tables[0].Rows[0]["ngaysinh"]);
                }
                else
                {
                    MessageBox.Show("Tìm kiếm thất bại");
                }
                conn.Close();
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
