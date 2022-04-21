using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudWebAppSample.Models
{
    public class Profile
    {
        public int Id { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }

        public Profile()
        {

        }
    }
}
