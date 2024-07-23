using RoomieFinderAPI.Middlewares;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services
    .AttachDbContext(builder.Configuration)
    .AddJWT(builder.Configuration)
    .AttachIdentity()
    .AddServices();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();


app.UseRouting();

app.UseAuthentication();

app.UseAuthorization();

app.UseMiddleware<ExceptionMiddleware>();
app.UseMiddleware<BlacklistedTokensMiddeware>();

app.MapControllers();


app.UseCors(opt =>
{
    opt.WithOrigins("http://localhost:4200");
    opt.AllowAnyMethod();
    opt.AllowAnyHeader();
});

app.Run();
