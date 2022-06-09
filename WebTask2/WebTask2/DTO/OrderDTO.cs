using Newtonsoft.Json;

namespace WebTask2.DTO
{
    public class OrderDTO
    {
        [JsonProperty("amount")] public int Amount { get; set; }
        [JsonProperty("productName")] public string ProductName { get; set; }
    }
}
