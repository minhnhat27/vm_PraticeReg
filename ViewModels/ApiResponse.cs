namespace MyWebAPI.Data.ViewModels
{
    public class ApiResponse
    {
        public bool success { get; set; }
        public string? message { get; set; }
        public string? data { get; set; }
    }
}
