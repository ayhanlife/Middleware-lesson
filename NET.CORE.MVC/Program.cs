using NET.CORE.MVC.Middleware;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseMiddleware<RequestEditingMiddleware>();
app.UseMiddleware<ResponseEditingMiddleware>(); //BU ÞEKILDE GÜZEL BÝR LOGLAMA YAPILABILIR TRY CATCHSIZ

//app.UseAuthorization();

 app.MapRazorPages();

app.Run();
