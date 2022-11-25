using System.ComponentModel.DataAnnotations;

namespace Entity_Framework.Models
{
    public class departments
    {
        public int department_id { get; set; }
        [Key]
        public string department_name { get; set; }

        public ICollection<Employee> employees { get; set; }

    }
}
