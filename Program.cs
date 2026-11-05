using JobTracker.Web.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

builder.Services.AddDbContext<JobTrackerDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("JobTracker")));

builder.Services.AddScoped<IJobApplicationRepository, EfJobApplicationRepository>();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

app.MapRazorPages();
app.MapBlazorHub();

app.Run();