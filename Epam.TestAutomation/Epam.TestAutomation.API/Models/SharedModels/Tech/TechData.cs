using Newtonsoft.Json;

namespace Epam.TestAutomation.API.Models.SharedModels.Tech
{
    public class TechData
    {
        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("capacity")]
        public string Capacity { get; set; }

        [JsonProperty("capacity GB")]
        public int CapacityGB { get; set; }

        [JsonProperty("price")]
        public float Price { get; set; }

        [JsonProperty("generation")]
        public string Generation { get; set; }

        [JsonProperty("year")]
        public int Year { get; set; }

        [JsonProperty("CPU model")]
        public string CpuModel { get; set; }

        [JsonProperty("Hard disk size")]
        public string HardDiskSize { get; set; }

        [JsonProperty("Strap Colour")]
        public string StrapColour { get; set; }

        [JsonProperty("Case Size")]
        public string CaseSize { get; set; }

        [JsonProperty("Color")]
        public string ColorToUpper { get; set; }

        [JsonProperty("Description")]
        public string Description { get; set; }

        [JsonProperty("Capacity")]
        public string CapacityToUpper { get; set; }

        [JsonProperty("Screensize")]
        public float Screensize { get; set; }

        [JsonProperty("Generation")]
        public string GenerationToUpper { get; set; }

        [JsonProperty("Price")]
        public string PriceToUpper { get; set; }
    }
}
