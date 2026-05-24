using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkFront.Models
{
    public class OrderModel
    {
        public int Id { set; get; }

        public int Status { set; get; }
        public double Amount { set; get; } = 0;

        public DateTime CreationTime { set; get; }
        public DateTime CompletionTime { set; get; }




    }
}
