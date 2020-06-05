using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Windows;
namespace QuanLyDiem
{
    public partial class FrmSinhVien : Form
    {
        DataTable tblSinhVien;
        public FrmSinhVien()
        {
            InitializeComponent();
            
        }


        private void FrmSinhVien_Load(object sender, EventArgs e)
        {
            LoadDatatogriview();
            btnLuu.Enabled = false;
            string sql = "select MaLop, TenLop from Lop";
            DAO.filldatatocombo(sql, cmbMaLop, "MaLop", "TenLop");//lớp
            sql = "select MaKhoa, TenKhoa from Khoa";
            DAO.filldatatocombo(sql, cmbMaKhoa, "MaKhoa", "TenKhoa");//khoa
            // sql = "select GioiTinh from SinhVien";
          //  DAO.filldatatocombo(sql, cmbMaQue, "GioiTinh", "GioiTinh");
            sql = "select MaQue, TenQue from Que";
            DAO.filldatatocombo(sql, cmbMaQue, "MaQue", "TenQue");//quê
            sql = "select MaDanToc, TenDanToc from DanToc";
            DAO.filldatatocombo(sql, cmbMaDanToc, "MaDanToc", "TenDanToc");//dân tộc
            sql = "select MaChuyenNganh, TenChuyenNganh from ChuyenNganh";
            DAO.filldatatocombo(sql, cmbMaChuyenNganh, "MaChuyenNganh", "TenChuyenNganh");//chuyên ngành
            sql = "select MaChucVu, TenChucVu from ChucVu";
            DAO.filldatatocombo(sql, cmbMaChucVu, "MaChucVu", "TenChucVu");//chức vụ 
            sql = "select MaHDT, TenHDT from HeDaoTao";
            DAO.filldatatocombo(sql, cmbMaHDT, "MaHDT", "TenHDT");
        }
        private void LoadDatatogriview()// LẤY DỮ LIỆU ĐỔ VÀO DATAGRIDVIEW
        {

            try
            {
                DAO.openconnection();
                string sql = " select * from SinhVien";
                tblSinhVien = DAO.GetDataToTable(sql);
                GridViewSinhVien.DataSource = tblSinhVien ;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                DAO.closeconnection();
            }

        }

        private void GridViewSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
    //        if (tblSinhVien.Rows.Count == 0)
    //        {
    //            MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK,
    //MessageBoxIcon.Information);
    //            return;
    //        }

            txtMaSV.Text = GridViewSinhVien.CurrentRow.Cells["clmMaSV"].Value.ToString();
            txtTenSV.Text = GridViewSinhVien.CurrentRow.Cells["clmTenSV"].Value.ToString();           
            string sql = "SELECT TenKhoa FROM Khoa WHERE MaKhoa='" + GridViewSinhVien.CurrentRow.Cells["clmMaKhoa"].Value.ToString() + "'";
            string s1 = "SELECT TenLop FROM Lop WHERE MaLop='" + GridViewSinhVien.CurrentRow.Cells["clmMaLop"].Value.ToString() + "'";              
            string s2 = "SELECT TenQue FROM Que WHERE MaQue='" + GridViewSinhVien.CurrentRow.Cells["clmMaQue"].Value.ToString() + "'";
            string s3 = "SELECT TenDanToc FROM DanToc WHERE MaDanToc='" + GridViewSinhVien.CurrentRow.Cells["clmMaDanToc"].Value.ToString() + "'";
            string s4 = "SELECT TenChuyenNganh FROM ChuyenNganh WHERE MaChuyenNganh='" + GridViewSinhVien.CurrentRow.Cells["clmMaChuyenNganh"].Value.ToString() + "'";
           string  s5 = "SELECT TenHDT FROM HeDaoTao WHERE MaHDT='" + GridViewSinhVien.CurrentRow.Cells["clmMaHDT"].Value.ToString() + "'";
            string s6 = "SELECT TenChucVu FROM ChucVu WHERE MaChucVu='" + GridViewSinhVien.CurrentRow.Cells["clmMaChucVu"].Value.ToString() + "'";
            cmbMaKhoa.Text = DAO.getfieldvalues(sql);
            cmbMaLop.Text = DAO.getfieldvalues(s1);
            mtbNgaySinh.Text = GridViewSinhVien.CurrentRow.Cells["clmNgaySinh"].Value.ToString();          
            cmbMaQue.Text = DAO.getfieldvalues(s2);
            cmbMaDanToc.Text = DAO.getfieldvalues(s3);
            cmbMaChuyenNganh.Text = DAO.getfieldvalues(s4);
            cmbMaHDT.Text = DAO.getfieldvalues(s5);
            cmbMaChucVu.Text = DAO.getfieldvalues(s6);

