using JobTracker.Web.Data;
using JobTracker.Web.Models;

namespace JobTracker.Tests;

public class RepositoryTests
{
    [Test]
    public void Add_IncreasesCountByOne()
    {
        var repository = new InMemoryJobApplicationRepository();
        var before = repository.GetAll().Count;

        repository.Add(new JobApplication { Company = "Test Co", JobTitle = "Developer" });
        Assert.That(repository.GetAll().Count, Is.EqualTo(before + 1));
    }
}

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        Assert.Pass();
    }
}
