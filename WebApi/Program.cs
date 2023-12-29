using WebApi.Services;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSingleton<IStudentService, StudentService>();
builder.Services.AddScoped<IFakeUserService, FakeUserService>();

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddHttpLogging(logging => {
    logging.LoggingFields = Microsoft.AspNetCore.HttpLogging.HttpLoggingFields.ResponseBody;
});



var app = builder.Build();


//jdfnsdj
app.UseHttpLogging();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

