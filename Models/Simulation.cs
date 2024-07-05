namespace BETest.Models;

internal sealed class Simulation
{
    public Guid Id { get; set; }
    public required string KodeBarang {  get; set; }
    public required string UraianBarang { get; set; }
    public required int Bm {  get; set; }
    public required float NilaiKomoditas {  get; set; }
    public required float NilaiBm {  get; set; }
    public DateTime WaktuInsert {  get; set; }

}
