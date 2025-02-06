namespace BusinessLogic.Dtos
{
    public class TaiSanDto
    {
        public string SoThe { get; set; } // Số thẻ
        public string TenTaiSan { get; set; } // Tên tài sản
        public string KyHieu { get; set; } // Ký hiệu
        public string SoMay { get; set; } // Số máy
        public string HangSX { get; set; } // Hãng sản xuất
        public int NamSD { get; set; } // Năm sử dụng
        public int SoNamSD { get; set; } // Số năm sử dụng
        public string TinhTrang { get; set; } // Tình trạng
        public string TrangThai { get; set; } // Trạng thái
        public string ChiNhanhQL { get; set; } // Chi nhánh quản lý
        public string ChiNhanhTT { get; set; } // Chi nhánh trực thuộc
        public string ViTri { get; set; } // Vị trí
    }
}
