using Newtonsoft.Json;

namespace WebTask2.DTO
{
    public class Doctor
    {


        [JsonProperty("idDoctor")]  public int IdDoctor { get; set; }

        [JsonProperty("firstName")]  public string FirstName { get; set; }

        [JsonProperty("lastName")]  public string LastName { get; set; }

        [JsonProperty("email")]  public string Email { get; set; }
    }
}
