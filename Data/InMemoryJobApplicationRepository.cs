using JobTracker.Web.Models;

namespace JobTracker.Web.Data;

// Starter storage only. Data resets whenever the app restarts.
public class InMemoryJobApplicationRepository : IJobApplicationRepository
{
    private readonly object _gate = new();
    private readonly List<JobApplication> _applications =
    [
        new() { Id = 1, Company = "Northwind Health", JobTitle = "Software Developer", PostedPay = 125000, Status = ApplicationStatus.Applied, AppliedOn = new DateOnly(2026, 11, 2) },
        new() { Id = 2, Company = "Contoso Federal", JobTitle = ".NET Developer", PostedPay = 120000, Status = ApplicationStatus.Interview, AppliedOn = new DateOnly(2026, 10, 28) },
        new() { Id = 3, Company = "Fabrikam Software", JobTitle = "Web Developer", Status = ApplicationStatus.Saved },
        new() {Id = 4, Company = "John Ivy Painting", JobTitle = "Painter", PostedPay = 112233, Status = ApplicationStatus.Applied, AppliedOn = new DateOnly(2026, 11, 2)}
    ];

    public IReadOnlyList<JobApplication> GetAll()
    {
        lock (_gate)
        {
            return _applications.OrderByDescending(a => a.Id).ToList();
        }
    }

    public void Add(JobApplication application)
    {
        lock (_gate)
        {
            application.Id = _applications.Max(a => a.Id) + 1;
            _applications.Add(application);
        }
    }
}
