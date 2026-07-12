var builder = WebApplication.CreateBuilder(args);

// Add controller support
builder.Services.AddControllers();

var app = builder.Build();

// Wire up controller routes (this is what makes /privacy work)
app.MapControllers();

// Simple root route so hitting "/" doesn't 403/404
app.MapGet("/", () => "App is running. Visit /privacy to view the privacy policy.");

app.Run();