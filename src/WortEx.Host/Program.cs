using WortEx.Infrastructure;
using MudBlazor.Services;
using WortEx.Application;
using WortEx.Frontend;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddRazorPages(c => c.RootDirectory = "/");
builder.Services.AddServerSideBlazor(c =>
{
    c.DisconnectedCircuitMaxRetained = 25;
    c.DisconnectedCircuitRetentionPeriod = TimeSpan.FromSeconds(30);
});

// Context
builder.Services
    .AddWortExInfrastructure()
    .AddWortExApplication()
    .AddWortExFrontend()
    .AddMudServices();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

// Routing
app.UseRouting();
app.MapRazorPages();
app.MapControllers();
app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();