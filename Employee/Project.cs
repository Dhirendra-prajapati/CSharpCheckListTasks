using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    public class Project
    {
        public int ProjectId { get; set; }
        public string ProjectName { get; set; }
        public string ProgLanguage { get; set; }
        public string Database { get; set; }
        public virtual ICollection<Emp> Emps { get; set;}
    }
}
