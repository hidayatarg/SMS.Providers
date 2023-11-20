using NT.Sms.Providers;
using NT.Sms.Services;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Register your SMS providers
builder.Services.AddTransient<ISmsProvider, TwilioSmsProvider>();
builder.Services.AddTransient<ISmsProvider, NexmoSmsProvider>();
builder.Services.AddTransient<ISmsProvider, RizonSmsProvider>();

// Register your SMS service
builder.Services.AddTransient<ISmsService, SmsService>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//var sb = new StringBuilder();
//sb.AppendLine("Registered Services:");
//foreach (var service in builder.Services)
//{
//    sb.AppendLine(service.ServiceType.FullName);
//}
//Console.WriteLine(sb);

var app = builder.Build();

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
