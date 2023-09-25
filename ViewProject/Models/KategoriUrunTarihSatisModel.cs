using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ViewProject.Models
{
    public class KategoriUrunTarihSatisModel
    {
        public int UrunID { get; set; }
        public string UrunAdi { get; set; }
        public int Yil { get; set; }
        public string Ay { get; set; }
        public int SatilanMiktar { get; set; }
    }
}
