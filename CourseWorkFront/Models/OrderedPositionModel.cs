using CourseWorkFront.UserControlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkFront.Models
{
    public class OrderedPositionModel
    {
        public int Id { get; set; }
        
        public int SelectedPosition { get; set; }

        public int SelectedOrder { get; set; }
        public int Count { get; set; }
    }
}
