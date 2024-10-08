using FluentValidation;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using Movies.API.Contracts;
using Movies.API.Data;
using Movies.API.Extensions;
using Movies.API.Movies;
using Movies.API.Users;

var builder = WebApplication.CreateBuilder(args);
// Add services to the container.
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(config => {

    config.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        Name = "Authorization",
        Type = SecuritySchemeType.ApiKey,
        Scheme = "Bearer",
        BearerFormat = "JWT",
        In = ParameterLocation.Header,
        Description = "Enter JWT token, format : Bearer 'token'"
    });

    config.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        { 
            new OpenApiSecurityScheme
            { 
                Reference = new OpenApiReference { Type = ReferenceType.SecurityScheme, Id = "Bearer" }
            }, new string[]{ }
        }
    });
});
builder.Services.AddControllers();
// ****

builder.Services.AddValidatorsFromAssemblyContaining<Program>();
// builder.Services.AddScoped<IMovieService, MovieService>();
// security
builder.Services.AddAuthorization();

builder.Services
    .AddAuthentication()
    .AddBearerToken(IdentityConstants.BearerScheme);

builder.Services
    .AddIdentityCore<User>()
    .AddEntityFrameworkStores<AppDbContext>()
    .AddApiEndpoints();

builder.Services.AddDbContext<AppDbContext>(opts =>
    opts.UseNpgsql(builder.Configuration.GetConnectionString("postgresDb")));
// ****
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    // ***
    app.ApplyMigrations();
}

app.MapControllers();
app.UseHttpsRedirection();
//app.MapMovieEndpoints();
app.MapIdentityApi<User>();

app.Run();
