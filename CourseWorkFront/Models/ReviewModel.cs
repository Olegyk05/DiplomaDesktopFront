using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkFront.Models
{
    public class ReviewModel
    {
        public int Id { get; set; }

        public int ServiceRating { get; set; }
        public int TasteRating { get; set; }
        public int? LinkedOrder { get; set; }
        public string Text { get; set; } = "";
    }
}
