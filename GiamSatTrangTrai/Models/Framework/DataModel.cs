using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Framework
{
    public class DataModel
    {
        public DataModel(DataRow row)
        {
            this.id = (int)row["id"];
            this.thoiGian = (DateTime)row["thoiGian"];
            this.nhietDo = (float)row["nhietDo"];
            this.doAm = (float)row["doAm"];
            this.tanSo = (float)row["tanSo"];
            this.o2 = (float)row["o2"];
            this.co2 = (float)row["co2"];
            this.nh3 = (float)row["nh3"];
        }

        public int id { set; get; }
        public DateTime thoiGian { set; get; }
        public float nhietDo { set; get; }
        public float doAm { set; get; }
        public float tanSo { set; get; }
        public float o2 { set; get; }
        public float co2 { set; get; }
        public float nh3 { set; get; }
    }
}
