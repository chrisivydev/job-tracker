using System.ComponentModel.DataAnnotations;

namespace JobTracker.Web.Models;

public class JobApplication
{
    public int Id { get; set; }

    [Required, StringLength(100)]
    public string Company { get; set; } = string.Empty;

    [Required, StringLength(100)]
    [Display(Name = "Job title")]
    public string JobTitle { get; set; } = string.Empty;

    [Range(0, 1_000_000)]
    [Display(Name = "Posted pay (USD)")]
    public int? PostedPay { get; set; }

    public ApplicationStatus Status { get; set; } = ApplicationStatus.Saved;

    [DataType(DataType.Date)]
    [Display(Name = "Applied on")]
    public DateOnly? AppliedOn { get; set; }
}
