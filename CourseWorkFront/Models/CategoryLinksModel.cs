using CourseWorkFront.UserControlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkFront.Models
{
    public class CategoryLinksModel
    {
        public int Id { get; set; }

        public int LinkedPosition { get; set; }
        public int LinkedCategory { get; set; }
    }
}
