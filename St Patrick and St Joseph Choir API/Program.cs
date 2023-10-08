using Microsoft.EntityFrameworkCore;
using St_Patrick_and_St_Joseph_Choir_API.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(
        policy =>
        {
            //policy.AllowAnyOrigin();
            policy.WithOrigins("http://127.0.0.1:5500/Home.html");
        });
});

builder.Services.AddDbContext<ApplicationDbContext>(option =>
{
    option.UseSqlServer(builder.Configuration.GetConnectionString("ChoirSQLConnection"));
});

builder.Services.AddControllers(option => { }).AddNewtonsoftJson().AddXmlDataContractSerializerFormatters();

//builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();

app.UseCors();

app.UseAuthorization();

app.MapControllers();

app.Run();
