using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SMS.Domain
{
    public class Student : BaseClass
    {
        [Key] 
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public string? Email { get; set; }

        [ForeignKey("ProgramId")]

        public int ProgramId { get; set; }
        public virtual Programs Programs { get; set; }

    }
}
