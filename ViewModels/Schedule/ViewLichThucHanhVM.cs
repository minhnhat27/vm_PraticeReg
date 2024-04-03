using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWebAPI.Data.ViewModels.Schedule
{
    public class ViewLichThucHanhVM
    {
        public DateTime ngaythuchanh { get; set; }
        public string buoi { get; set; }
        public int sotuan { get; set; }
        public string hknk { get; set; }
        public string mscb { get; set; }
        public string hoten { get; set; }
        public int sttbuoithuchanh { get; set; }
        public string manhomhp { get; set; }
        public string tenhp { get; set; }
        public int? phong { get; set; }
        public bool onSchedule { get; set; }
    }
}
