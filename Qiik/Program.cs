using Microsoft.AspNetCore.Builder;
using Microsoft.OpenApi.Models;
//using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var services = builder.Services;
services.AddRouting(options => options.LowercaseUrls = true);
//Using interface
services.AddScoped<Qiik.ExerciseService.IFibonacci, Qiik.ExerciseService.Fibonacci>();
//Not using inteface
services.AddScoped<Qiik.ExerciseService.HashingAlgorithm>();
services.AddScoped<Qiik.ExerciseService.ReversedWord>();
services.AddScoped<Qiik.ExerciseService.TriangleCategory>();

services.AddControllers();
services.AddEndpointsApiExplorer();

services.AddCors(options =>
{
    //allow all cors
    options.AddPolicy("AllowAll", policy =>
    {
        policy.AllowAnyMethod()
                .AllowAnyHeader()
                .AllowCredentials()
                .SetIsOriginAllowed(hostName => true); //.AllowAnyOrigin()
    });
});

services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "QIIK", Version = "v1" });
    c.ResolveConflictingActions(apiDescriptions => apiDescriptions.First());

    // Configure bearer token in swagger
    c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        In = ParameterLocation.Header,
        Description = "Please insert JWT starts with Bearer",
        Name = "Authorization",
        Type = SecuritySchemeType.ApiKey
    });
    c.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    {
                        new OpenApiSecurityScheme
                        {
                            Reference = new OpenApiReference
                            {
                                Type = ReferenceType.SecurityScheme,
                                Id = "Bearer"
                            }
                        },
                        Array.Empty<string>()//new string[] { }
                    }
                });

    var xmlFile = $"{System.Reflection.Assembly.GetExecutingAssembly().GetName().Name}.xml";
    var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
    if (File.Exists(xmlPath))
        c.IncludeXmlComments(xmlPath);
});

var app = builder.Build();

app.MapControllers();
app.UseHttpsRedirection();
app.MapControllers();
app.UseRouting();
app.UseCors("AllowAll");
app.UseSwagger();
app.UseSwaggerUI();

app.Run();