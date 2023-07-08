using AC.Portal.Application.Interfaces.Persistence;
using AC.Portal.Application.UserCase.EsignatureRecipient.Commands;
using AC.Portal.Application.UserCase.EsignatureRecipient.Queries;
using AC.Portal.Infraestructure.Mapper;
using AC.Portal.Persistence.Shared;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped<ISoftDeleteEsignatureRecipient, SoftDeleteEsignatureRecipient>();
builder.Services.AddScoped<IGetEsignatureRecipientByEsignatureEnvelopeId, GetEsignatureRecipientByEsignatureEnvelopeId>();

builder.Services.AddDbContext<ACPortalDbContext>(
    options =>
    {
        options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
    });

builder.Services.AddCors(options => options.AddPolicy("AlloWebApp",
                                    builder => builder.AllowAnyOrigin()
                                    .AllowAnyHeader()
                                    .AllowAnyMethod()));

var config = new MapperConfiguration(cfg =>
{
    cfg.AddProfile(new AutoMapperProfile());
});

var mapper = config.CreateMapper();

builder.Services.AddSingleton(mapper);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseCors("AlloWebApp");
app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
