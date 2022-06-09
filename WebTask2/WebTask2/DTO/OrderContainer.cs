using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace WebTask2.DTO
{
    public class OrderContainer
    {
        [JsonProperty("IdClientOrder")] public int IdClientOrder { get; set; }
        [JsonProperty("orderDate")] public DateTime OrderDate { get; set; }
        [JsonProperty("completionDate")] public DateTime CompletionDate { get; set; }

        [JsonProperty("comments")] public string Comments { get; set; }

        [JsonProperty("iDClient")] public int IDClient { get; set; }

        [JsonProperty("iDEmployee")] public int IDEmployee { get; set; }

        [JsonProperty("ordersDesc")] public IEnumerable<OrderDTO> list { get; set; }

        [JsonProperty("productName")] public int TotalAmount { get; set; }
    }
}