            if (GridViewSinhVien.CurrentRow.Cells["clmGioitinh"].Value.ToString() == "Nam")                
                checkGioiTinh.Checked = true;
            else
                checkGioiTinh.Checked = false;
            txtMaSV.Enabled = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ResetValues()
        {
            txtMaSV.Enabled = true;
            txtMaSV.Text = "";
            txtTenSV.Text = "";
           cmbMaKhoa .SelectedIndex = -1;
            cmbMaLop.SelectedIndex = -1;
            cmbMaQue.SelectedIndex = -1;
            cmbMaDanToc.SelectedIndex =-1;
            cmbMaHDT.SelectedIndex = -1;
            cmbMaChuyenNganh.SelectedIndex = -1;
            cmbMaChucVu.SelectedIndex = -1;
            checkGioiTinh.Checked = false;
            mtbNgaySinh.Text = "";
            GridViewSinhVien.Enabled = false;
      
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ResetValues();
            btnLuu.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string GioiTinh,sql;
            if (txtMaSV.Text == "")
            {
                MessageBox.Show("bạn không được để trống mã sinh viên");
                txtMaSV.Focus();
                return;
            }
            if (txtTenSV.Text == "")

            {
                MessageBox.Show("bạn không được để trống tên sinh viên");
                txtTenSV.Focus();
                return;
            }
            if (cmbMaKhoa.SelectedIndex == -1)
            {
                MessageBox.Show("bạn chưa chọn khoa");
                cmbMaKhoa.Focus();
                return;
            }
            if (cmbMaLop.SelectedIndex == -1)

            {
                MessageBox.Show("bạn chưa chọn  lớp");
                cmbMaLop.Focus();
                return;
            }
            if (cmbMaQue.SelectedIndex == -1)

            {
                MessageBox.Show(" bạn chưa chọn  khoa");
                cmbMaQue.Focus();
                return;
            }
            if (cmbMaDanToc.SelectedIndex == -1)

            {
                MessageBox.Show("bạn chưa chọn  dân tộc");
                cmbMaDanToc.Focus();
                return;
            }
            if (cmbMaHDT.SelectedIndex == -1)

            {
                MessageBox.Show("bạn chưa chọn hệ đào tạo");
                cmbMaHDT.Focus();
                return;
            }
            if (cmbMaChuyenNganh.SelectedIndex == -1)

            {
                MessageBox.Show("bạn chưa chọn chuyên ngành");
                cmbMaChuyenNganh.Focus();
                return;
            }
            if (cmbMaChucVu.SelectedIndex == -1)

            {
                MessageBox.Show("bạn chưa chọn chức vụ");
                cmbMaChucVu.Focus();
                return;
            }
           
            if (mtbNgaySinh.Text == "  /  /")

            {
                MessageBox.Show("bạn không để trống ngày sinh");
                mtbNgaySinh.Focus();
                return;
            }
            if (!DAO.IsDate(mtbNgaySinh.Text))
            {
                MessageBox.Show("Bạn phải nhập lại ngày sinh", "Thông báo",
MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mtbNgaySinh.Text = "";
                mtbNgaySinh.Focus();
                return;
            }
            if(checkGioiTinh.Checked==true)
            {
                MessageBox.Show("Giới tính sinh viên là nam", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                checkGioiTinh.Focus();
                return;
            }
            if (checkGioiTinh.Checked == true)
                GioiTinh = "Nam";
            else
                GioiTinh = "Nữ";
        
            string s1 = " select MaSV from SinhVien where MaSV =N'" + txtMaSV.Text.Trim() + "'";
            DAO.openconnection();
            if (DAO.check_key(s1))
            {
                MessageBox.Show(" mã sinh viên đã tồn tại", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DAO.closeconnection();
                txtMaSV.Focus();
                return;
            }
            else
            {
                 sql = " insert into SinhVien  values('" + txtMaSV.Text.Trim() + "',N'" + txtTenSV.Text.Trim() + "','" + cmbMaKhoa.SelectedValue.ToString() + "','" + cmbMaLop.SelectedValue.ToString() + "','"
                    + DAO.ConvertDateTime(mtbNgaySinh.Text) + "',N'" + GioiTinh + "','" + cmbMaQue.SelectedValue.ToString() + "','" + cmbMaDanToc.SelectedValue.ToString() + "','" + cmbMaChuyenNganh.SelectedValue.ToString()
                    + "','" + cmbMaHDT.SelectedValue.ToString() + "','" + cmbMaChucVu.SelectedValue.ToString() + "')";
                MessageBox.Show(sql);
                SqlCommand cmd = new SqlCommand(sql, DAO.con);// khai báo đổi tượng command
                cmd.CommandText = sql; // gán câu truy vấn
                cmd.Connection = DAO.con;
                cmd.ExecuteNonQuery();
                DAO.closeconnection();
                MessageBox.Show(" bạn đã thêm mới thành công", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDatatogriview();
               
                DAO.closeconnection();
                btnLuu.Enabled = false;
                txtMaSV.Enabled = false;
            }
        
    }

        private void btnSua_Click(object sender, EventArgs e)
        {

            if (tblSinhVien.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaSV.Text == "")
            {
                MessageBox.Show("Chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string sql, GioiTinh;
            if (txtTenSV.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên sinh viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenSV.Focus();
                return;
            }
            if (cmbMaKhoa.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập khoa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbMaKhoa.Focus();
                return;
            }
            if (cmbMaLop.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập lớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbMaLop.Focus();
                return;
            }
            if (cmbMaQue.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập quê", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbMaQue.Focus();
                return;
            }
            if (cmbMaDanToc.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập dân tôc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbMaDanToc.Focus();
                return;
            }
            if (cmbMaChucVu.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập chức vụ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbMaChucVu.Focus();
                return;
            }
            if (cmbMaChuyenNganh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập chuyên ngành", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbMaChuyenNganh.Focus();
                return;
            }
            if (mtbNgaySinh.Text == "  /  /")

            {
                MessageBox.Show("bạn không để trống ngày sinh");
                mtbNgaySinh.Focus();
                return;
            }
            if (!DAO.IsDate(mtbNgaySinh.Text))
            {
                MessageBox.Show("Bạn phải nhập lại ngày sinh", "Thông báo",
MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mtbNgaySinh.Text = "";
                mtbNgaySinh.Focus();
                return;
            }
            if (checkGioiTinh.Checked == true)
                GioiTinh = "Nam";
            else 
                GioiTinh = "Nữ";
               
            sql = "UPDATE SinhVien SET  TenSV=N'" +  txtTenSV.Text.ToString() +
                    "',MaKhoa='" + cmbMaKhoa.SelectedValue.ToString() + "',MaLop='" + cmbMaLop.SelectedValue.ToString() +
                    "',NgaySinh='"+DAO.ConvertDateTime(mtbNgaySinh.Text)+"',GioiTinh=N'"+GioiTinh
                    +"',MaQue='" +cmbMaQue.SelectedValue.ToString() +
                    "',MaDanToc='" + cmbMaDanToc.SelectedValue.ToString() +"',MaChuyenNganh='"+ cmbMaChuyenNganh.SelectedValue.ToString()+"',MaHDT='"+cmbMaHDT.SelectedValue.ToString()+"',MaChucVu='"+cmbMaChucVu.SelectedValue.ToString()+
                    "' WHERE MaSV='" + txtMaSV.Text + "'";
            MessageBox.Show(sql);
            DAO.openconnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sql;
            cmd.Connection = DAO.con;
            cmd.ExecuteNonQuery();//thực thi câu lệnh
            DAO.closeconnection();
            LoadDatatogriview();

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (tblSinhVien.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaSV.Text == "")
            {
                MessageBox.Show("Chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("bạn có muốn xóa không?", "thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                string sql = " delete from SinhVien where MaSV='" + txtMaSV.Text + "'";
                DAO.openconnection();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = sql;
                cmd.Connection = DAO.con;
                cmd.ExecuteNonQuery();
                DAO.closeconnection();
                ResetValues();
                LoadDatatogriview();
                //LoadDatatogriview();
            }

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ResetValues();
            btnHuy.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            txtMaSV.Enabled = false;
            GridViewSinhVien.Enabled = true;

        }

        
    }
}
