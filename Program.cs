var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers(); // Menambahkan layanan untuk controller HTTP

// Menambahkan layanan untuk eksplorasi endpoint API dan dokumentasi Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Mengonfigurasi pipeline permintaan HTTP.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseHttpsRedirection(); // Mengalihkan semua permintaan HTTP ke HTTPS

app.UseAuthorization();

app.MapControllers();
app.Run();
