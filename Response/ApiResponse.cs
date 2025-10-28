namespace Pschool.Client.Response
{
    public class ApiResponse<T>
    {
        public string? UniqueID { get; set; }
        public int? ResponseCode { get; set; }
        public string? ResponseDescription { get; set; }
        public T? ResponseObject { get; set; }
    }
}
