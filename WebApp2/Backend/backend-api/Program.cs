var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddCors( option =>
    option.AddPolicy( "CORS", builder =>
    {
        builder.AllowAnyHeader()
               .AllowAnyMethod()
               .AllowAnyOrigin();
        
    }));
    
    builder.Services.AddMvc().AddJsonOptions( p =>
    {
        p.JsonSerializerOptions.WriteIndented = true;
    });
builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddSwaggerGen();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors("CORS");

app.UseAuthorization();

app.MapControllers();

app.Run();
