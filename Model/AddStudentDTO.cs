﻿namespace Pschool.Client.Model
{
    public class AddStudentDTO
    {
    public string FullName { get; set; } = string.Empty; 
    public int? Age { get; set; }
    public string? Phone { get; set; }
    public string? Address { get; set; }
    public string? Siblings { get; set; }
    public int ParentId { get; set; }
    public string ParentName { get; set; }
    
    }  
}
