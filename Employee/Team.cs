using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    public class Team
    {
        public int TeamId { get; set; }
        public string TeamName { get; set; }
        public int Size { get; set; }
        public virtual ICollection<Emp> Emps { get; set; }
    }
}
