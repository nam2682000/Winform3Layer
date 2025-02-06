using BusinessLogic.Dtos;
using BusinessLogic.Interface;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Presentation
{
    public partial class TaiSan : Form
    {
        private readonly ITaiSanService _taiSanService;
        private string soThe = null;
        public TaiSan(ITaiSanService taiSanService)
        {
            _taiSanService = taiSanService;
            InitializeComponent();
            InitComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadTaiSan();
        }

        private void LoadTaiSan()
        {
            var data = _taiSanService.GetAll();
            viewTaiSan.DataSource = data;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _taiSanService.DeleteTaiSan(soThe);
            LoadTaiSan();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var data = GetTaiSanByComponent();
            data.SoThe = soThe;
            _taiSanService.UpdateTaiSan(data);
            SetComponentByTaiSan(data);
            LoadTaiSan();
        }

        private void viewTaiSan_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush brush = new SolidBrush(viewTaiSan.RowHeadersDefaultCellStyle.ForeColor))
            {
                string stt = (e.RowIndex + 1).ToString(); // Tính số thứ tự
                e.Graphics.DrawString(
                    stt,
                    viewTaiSan.DefaultCellStyle.Font,
                    brush,
                    e.RowBounds.Location.X + 10, // Vị trí X của số thứ tự
                    e.RowBounds.Location.Y + 4  // Vị trí Y của số thứ tự
                );
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var data = GetTaiSanByComponent();
            _taiSanService.AddTaiSan(data);
            LoadTaiSan();
        }

        private void InitComponent()
        {
            cbChiNhanhQL.DropDownStyle = ComboBoxStyle.DropDownList;
            cbChiNhanhQL.Items.Add("LGG");
            cbChiNhanhQL.Items.Add("TNN");
            cbChiNhanhQL.SelectedIndex = 0;


            cbTinhTrang.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTinhTrang.Items.Add("Tốt");
            cbTinhTrang.Items.Add("Trung Bình");
            cbTinhTrang.Items.Add("Kém");
            cbTinhTrang.SelectedIndex = 0;

            cbTrangThai.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTrangThai.Items.Add("Đang sử dụng");
            cbTrangThai.Items.Add("Không sử dụng");
            cbTrangThai.SelectedIndex = 0;

            cbFillterChiNhanh.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFillterChiNhanh.Items.Add("Tất cả");
            cbFillterChiNhanh.Items.Add("LGG");
            cbFillterChiNhanh.Items.Add("TNN");

            cbFillterTinhTrang.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFillterTinhTrang.Items.Add("Tất cả");
            cbFillterTinhTrang.Items.Add("Đang sử dụng");
            cbFillterTinhTrang.Items.Add("Không sử dụng");



            // Thiết lập NumericUpDown
            numSoNamSD.Minimum = 0; // Số lượng tối thiểu
            numSoNamSD.Maximum = 100; // Số lượng tối đa
            numSoNamSD.Value = 0; // Giá trị mặc định
            numSoNamSD.Increment = 1; // Bước nhảy

            numNamSD.Minimum = 2023; // Số lượng tối thiểu
            numNamSD.Maximum = 2026; // Giá trị mặc định
            numNamSD.Value = 2025; // Giá trị mặc định
            numNamSD.Increment = 1; // Bước nhảy
        }

        private TaiSanDto GetTaiSanByComponent()
        {
            var tinhTrang = cbTinhTrang.SelectedItem != null ? cbTinhTrang.SelectedItem.ToString() : string.Empty;
            var chiNhanhQL = cbChiNhanhQL.SelectedItem != null ? cbChiNhanhQL.SelectedItem.ToString() : string.Empty;
            var data = new TaiSanDto()
            {
                ChiNhanhQL = chiNhanhQL,
                ChiNhanhTT = txtChiNhanhTT.Text.Trim(),
                HangSX = txtHangSX.Text.Trim(),
                KyHieu = txtKyHieuil.Text.Trim(),
                NamSD = (int)numNamSD.Value,
                SoMay = txtSoMay.Text.Trim(),
                SoNamSD = (int)numSoNamSD.Value,
                TenTaiSan = txtTenTaiSan.Text.Trim(),
                TinhTrang = tinhTrang,
                TrangThai = tinhTrang, // Nếu khác, cần logic riêng
                ViTri = txtViTri.Text.Trim(),
            };
            return data;
        }

        private void SetComponentByTaiSan(TaiSanDto taiSan)
        {
            cbChiNhanhQL.SelectedItem = taiSan.ChiNhanhQL ?? string.Empty;
            cbTinhTrang.SelectedItem = taiSan.TinhTrang ?? string.Empty;

            txtChiNhanhTT.Text = taiSan.ChiNhanhTT ?? string.Empty;
            txtHangSX.Text = taiSan.HangSX ?? string.Empty;
            txtKyHieuil.Text = taiSan.KyHieu ?? string.Empty;
            txtSoMay.Text = taiSan.SoMay ?? string.Empty;
            txtTenTaiSan.Text = taiSan.TenTaiSan ?? string.Empty;
            txtViTri.Text = taiSan.ViTri ?? string.Empty;

            numNamSD.Value = taiSan.NamSD > numNamSD.Maximum
                ? numNamSD.Maximum
                : taiSan.NamSD < numNamSD.Minimum
                    ? numNamSD.Minimum
                    : taiSan.NamSD;

            numSoNamSD.Value = taiSan.SoNamSD > numSoNamSD.Maximum
                ? numSoNamSD.Maximum
                : taiSan.SoNamSD < numSoNamSD.Minimum
                    ? numSoNamSD.Minimum
                    : taiSan.SoNamSD;

            cbTinhTrang.SelectedItem = taiSan.TrangThai ?? string.Empty;
        }

        private void viewTaiSan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Lấy giá trị từ ô được nhấp
                soThe = viewTaiSan.Rows[e.RowIndex].Cells[0].Value.ToString();
                var data = _taiSanService.Get(soThe);
                SetComponentByTaiSan(data); 
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            var cbChiNhanh = cbFillterChiNhanh.SelectedItem;
            var cbTinhTrang = cbFillterTinhTrang.SelectedItem;

            string chiNhanh = cbChiNhanh != null && cbChiNhanh != "Tất cả" ? cbFillterChiNhanh.SelectedItem.ToString() : null;
            string tinhTrang = cbTinhTrang != null && cbTinhTrang != "Tất cả" ? cbFillterTinhTrang.SelectedItem.ToString() : null;

            var data = _taiSanService.GetTaiSanFilter(chiNhanh,tinhTrang);
            viewTaiSan.DataSource = data;
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            BaoCao formSecond = new BaoCao(_taiSanService);
            // Hiển thị FormSecond
            formSecond.Show();
        }
    }
}
