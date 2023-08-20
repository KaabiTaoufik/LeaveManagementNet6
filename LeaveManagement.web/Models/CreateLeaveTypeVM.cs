using System.ComponentModel.DataAnnotations;

namespace LeaveManagement.web.Models
{
    public class CreateLeaveTypeVM
    {
        [Display(Name = "Leave Name")]
        [Required]
        public string Name { get; set; }

        [Display(Name = "Leave Description")]
        public string? Description { get; set; }

        [Display(Name = "Deafult Number Of Days")]
        [Required]
        [Range(1,25)]
        public int DefaultDays { get; set; }
    }
}
