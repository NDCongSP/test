using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Learn.Models
{
    public class HomeModel
    {
        [Required]
        public int id { get; set; }

        public string tenChuong { get; set; }
        public double nhietDo { get; set; }
        public double doAm { get; set; }
        public double tanSo { get; set; }
        public double o2 { get; set; }
        public double co2 { get; set; }
        public double nh3 { get; set; }
        public byte[] trangThaiThietBi { get; set; }

    }
}