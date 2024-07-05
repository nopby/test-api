using BETest.Commons.Models;
using BETest.Contracts.ApiHub;
using BETest.Models;
using BETest.Persistences;
using BETest.Persistences.JsonOptions;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<AppDbContext>(config =>
{
    config.UseNpgsql(builder.Configuration.GetConnectionString("Default"), options =>
    {
        options.MigrationsAssembly("BETest");
    });    
});

builder.Services.AddHttpClient("Ilcs", config =>
{
    config.BaseAddress = new Uri(builder.Configuration.GetValue<string>("ApiHub:Ilcs")!);
});

var app = builder.Build();
app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Minimal API V1");
    c.RoutePrefix = string.Empty;
});
var simulasi = app.MapGroup("/simulasi");
simulasi.MapGet("/{kodeBarang}/{nilaiKomoditas}", async (string kodeBarang, float nilaiKomoditas, IHttpClientFactory httpClientFactory, AppDbContext context) =>
{
    var client = httpClientFactory.CreateClient("Ilcs");
    var barangResult = await client.GetAsync($"my/n/barang?hs_code={kodeBarang}");
    if (!barangResult.IsSuccessStatusCode) return Results.NotFound("Kode barang tidak ditemukan");
    var barang = await barangResult.Content.ReadFromJsonAsync<ApiHubResult<IEnumerable<BarangResponse>>>(AppJsonOptions.SnakeCase);
    var biayaResult = await client.GetAsync($"my/n/tarif?hs_code={kodeBarang}");
    if (!biayaResult.IsSuccessStatusCode) return Results.NotFound("Kode barang tidak ditemukan");
    var biaya = await biayaResult.Content.ReadFromJsonAsync<ApiHubResult<IEnumerable<TarifResponse>>>(AppJsonOptions.SnakeCase);

    var entt = new Simulation
    {
        Bm = int.TryParse(biaya.Data.First().Bm, out int bm) ? bm : 0,
        KodeBarang = kodeBarang,
        NilaiBm = nilaiKomoditas * bm / 100,
        NilaiKomoditas = nilaiKomoditas,
        UraianBarang = barang.Data.First().UraianId,
    };
    await context.AddAsync(entt);
    await context.SaveChangesAsync();
    return Results.Ok(entt);
});

app.Run();
