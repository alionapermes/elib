var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

var app = builder.Build();

app.UseExceptionHandler("/Home/Error");

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
  name: "home",
  pattern: "{controller=Home}/{action=Index}/");
app.MapControllerRoute(
  name: "create",
  pattern: "{controller=Create}/{action=Index}/");
app.MapControllerRoute(
  name: "read",
  pattern: "{controller=Read}/{action=Index}/{id?}");
app.MapControllerRoute(
  name: "update",
  pattern: "{controller=Update}/{action=Index}/{id?}");
app.MapControllerRoute(
  name: "delete",
  pattern: "{controller=Delete}/{action=Index}/{id?}");

app.Run();
