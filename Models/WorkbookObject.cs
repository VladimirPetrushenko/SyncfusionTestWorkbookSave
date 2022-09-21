using Newtonsoft.Json;
using System.Collections.Generic;

namespace TestRoundedValues.Models
{
    /// <summary>
    /// The workbook.
    /// </summary>
    internal class WorkbookObject
    {
        /// <summary>
        /// Gets or sets the filter collection.
        /// </summary>
        [JsonProperty("filterCollection")]
        public List<object> FilterCollection { get; set; }

        /// <summary>
        /// Gets or sets the sort collection.
        /// </summary>
        [JsonProperty("sortCollection")]
        public List<object> SortCollection { get; set; }

        /// <summary>
        /// Gets or sets the active sheet index.
        /// </summary>
        [JsonProperty("activeSheetIndex")]
        public int ActiveSheetIndex { get; set; }

        /// <summary>
        /// Gets or sets the defined names.
        /// </summary>
        [JsonProperty("definedNames")]
        public List<object> DefinedNames { get; set; }

        /// <summary>
        /// Gets or sets the sheets.
        /// </summary>
        [JsonProperty("sheets")]
        public List<Sheet> Sheets { get; set; }
    }
}
