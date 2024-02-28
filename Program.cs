// Builder = restaurant plan
var builder = WebApplication.CreateBuilder(args);

// Controllers = waiters/waitresses
// Views = food containers (trays, pans, plates, bowls etc.)
builder.Services.AddControllersWithViews();

// We create our restaurant according to our plan
var app = builder.Build();

// If we're in production (don't worry about this)
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

// Customers have to come through the secure front door,
// they'll be redirected away from the insecure side door
app.UseHttpsRedirection();

// Things that don't change from customer to customer (cutlery, tablecloths etc.)
app.UseStaticFiles();

// Direct people to specialised staff/counters based on what they're looking to order
app.UseRouting();

// If needed, people should have to show ID to order certain items (e.g. alcohol)
app.UseAuthorization();

// If someone doesn't know what to order, recommend them to order a default meal (e.g. the house special)
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

// Open the restaurant for business
app.Run();
