using Newtonsoft.Json;

namespace TestRoundedValues.Models
{
    /// <summary>
    /// The worksheet cell.
    /// </summary>
    internal class Cell
    {
        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        [JsonProperty("value")]
        public string Value { get; set; }

        /// <summary>
        /// Gets or sets the format.
        /// </summary>
        [JsonProperty("format")]
        public string Format { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the cell is locked.
        /// </summary>
        [JsonProperty("isLocked")]
        public bool IsLocked { get; set; }
    }
}
