﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using _1.DAL.DomainClass;
using _2.BUS.IServices;
using _2.BUS.Services;

namespace _3.PL.Views
{
    public partial class Frm_Main : Form
    {
        private Form activeForm;
        private IQLGiaoCaServices _iQLGiaoCaServices;
        private IQLChucVuServices _iQLChucVuServices;
        public NhanVien nv { get; set; }
        public Frm_Main()
        {
            InitializeComponent();
            //lấy kích thước của màn hình
            int widthScreen = Screen.PrimaryScreen.WorkingArea.Width;
            int heightScreen = Screen.PrimaryScreen.WorkingArea.Height;

            //cho form hiển thị theo kích thước của màn hình
            this.Width = widthScreen;
            this.Height = heightScreen;
            _iQLGiaoCaServices = new QLGiaoCaServices();
            _iQLChucVuServices = new QLChucVuServices();    
            //pnl_Nav.Height = btn_banHang.Height;
            //pnl_Nav.Top = btn_banHang.Top;
            //pnl_Nav.Left = btn_banHang.Left;
            lbl_doanhthuca.Text = "0";
            // List ca được tạo trong ngày hôm nay với thời gian tăng dần
            List<GiaoCa> catrongngay = _iQLGiaoCaServices.GetAll().Where(c => Convert.ToDateTime(c.ThoiGianVaoCa).Day == DateTime.Now.Day).ToList();

            lbl_doanhthungay.Text = String.Format("{0:0,00}", catrongngay.Sum(c => c.Tongtienhang).ToString());
            lbl_tientaiquay.Text = "0";

        }
        private void Frm_Main_Load(object sender, EventArgs e)
        {
            lbl_Ten.Text = nv.Ho + " " + nv.TenDem + " " + nv.Ten;
            pnl_menucon.Visible = false;
            tbx_giohethong.Text = Convert.ToString(DateTime.Now);
            Frm_VaoCa frm_QLVaoCa = new Frm_VaoCa(nv);
            frm_QLVaoCa.frm_Main = this;
            if(_iQLChucVuServices.GetByID(nv.IdCv).Ten=="Nhân viên")
            {
                btn_sanpham.Visible = false;
                btn_thuoctinh.Visible = false;
                btn_nhanvien.Visible = false;
                btn_khuyenmai.Visible = false;
                btn_QLTichDiem.Visible = false;
            }    
            frm_QLVaoCa.ShowDialog();

        }
        private void btn_banHang_Click(object sender, EventArgs e)
        {
            //pnl_Nav.Height = btn_banHang.Height;
            //pnl_Nav.Top = btn_banHang.Top;
            //pnl_Nav.Left = btn_banHang.Left;
            lbl_tilte.Text = "BÁN HÀNG";
            hideMenuCon();
            //if(DialogResult.Yes == MessageBox.Show("Bạn có chắc chắn vào ca?", "", MessageBoxButtons.YesNo)){
            Frm_BanHang frm_BanHang = new Frm_BanHang();
            frm_BanHang._nhanVien = nv;
            frm_BanHang.frmmain = this;
            OpenChildForm(frm_BanHang, sender);
        }

