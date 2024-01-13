
using System.ComponentModel.DataAnnotations;

namespace SRPS.MODELS
{
    public class StudentsModels
    {

        public Guid Id { get; set; }

        [Required]
        public string StudentName { get; set; } = string.Empty;

        [Required]
        public string Class { get; set; } = string.Empty;

        public string? FathersName { get; set; }

        public string? MothersName { get;set; }

        public int? Marks { get; set; }

        [Required]
        public string? SchoolHouse { get; set; }

        [Required]
        public bool IsFeesPaid { get; set; }
    }
}
