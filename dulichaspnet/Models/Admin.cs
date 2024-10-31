namespace dulichaspnet.Models
{
    public class Admin
    {
        public int Id { get; set; }
        public string TenDangNhap { get; set; }
        public string MatKhau { get; set; }
        public DateTime NgayTao { get; set; } = DateTime.Now;
    }
}