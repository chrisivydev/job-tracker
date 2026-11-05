# Job Tracker

A small app for tracking job applications. It uses ASP.NET Core Razor Pages, a Blazor component, and TypeScript.

## Run it

You need the [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0).

```
dotnet run
```

Then open http://localhost:5191.

Node.js is only needed when you change the TypeScript:

```
npm install
npm run build:ts
```

## How it fits together

| Area | File | What it does |
| --- | --- | --- |
| Razor Pages | `Pages/Index.cshtml`, `Pages/Create.cshtml` | Lists and adds applications, with server-side validation |
| Blazor | `Components/StatusSummary.razor` | Interactive summary by status |
| TypeScript | `ts/tableFilter.ts` | Filters the table in the browser |
| Data | `Data/` | Repository interface and in-memory starter storage |

The starter keeps data in memory, so it resets when the app restarts.

## Build plan

Build each step yourself so you can explain it in an interview. Commit after each one.

- [ ] **1. Get it running.** Run the app, read every file, and push it to a public GitHub repo.
- [ ] **2. Upgrade to .NET 10.** Change `TargetFramework` to `net10.0`, run it, and fix anything that breaks. Test the status buttons, since they depend on the Blazor script.
- [ ] **3. Add NUnit tests.** Create a test project and test the repository and page logic.
- [ ] **4. Add SQL Server with Entity Framework Core.** Write a new repository, add migrations, and swap it in `Program.cs`.
- [ ] **5. Finish the Razor Pages.** Add details, edit, and delete pages.
- [ ] **6. Grow the Blazor piece.** Add a small admin page with sorting, inline status changes, and shared components.
- [ ] **7. Grow the TypeScript.** Add a minimal API endpoint, call it with `fetch` using typed responses, and add sortable columns.
- [ ] **8. Add Docker and CI.** Add a Dockerfile and a GitHub Actions workflow that builds and runs tests.
- [ ] **9. Deploy to Azure.** Use App Service and Azure SQL, with secrets in Key Vault and monitoring in Application Insights.
- [ ] **10. Polish it.** Check accessibility against Section 508, try USWDS styling, and add screenshots and the live link to this README.
