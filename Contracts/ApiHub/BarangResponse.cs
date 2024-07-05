using System.Text.Json.Serialization;

namespace BETest.Contracts.ApiHub;

internal sealed class BarangResponse
{
    public string HsCodeFormat { get; set; }
    public string UraianId { get; set; }
    public string SubHeader { get; set; }
}
