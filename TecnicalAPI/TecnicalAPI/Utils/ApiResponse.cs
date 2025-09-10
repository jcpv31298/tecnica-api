namespace TecnicalAPI.Utils
{
    public class ApiResponse
    {
        public bool success { get; set; }
        public string message { get; set; }
        public int statusCode { get; set; }
        public object data { get; set; }
    }
}
