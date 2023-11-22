using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst
{
    public class Student
    {
        [Key]
        public int RollNo { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public bool IsBonafied { get; set; }
        public string ContactNumber { get; set; }
        [ForeignKey ("Programme")]
        public int  ProgrammeId { get; set; }
        //Navigation Property
        public virtual Programme Programme { get; set; }
        public virtual StudentAddress StudentAddress { get; set; }
    }
}
