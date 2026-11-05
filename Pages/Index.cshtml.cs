using JobTracker.Web.Data;
using JobTracker.Web.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace JobTracker.Web.Pages;

public class IndexModel(IJobApplicationRepository repository) : PageModel
{
    public IReadOnlyList<JobApplication> Applications { get; private set; } = [];

    public void OnGet() => Applications = repository.GetAll();
}
