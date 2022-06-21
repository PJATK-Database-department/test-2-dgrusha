using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebTask2.Models
{
    public class Employee
    {
        [Key]
        public int IdEmployee { get; set; }
        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }

        public virtual ICollection<ClientOrder> ClientOrders { get; set; }
    }
}
