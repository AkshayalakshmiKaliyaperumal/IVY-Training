using System.ComponentModel.DataAnnotations;
namespace Entity_Framework.Models
{
    public class Employee
    {
        public int Employee_id { get; set; }
        [Key]
        public string Name { get; set; }
        public int Age { get; set; }
        public string Department_id { get; set; }
        public int salary { get; set; }
    }
}
