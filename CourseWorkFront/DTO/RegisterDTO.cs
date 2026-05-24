using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkFront.DTO
{
    public class RegisterDTO
    {
        public string login { get; set; }
        public string password { get; set; }

        public int roleId { get; set; }

        public string userName { get; set; }
    }
}
