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

    [Test]
    public void Add_AssignsUniqueIds()
    {
        var repository = new InMemoryJobApplicationRepository();
        var first = new JobApplication { Company = "First Co", JobTitle = "Developer" };
        var second = new JobApplication { Company = "Second Co", JobTitle = "Developer2" };

        repository.Add(first);
        repository.Add(second);

        Assert.That(first.Id, Is.Not.EqualTo(second.Id));
    }

    [Test]
    public void GetAll_ReturnsNewestFirst()
    {
        var repository = new InMemoryJobApplicationRepository();
        var application = new JobApplication { Company = "First Co", JobTitle = "Developer" };

        repository.Add(application);
        Assert.That(repository.GetAll()[0], Is.SameAs(application));
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
