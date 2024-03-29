﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _2.BUS.Services;

namespace _3.PL.Views
{
    public partial class Frm_ThietLapDiem : Form
    {
        private QuyDoiDiemServices _quyDoiDiemServices = new QuyDoiDiemServices();
        public Frm_ThietLapDiem()
        {
            InitializeComponent();
            LoadDTG_Diem();
        }
        public void LoadDTG_Diem()
        {
            try
            {
                dtg_Diem.Rows.Clear();
                dtg_Diem.ColumnCount = 5;
                dtg_Diem.Columns[0].Name = "STT";
                dtg_Diem.Columns[1].Name = "Tỉ lệ tích điểm";
                dtg_Diem.Columns[2].Name = "Tỉ lệ tiêu điểm";
                dtg_Diem.Columns[3].Name = "Trạng thái";
                dtg_Diem.Columns[4].Name = "Id";
                dtg_Diem.Columns[4].Visible = false;
                int stt = 1;
                foreach (var x in _quyDoiDiemServices.GetAll())
                {
                    dtg_Diem.Rows.Add(stt++, x.TiLeTichDiem, x.TiLeTieuDiem, x.TrangThai, x.Id);
                }
            }    
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show(_quyDoiDiemServices.CreateQuyDoiDiem(Convert.ToDecimal(tbx_Tien1.Text), Convert.ToDecimal(tbx_Tien2.Text), chbx_Check.Checked ? 1 : 2));
                LoadDTG_Diem();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btn_BoQua_Click(object sender, EventArgs e)
        {

        }
        private void dtg_Diem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                tbx_Tien1.Text = dtg_Diem.CurrentRow.Cells[1].Value.ToString();
                tbx_Tien2.Text = dtg_Diem.CurrentRow.Cells[2].Value.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }           
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
