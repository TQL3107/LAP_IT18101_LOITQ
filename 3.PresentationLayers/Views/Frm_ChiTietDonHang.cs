using _1.DAL.DomainClass;
using _2.BUS.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3.PresentationLayers.Views
{
    public partial class Frm_ChiTietDonHang : Form
    {
        private DonHangChiTietService donHangChiTietService = new DonHangChiTietService();  
        private SanPhamService sanPhamService = new SanPhamService();
        private DonHangService DonHangService = new DonHangService();
        public Frm_ChiTietDonHang()
        {
            InitializeComponent();
            loadcombobox();
            loadData(); 
        }
        public void loadcombobox()
        {
            foreach (var item in sanPhamService.GetSanphams())
            {
                cbb_sanpham.Items.Add(item.TenSanpham);
            }
        }
        public void loadData()
        {
            int stt = 1;
            dtg_show.ColumnCount = 9;
            dtg_show.Columns[0].Name = "STT";
            dtg_show.Columns[1].Name = "Id";
            dtg_show.Columns[1].Visible = false;
            dtg_show.Columns[2].Name = "Tên Sản phẩm";
            dtg_show.Columns[3].Name = "Danh mục ";
            dtg_show.Columns[4].Name = "Nhà cung cấp";
            dtg_show.Columns[5].Name = "Đơn vị tính";
            dtg_show.Columns[6].Name = "Số lượng";
            dtg_show.Columns[7].Name = "Đơn giá";
            dtg_show.Columns[8].Name = "Thanh toán";
            dtg_show.Rows.Clear();
            foreach (var item in donHangChiTietService.GetViews().OrderBy(x=>x.donhangChitiet.DonhangChitietId))
            {
                dtg_show.Rows.Add(stt++,
                    item.donhangChitiet.DonhangChitietId,
                                   item.sanpham.TenSanpham,
                                   item.sanpham.DanhmucId,
                                   item.sanpham.CungcapId,
                                   item.sanpham.Donvi,
                                   item.donhangChitiet.Soluong,
                                   item.sanpham.Gia) ;
            }    
        }
    }
}
