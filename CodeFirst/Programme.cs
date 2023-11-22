using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst
{
    public class Programme
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        [Required]
        [Column("CourseName",TypeName ="varchar")]
        [MaxLength(100)]
        public string Title { get; set; }
        public int Duration { get; set; }
        public float Fees { get; set; }
        //navigation property
        public virtual ICollection<Student> Students { get; set; }
        public virtual ICollection<Subject> Subject { get; set; }
        
    }
}
