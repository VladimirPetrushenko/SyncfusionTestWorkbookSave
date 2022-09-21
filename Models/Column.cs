using Newtonsoft.Json;

namespace TestRoundedValues.Models
{
    /// <summary>
    /// The worksheet column.
    /// </summary>
    internal class Column
    {
        /// <summary>
        /// Gets or sets the width.
        /// </summary>
        [JsonProperty("width")]
        public int Width { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the hidden.
        /// </summary>
        [JsonProperty("hidden")]
        public bool Hidden { get; set; }
    }
}
