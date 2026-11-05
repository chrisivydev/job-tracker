using JobTracker.Web.Models;

namespace JobTracker.Web.Data;

public interface IJobApplicationRepository
{
    IReadOnlyList<JobApplication> GetAll();
    void Add(JobApplication application);
}
