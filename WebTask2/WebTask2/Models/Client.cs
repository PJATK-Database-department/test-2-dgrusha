using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebTask2.Models
{
    public class Client
    {
        [Key]
        public int IdClient { get; set; }
        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(60)]
        public string LastName { get; set; }
        
        public virtual ICollection<ClientOrder> ClientOrders { get; set; }
    }
}
