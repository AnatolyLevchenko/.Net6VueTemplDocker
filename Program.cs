var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();

builder.Services.AddSpaStaticFiles(conf =>
{
    conf.RootPath = "clientapp/dist";
});

var app = builder.Build();

app.UseCors(pb =>
{
    pb.AllowAnyHeader();
    pb.AllowAnyMethod();
    pb.AllowAnyOrigin();
});

if (app.Environment.IsDevelopment())
    app.UseDeveloperExceptionPage();


app.UseStaticFiles();

if (!app.Environment.IsDevelopment())
{
    app.UseSpaStaticFiles();
}

app.UseRouting();


app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});

app.UseSpa(spa =>
{
    spa.Options.SourcePath = "clientapp";
    if (app.Environment.IsDevelopment())
    {
        spa.UseProxyToSpaDevelopmentServer("http://localhost:8080");
    }
});
app.Run();
