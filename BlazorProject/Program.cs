using BlazorProject;
using BlazorProject.Database;
using BlazorProject.Tables;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");



builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

await builder.Build().RunAsync();
using (var db = new BlazorDbContext())
{
    db.Database.EnsureCreated(); // Creates the database if it doesn't exist
}

using (BlazorDbContext db = new BlazorDbContext()) // prop shoudlnt do this is program.cs :)
{
    Employe employee = new Employe
    {
        Name = "John Doe",
        JobTitle = "Delivery"
    };
	try
	{
		db.Employees.Add(employee);
		db.SaveChanges();
    }
	catch (Exception)
	{

		throw;
	}
}