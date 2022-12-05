using _1.DAL.DomainClass;
using _2.BUS.IServices;
using _2.BUS.Services;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace _3.PresentationLayers.Views
{
    public partial class Frm_QuanLyDonHang : Form
    {
        private DonHangService donHangService = new DonHangService();
        private NhanVienService nhanVienService = new NhanVienService();
        private KhachHangService KhachHangService = new KhachHangService();
        private ShipperService shipperService = new ShipperService();
        public int ID;
        private Donhang dh;
        private int SelectID;
        public Frm_QuanLyDonHang()
        {
            InitializeComponent();
            loaddata();
            loadcombb();
        }
        public void loadcombb()
        {
            foreach (var item in nhanVienService.GetNhanviens())
            {
                cbb_nguoiban.Items.Add(item.Ten);
            }
            foreach (var item in KhachHangService.getAll())
            {
                cbb_nguoimua.Items.Add(item.HoTen);
            }    
            foreach (var item in shipperService.GetShippers())
            {
                cbb_nguoigiao.Items.Add(item.Hoten);
            }    
        }
        public void loaddata()
        {
            dtg_show.ColumnCount = 5;
            dtg_show.Columns[0].Name = "Id";
            dtg_show.Columns[0].Visible= false;
            dtg_show.Columns[1].Name= "Người bán";
            dtg_show.Columns[2].Name = "Người mua";
            dtg_show.Columns[3].Name = "Ngày Đặt Hàng";
            dtg_show.Columns[4].Name = "Người giao";
            dtg_show.Rows.Clear();
            foreach ( var item in donHangService.getallView().OrderBy(x => x.Donhang.DonhangId))
            {
                dtg_show.Rows.Add(item.Donhang.DonhangId,item.nhanvien.Ten, item.khachhang.HoTen, item.Donhang.Ngaydathang,item.shipper.Hoten);
            }    
        }

        private void dtg_show_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = dtg_show.Rows[e.RowIndex];
                dh = donHangService.getAll().FirstOrDefault(x => x.DonhangId == int.Parse(r.Cells[0].Value.ToString()));
                SelectID = int.Parse(r.Cells[0].Value.ToString());
                cbb_nguoiban.Text = nhanVienService.GetNhanviens().FirstOrDefault(x => x.NhanviennId == dh.NhanvienId).Ten;
                cbb_nguoimua.Text = KhachHangService.getAll().FirstOrDefault(x => x.KhachhangId == dh.KhachhangId).HoTen;
                cbb_nguoigiao.Text = shipperService.GetShippers().FirstOrDefault(x => x.ShipperId == dh.ShipperId).Hoten;
                dTP_ngayban.Text = r.Cells[3].Value.ToString(); 
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            loaddata();
            dh = null;
            cbb_nguoiban.Text = "";
            cbb_nguoimua.Text = "";
            cbb_nguoigiao.Text = "";
            dTP_ngayban.Text = "";
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_xemchitiet_Click(object sender, EventArgs e)
        {
            Frm_ChiTietDonHang frm = new Frm_ChiTietDonHang();
            frm.ShowDialog();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn muốn thêm không", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show(donHangService.add(new Donhang()
                {
                    DonhangId = new int(),
                    NhanvienId = cbb_nguoiban.Text != "" ? nhanVienService.GetNhanviens().FirstOrDefault(x => x.Ten == cbb_nguoiban.Text).NhanviennId : null,
                    KhachhangId = cbb_nguoimua.Text != "" ? KhachHangService.getAll().FirstOrDefault(x => x.HoTen == cbb_nguoimua.Text).KhachhangId : null,
                    ShipperId = cbb_nguoigiao.Text != "" ? shipperService.GetShippers().FirstOrDefault(x => x.Hoten == cbb_nguoigiao.Text).ShipperId : null,
                    //Ngaydathang = dtg_show.Text,
                }));
                loaddata();
            }
            else
            {

                return;

            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn muốn sửa không", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show(donHangService.update(new Donhang()
                {
                    DonhangId = new int(),
                    NhanvienId = cbb_nguoiban.Text != "" ? nhanVienService.GetNhanviens().FirstOrDefault(x => x.Ten == cbb_nguoiban.Text).NhanviennId : null,
                    KhachhangId = cbb_nguoimua.Text != "" ? KhachHangService.getAll().FirstOrDefault(x => x.HoTen == cbb_nguoimua.Text).KhachhangId : null,
                    ShipperId = cbb_nguoigiao.Text != "" ? shipperService.GetShippers().FirstOrDefault(x => x.Hoten == cbb_nguoigiao.Text).ShipperId : null,
                    //Ngaydathang = dTP_ngayban.Text,
                }));
                loaddata();
            }
            else
            {

                return;

            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn muốn xóa không", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show(donHangService.delete(dh));
                loaddata();
            }
            else
            {
                return;
            }
        }
    }
}
