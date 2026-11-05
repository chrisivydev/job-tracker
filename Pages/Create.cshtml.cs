using JobTracker.Web.Data;
using JobTracker.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace JobTracker.Web.Pages;

public class CreateModel(IJobApplicationRepository repository) : PageModel
{
    [BindProperty]
    public JobApplication Application { get; set; } = new();

    public void OnGet()
    {
    }

    public IActionResult OnPost()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        repository.Add(Application);
        return RedirectToPage("/Index");
    }
}
