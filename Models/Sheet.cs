using Newtonsoft.Json;
using System.Collections.Generic;

namespace TestRoundedValues.Models
{
    /// <summary>
    /// The worksheet.
    /// </summary>
    internal class Sheet
    {
        /// <summary>
        /// Gets or sets the columns.
        /// </summary>
        [JsonProperty("columns")]
        public List<Column> Columns { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the row count.
        /// </summary>
        [JsonProperty("rowCount")]
        public int RowCount { get; set; }

        /// <summary>
        /// Gets or sets the columns count.
        /// </summary>
        [JsonProperty("colCount")]
        public int ColCount { get; set; }

        /// <summary>
        /// Gets or sets the rows.
        /// </summary>
        [JsonProperty("rows")]
        public List<Row> Rows { get; set; }
    }
}
