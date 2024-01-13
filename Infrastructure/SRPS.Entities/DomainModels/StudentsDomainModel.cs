using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRPS.Entities.DomainModels
{
    public class StudentsDomainModel
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [StringLength(100)]
        public string StudentName { get; set; } = string.Empty;

        [Required]
        [StringLength(10)]
        public string Class { get; set; } = string.Empty;

        [Required]
        [StringLength(100)]
        public string? FathersName { get; set; }

        [Required]
        [StringLength(100)]
        public string? MothersName { get; set; }

        public int? Marks { get; set; }

        [Required]
        [StringLength(100)]
        public string? SchoolHouse { get; set; }

        public bool IsFeesPaid { get; set; }

    }
}
