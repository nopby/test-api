using System.Text.Json;

namespace BETest.Persistences.JsonOptions;

internal static class AppJsonOptions
{
    internal static JsonSerializerOptions SnakeCase = new JsonSerializerOptions { PropertyNamingPolicy = JsonNamingPolicy.SnakeCaseLower };
}
