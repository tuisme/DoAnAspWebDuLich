namespace dulichaspnet.Models
{
    public class DatVe
    {
        public int Id { get; set; }
        public string Ten { get; set; }
        public string ThongTinLienHe { get; set; }
        public int TuyenDuongId { get; set; }
        public TuyenDuong TuyenDuong { get; set; }
        public DateTime NgayDat { get; set; } = DateTime.Now;
        public int NguoiDungId { get; set; }
        public NguoiDung NguoiDung { get; set; }
    }
}