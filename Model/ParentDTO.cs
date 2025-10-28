namespace Pschool.Client.Model
{
    public class ParentDTO
    {
        public int Id { get; set; }
        public string FullName { get; set; } = string.Empty;
        public string Email { get; set; }
        public string Phone { get; set; }
        public List<StudentDTO>? Students { get; set; } 
    }
}
