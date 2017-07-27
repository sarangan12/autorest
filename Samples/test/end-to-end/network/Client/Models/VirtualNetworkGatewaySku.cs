// Code generated by Microsoft (R) AutoRest Code Generator 1.2.2.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace ApplicationGateway.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// VirtualNetworkGatewaySku details
    /// </summary>
    public partial class VirtualNetworkGatewaySku
    {
        /// <summary>
        /// Initializes a new instance of the VirtualNetworkGatewaySku class.
        /// </summary>
        public VirtualNetworkGatewaySku()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the VirtualNetworkGatewaySku class.
        /// </summary>
        /// <param name="name">Gateway SKU name. Possible values are: 'Basic',
        /// 'HighPerformance','Standard', and 'UltraPerformance'. Possible
        /// values include: 'Basic', 'HighPerformance', 'Standard',
        /// 'UltraPerformance'</param>
        /// <param name="tier">Gateway SKU tier. Possible values are: 'Basic',
        /// 'HighPerformance','Standard', and 'UltraPerformance'. Possible
        /// values include: 'Basic', 'HighPerformance', 'Standard',
        /// 'UltraPerformance'</param>
        /// <param name="capacity">The capacity.</param>
        public VirtualNetworkGatewaySku(string name = default(string), string tier = default(string), int? capacity = default(int?))
        {
            Name = name;
            Tier = tier;
            Capacity = capacity;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets gateway SKU name. Possible values are: 'Basic',
        /// 'HighPerformance','Standard', and 'UltraPerformance'. Possible
        /// values include: 'Basic', 'HighPerformance', 'Standard',
        /// 'UltraPerformance'
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets gateway SKU tier. Possible values are: 'Basic',
        /// 'HighPerformance','Standard', and 'UltraPerformance'. Possible
        /// values include: 'Basic', 'HighPerformance', 'Standard',
        /// 'UltraPerformance'
        /// </summary>
        [JsonProperty(PropertyName = "tier")]
        public string Tier { get; set; }

        /// <summary>
        /// Gets or sets the capacity.
        /// </summary>
        [JsonProperty(PropertyName = "capacity")]
        public int? Capacity { get; set; }

    }
}
