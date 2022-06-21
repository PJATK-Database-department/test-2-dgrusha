using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebTask2.Models
{
    public class ClientOrder
    {
        [Key]
        public int IdClientOrder { get; set; }
        [Required]
        public DateTime OrderDate { get; set; }
        public DateTime CompletionDate { get; set; }

        [MaxLength(300)]
        public string Comments { get; set; }

        public int IDClient { get; set; }

        [ForeignKey("IDClient")]
        public Client client { get; set; }

        public int IDEmployee { get; set; }

        [ForeignKey("IDEmployee")]
        public Employee employee{ get; set; }

        public virtual ICollection<Confectionary_ClientOrder> Confectionary_ClientOrders { get; set; }
    }
}
