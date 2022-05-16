using System.ComponentModel.DataAnnotations;

namespace ObjectLayer
{
    public class StudentEntityModel
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string PhoneNumber { get; set; }

        [Required]
        public string Address { get; set; }

        //public Guid ClassId { get; set; }
        //public ClassEntityModel Class { get; set; }
    }
}