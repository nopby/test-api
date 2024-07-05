namespace BETest.Commons.Models;


internal sealed class ApiHubResult<T>
{
    public T Data { get; set; }
    public string Code { get; set; }
    public string Message { get; set; }
}