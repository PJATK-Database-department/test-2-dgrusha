using System;
using System.Collections.Generic;

namespace WebTask2.DTO
{
    public class OrderContainer
    {
        public int IdClientOrder { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime CompletionDate { get; set; }

        public string Comments { get; set; }

        public int IDClient { get; set; }

        public int IDEmployee { get; set; }

        public IEnumerable<OrderDTO> list { get; set; }

        public int TotalAmount { get; set; }
    }
}
