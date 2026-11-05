using JobTracker.Web.Models;
using Microsoft.EntityFrameworkCore;

namespace JobTracker.Web.Data;

public class EfJobApplicationRepository(JobTrackerDbContext db) : IJobApplicationRepository
{
    public IReadOnlyList<JobApplication> GetAll()
    {
        return db.JobApplications
            .AsNoTracking()
            .OrderByDescending(a => a.Id)
            .ToList();
    }

    public void Add(JobApplication application)
    {
        db.JobApplications.Add(application);
        db.SaveChanges();
    }
}