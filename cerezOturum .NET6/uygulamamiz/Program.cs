using uygulamamiz;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddSession(option =>
{
    //Oturum s�resi 10 dk olarak belirlendi
    option.IdleTimeout = TimeSpan.FromMinutes(10);
});
builder.Services.AddSingleton<ISingletonHizmeti, TekilIslem>(); //genel TEK�L de�erler i�in

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();
app.MapRazorPages();

app.UseSession(); //oturum deste�i

app.Run();