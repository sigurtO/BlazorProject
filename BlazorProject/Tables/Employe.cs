using System.ComponentModel.DataAnnotations;

namespace BlazorProject.Tables
{
    public class Employe
    {
        [Key] // auto increments like IDENTITY in MS SQL
        public int Id { get; set; }
        public string Name { get; set; }
        public string JobTitle { get; set; }
    }
}
