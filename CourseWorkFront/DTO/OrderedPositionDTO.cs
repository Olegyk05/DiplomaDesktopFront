using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkFront.Models
{
    public class OrderedPositionDTO
    {
        public int orderedPositionId;

        public int orderedPositionCount;

        public OrderedPositionDTO(int id,int count)
        {
            orderedPositionId = id;
            orderedPositionCount = count;
        }

    }
}
