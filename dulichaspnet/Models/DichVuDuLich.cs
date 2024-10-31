namespace dulichaspnet.Models
{
    public class DichVuDuLich
    {
        public int Id { get; set; }
        public string Ten { get; set; }
        public string MoTa { get; set; }
        public int DiaDiemId { get; set; }
        public DiaDiemDuLich DiaDiem { get; set; }
    }
}