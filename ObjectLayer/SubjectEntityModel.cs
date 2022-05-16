using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectLayer
{
    public class SubjectEntityModel
    {
        public SubjectEntityModel()
        {
            Classes = new List<ClassEntityModel>();
        }

        [Key]
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public IList<ClassEntityModel> Classes { get; set; }
    }
}
