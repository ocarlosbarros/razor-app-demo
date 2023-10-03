var builder = WebApplication.CreateBuilder(args);

//Adds support to the service RazorPage
builder.Services.AddRazorPages();

var app = builder.Build();

app.UseHttpsRedirection();//Enables the use https
app.UseStaticFiles();//Enables the use wwwroot with static files

app.UseRouting();//Adds middleware to matching routes 
app.MapRazorPages();//Defines endpoints of the application with pages

app.Run();
