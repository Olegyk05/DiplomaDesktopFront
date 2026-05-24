using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkFront.DTO
{
    public class OrderDTO
    {
        public int Id { set; get; }

        public int Status { set; get; }

        public DateTime CreationTime { set; get; }
        public DateTime CompletionTime { set; get; }
    }
}
