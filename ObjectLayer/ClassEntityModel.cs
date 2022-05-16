using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectLayer
{
    public class ClassEntityModel
    {
        public ClassEntityModel()
        {
            Students = new List<StudentEntityModel>();
            Subjects = new List<SubjectEntityModel>();
        }

        [Key]
        public Guid Id { get; set; }

        [Required]
        public int Number { get; set; }

        [Required]
        public char Letter { get; set; }

        public IList<StudentEntityModel> Students { get; set; }

        public IList<SubjectEntityModel> Subjects { get; set; }
    }
}
