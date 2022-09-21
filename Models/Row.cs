using Newtonsoft.Json;
using System.Collections.Generic;

namespace TestRoundedValues.Models
{
    /// <summary>
    /// The worksheet row.
    /// </summary>
    internal class Row
    {
        /// <summary>
        /// Gets or sets the cells.
        /// </summary>
        [JsonProperty("cells")]
        public List<Cell> Cells { get; set; }
    }
}
