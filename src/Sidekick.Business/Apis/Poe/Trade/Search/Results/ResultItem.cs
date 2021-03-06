using System.Collections.Generic;
using System.Text.Json.Serialization;
using Sidekick.Business.Apis.Poe.Models;

namespace Sidekick.Business.Apis.Poe.Trade.Search.Results
{
    public class ResultItem
    {
        public string Name { get; set; }

        public string TypeLine { get; set; }

        public bool Identified { get; set; }

        [JsonPropertyName("ilvl")]
        public int ItemLevel { get; set; }

        [JsonPropertyName("frameType")]
        public Rarity Rarity { get; set; }

        public bool Corrupted { get; set; }

        public Influences Influences { get; set; } = new Influences();

        public bool Verified { get; set; }

        [JsonPropertyName("w")]
        public int Width { get; set; }

        [JsonPropertyName("h")]
        public int Height { get; set; }

        public string Icon { get; set; }

        public string League { get; set; }

        public string Note { get; set; }

        public List<LineContent> Requirements { get; set; }

        public List<LineContent> Properties { get; set; }

        [JsonPropertyName("implicitMods")]
        public List<string> ImplicitMods { get; set; }

        [JsonPropertyName("craftedMods")]
        public List<string> CraftedMods { get; set; }

        [JsonPropertyName("explicitMods")]
        public List<string> ExplicitMods { get; set; }

        [JsonPropertyName("utilityMods")]
        public List<string> UtilityMods { get; set; }

        [JsonPropertyName("pseudoMods")]
        public List<string> PseudoMods { get; set; }

        [JsonPropertyName("enchantMods")]
        public List<string> EnchantMods { get; set; }

        public List<Socket> Sockets { get; set; } = new List<Socket>();

        public Extended Extended { get; set; } = new Extended();
    }
}
