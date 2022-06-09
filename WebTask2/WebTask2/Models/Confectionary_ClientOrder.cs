using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebTask2.Models
{
    public class Confectionary_ClientOrder
    {
        public int IdClientOrder { get; set; }
        public int IdConfectionary { get; set; }
        public int Amount { get; set; }
        [MaxLength(300)]
        public string Comments { get; set; }
        [ForeignKey("IdClientOrder")]
        public ClientOrder ClientOrder { get; set; }

        [ForeignKey("IdConfectionary")]
        public Confectionery Confectionery { get; set; }
    }
}
