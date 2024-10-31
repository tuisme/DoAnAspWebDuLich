namespace dulichaspnet.Models
{
    public class TuyenDuong
    {
        public int Id { get; set; }
        public string Loai { get; set; }
        public int CongTyId { get; set; }
        public CongTyVanTai CongTy { get; set; }
        public string DiemBatDau { get; set; }
        public string DiemKetThuc { get; set; }
        public DateTime ThoiGianKhoiHanh { get; set; }
        public DateTime ThoiGianDen { get; set; }
        public decimal Gia { get; set; }
    }
}