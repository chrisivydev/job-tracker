using JobTracker.Web.Models;
using Microsoft.EntityFrameworkCore;

namespace JobTracker.Web.Data;

public class JobTrackerDbContext(DbContextOptions<JobTrackerDbContext> options)
    : DbContext(options)
{
    public DbSet<JobApplication> JobApplications => Set<JobApplication>();
}