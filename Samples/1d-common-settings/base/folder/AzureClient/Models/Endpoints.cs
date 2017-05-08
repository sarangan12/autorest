// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace AwesomeNamespace.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The URIs that are used to perform a retrieval of a public blob, queue
    /// or table object.
    /// </summary>
    public partial class Endpoints
    {
        /// <summary>
        /// Initializes a new instance of the Endpoints class.
        /// </summary>
        public Endpoints()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Endpoints class.
        /// </summary>
        /// <param name="blob">The blob endpoint.</param>
        /// <param name="queue">The queue endpoint.</param>
        /// <param name="table">The table endpoint.</param>
        /// <param name="file">The file endpoint.</param>
        public Endpoints(string blob = default(string), string queue = default(string), string table = default(string), string file = default(string))
        {
            Blob = blob;
            Queue = queue;
            Table = table;
            File = file;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the blob endpoint.
        /// </summary>
        [JsonProperty(PropertyName = "blob")]
        public string Blob { get; set; }

        /// <summary>
        /// Gets or sets the queue endpoint.
        /// </summary>
        [JsonProperty(PropertyName = "queue")]
        public string Queue { get; set; }

        /// <summary>
        /// Gets or sets the table endpoint.
        /// </summary>
        [JsonProperty(PropertyName = "table")]
        public string Table { get; set; }

        /// <summary>
        /// Gets or sets the file endpoint.
        /// </summary>
        [JsonProperty(PropertyName = "file")]
        public string File { get; set; }

    }
}