        private void btn_sanpham_Click(object sender, EventArgs e)
        {
            //pnl_Nav.Height = btn_sanpham.Height;
            //pnl_Nav.Top = btn_sanpham.Top;
            //pnl_Nav.Left = btn_sanpham.Left;
            //btn_sanpham.BackColor = Color.FromArgb(46, 51, 73);
            lbl_tilte.Text = "SẢN PHẨM";
            hideMenuCon();
            OpenChildForm(new Frm_ChiTietSanPham(), sender);

        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.pnl_desktop.Controls.Add(childForm);
            this.pnl_desktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void btn_banHang_Leave(object sender, EventArgs e)
        {
            //btn_banHang.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btn_sanpham_Leave(object sender, EventArgs e)
        {
            //btn_sanpham.BackColor = Color.FromArgb(24, 30, 54);
        }
        private void btn_thuoctinh_Click_1(object sender, EventArgs e)
        {
            //pnl_Nav.Height = btn_thuoctinh.Height;
            //pnl_Nav.Top = btn_thuoctinh.Top;
            //pnl_Nav.Left = btn_thuoctinh.Left;
            //btn_thuoctinh.BackColor = Color.FromArgb(46, 51, 73);
            lbl_tilte.Text = "QUẢN LÝ THUỘC TÍNH";
            ShowMenucon(pnl_menucon);
        }

        private void btn_thuoctinh_Leave_1(object sender, EventArgs e)
        {
            //btn_thuoctinh.BackColor = Color.FromArgb(24, 30, 54);
        }
        private void hideMenuCon()
        {
            if (pnl_menucon.Visible == true)
                pnl_menucon.Visible = false;
        }
        private void ShowMenucon(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                hideMenuCon();
                submenu.Visible = true;
            }
            else
            {
                submenu.Visible = false;
            }
        }
        private void btn_sp_Click(object sender, EventArgs e)
        {
            //btn_sp.BackColor = Color.FromArgb(80, 87, 122);
            lbl_tilte.Text = "SẢN PHẨM";
            OpenChildForm(new Frm_SanPham(), sender);
        }

        private void btn_lsp_Click(object sender, EventArgs e)
        {
            //btn_lsp.BackColor = Color.FromArgb(80, 87, 122);
            lbl_tilte.Text = "LOẠI SẢN PHẨM";
            OpenChildForm(new Frm_LoaiSP(), sender);
        }

        private void btn_clieu_Click(object sender, EventArgs e)
        {
            //btn_clieu.BackColor = Color.FromArgb(80, 87, 122);
            lbl_tilte.Text = "CHẤT LIỆU";
            OpenChildForm(new Frm_ChatLieu(), sender);
        }

        private void btn_mausac_Click(object sender, EventArgs e)
        {
            //btn_mausac.BackColor = Color.FromArgb(80, 87, 122);
            lbl_tilte.Text = "MÀU SẮC";
            OpenChildForm(new Frm_MauSac(), sender);
        }

        private void btn_kichthuoc_Click(object sender, EventArgs e)
        {
            //btn_kichthuoc.BackColor = Color.FromArgb(80, 87, 122);
            lbl_tilte.Text = "KÍCH THƯỚC";
            OpenChildForm(new Frm_KichThuoc(), sender);
        }
        private void btn_khachhang_Click_1(object sender, EventArgs e)
        {
            hideMenuCon();
            //pnl_Nav.Height = btn_khachhang.Height;
            //pnl_Nav.Top = btn_khachhang.Top;
            //pnl_Nav.Left = btn_khachhang.Left;
            //btn_khachhang.BackColor = Color.FromArgb(46, 51, 73);
            lbl_tilte.Text = "KHÁCH HÀNG";
            OpenChildForm(new Frm_KhachHang(), sender);
        }

        private void btn_khuyenmai_Click(object sender, EventArgs e)
        {
            hideMenuCon();
            //pnl_Nav.Height = btn_khuyenmai.Height;
            //pnl_Nav.Top = btn_khuyenmai.Top;
            //pnl_Nav.Left = btn_khuyenmai.Left;
            //btn_khuyenmai.BackColor = Color.FromArgb(46, 51, 73);
            lbl_tilte.Text = "KHUYẾN MÃI";
            OpenChildForm(new FrmKhuyenMai(), sender);
        }

        private void btn_sp_Leave(object sender, EventArgs e)
        {
            //btn_sp.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btn_nsx_Leave(object sender, EventArgs e)
        {
            //btn_nsx.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btn_lsp_Leave(object sender, EventArgs e)
        {
            //btn_lsp.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btn_clieu_Leave(object sender, EventArgs e)
        {
            //btn_clieu.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btn_mausac_Leave(object sender, EventArgs e)
        {
            //btn_mausac.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btn_kichthuoc_Leave(object sender, EventArgs e)
        {
            //btn_kichthuoc.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btn_nhanvien_Leave_1(object sender, EventArgs e)
        {
            //btn_nhanvien.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btn_khachhang_Leave_1(object sender, EventArgs e)
        {
            //btn_khachhang.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btn_khuyenmai_Leave(object sender, EventArgs e)
        {
            //btn_khuyenmai.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btn_nsx_Click(object sender, EventArgs e)
        {
            //btn_nsx.BackColor = Color.FromArgb(107, 114, 142);
            lbl_tilte.Text = "NHÀ SẢN XUẤT";
            OpenChildForm(new Frm_NSX(), sender);
        }

        private void btn_nhanvien_Click_1(object sender, EventArgs e)
        {
            hideMenuCon();
            //pnl_Nav.Height = btn_nhanvien.Height;
            //pnl_Nav.Top = btn_nhanvien.Top;
            //pnl_Nav.Left = btn_nhanvien.Left;
            //btn_nhanvien.BackColor = Color.FromArgb(46, 51, 73);
            lbl_tilte.Text = "NHÂN VIÊN";
            OpenChildForm(new Frm_NhanVien(), sender);
        }
        private void btn_QLTichDiem_Click(object sender, EventArgs e)
        {
            hideMenuCon();
            //pnl_Nav.Height = btn_QLTichDiem.Height;
            //pnl_Nav.Top = btn_QLTichDiem.Top;
            //pnl_Nav.Left = btn_QLTichDiem.Left;
            //btn_QLTichDiem.BackColor = Color.FromArgb(46, 51, 73);
            OpenChildForm(new Frm_ThietLapDiem(), sender);
        }

        private void btn_ketca_Click_1(object sender, EventArgs e)
        {
            hideMenuCon();
            //pnl_Nav.Height = btn_nhanvien.Height;
            //pnl_Nav.Top = btn_nhanvien.Top;
            //pnl_Nav.Left = btn_nhanvien.Left;
            //btn_nhanvien.BackColor = Color.FromArgb(46, 51, 73);
            OpenChildForm(new Frm_KetCa(), sender);
        }

        private void btn_thongke_Click(object sender, EventArgs e)
        {
            hideMenuCon();
            //pnl_Nav.Height = btn_thongke.Height;
            //pnl_Nav.Top = btn_thongke.Top;
            //pnl_Nav.Left = btn_thongke.Left;
            //btn_thongke.BackColor = Color.FromArgb(46, 51, 73);
            lbl_tilte.Text = "THỐNG KÊ";
            OpenChildForm(new Frm_ThongKe(), sender);
        }




        //private void btn_tichdiem_Click(object sender, EventArgs e)
        //{
        //    pnl_Nav.Height = btn_tichdiem.Height;
        //    pnl_Nav.Top = btn_tichdiem.Top;
        //    pnl_Nav.Left = btn_tichdiem.Left;
        //    btn_tichdiem.BackColor = Color.FromArgb(46, 51, 73);
        //    lbl_tilte.Text = "QUẢN LÝ TÍCH ĐIỂM";
        //    hideMenuCon();
        //}

        //private void btn_tichdiem_Leave(object sender, EventArgs e)
        //{
        //    btn_tichdiem.BackColor = Color.FromArgb(24, 30, 54);
        //}
    }
}
