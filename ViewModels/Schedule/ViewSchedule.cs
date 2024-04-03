using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWebAPI.Data.ViewModels.Schedule
{
    public class ViewSchedule
    {
        public int sotuan { get; set; }
        public string hknh { get; set; }
        public DateTime ngaybatdauhk { get; set; }
        public List<ViewLichThucHanhVM> lichThucHanhs { get; set; }
        public List<int> phong { get; set; }
    }
}
