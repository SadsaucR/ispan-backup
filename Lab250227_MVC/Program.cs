var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
//Add
builder.Services.AddDistributedMemoryCache();

builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromSeconds(10);
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.UseSession();


//app.MapControllerRoute(
//    name: "default",
//    pattern: "{controller=Home}/{action=Index}/{id?}");

//�w�]����
//app.MapControllerRoute(
//    name: "default",
//    pattern: "{controller=TestRoute}/{action=Index}/{id?}/{tag?}");

app.MapControllerRoute(
    name: "MouseB",
    pattern: "{controller=TestRoute}/{action=Mouse}/{apple?}/{bee?}"
    );



app.MapControllerRoute(
    name: "MouseA",
    pattern: "{controller=TestRoute}/{action=Mouse}/{id?}"
    );



app.Run();
