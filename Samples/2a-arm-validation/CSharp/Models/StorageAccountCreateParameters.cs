// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Storage.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The parameters to provide for the account.
    /// </summary>
    [JsonTransformation]
    public partial class StorageAccountCreateParameters : IResource
    {
        /// <summary>
        /// Initializes a new instance of the StorageAccountCreateParameters
        /// class.
        /// </summary>
        public StorageAccountCreateParameters()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the StorageAccountCreateParameters
        /// class.
        /// </summary>
        /// <param name="location">The location of the resource. This will be
        /// one of the supported and registered Azure Geo Regions (e.g. West
        /// US, East US, Southeast Asia, etc.). The geo region of a resource
        /// cannot be changed once it is created, but if an identical geo
        /// region is specified on update, the request will succeed.</param>
        /// <param name="accountType">The sku name. Required for account
        /// creation; optional for update. Note that in older versions, sku
        /// name was called accountType. Possible values include:
        /// 'Standard_LRS', 'Standard_ZRS', 'Standard_GRS', 'Standard_RAGRS',
        /// 'Premium_LRS'</param>
        /// <param name="tags">A list of key value pairs that describe the
        /// resource. These tags can be used for viewing and grouping this
        /// resource (across resource groups). A maximum of 15 tags can be
        /// provided for a resource. Each tag must have a key with a length no
        /// greater than 128 characters and a value with a length no greater
        /// than 256 characters.</param>
        public StorageAccountCreateParameters(string location, AccountType accountType, IDictionary<string, string> tags = default(IDictionary<string, string>))
        {
            Location = location;
            Tags = tags;
            AccountType = accountType;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the location of the resource. This will be one of the
        /// supported and registered Azure Geo Regions (e.g. West US, East US,
        /// Southeast Asia, etc.). The geo region of a resource cannot be
        /// changed once it is created, but if an identical geo region is
        /// specified on update, the request will succeed.
        /// </summary>
        [JsonProperty(PropertyName = "location")]
        public string Location { get; set; }

        /// <summary>
        /// Gets or sets a list of key value pairs that describe the resource.
        /// These tags can be used for viewing and grouping this resource
        /// (across resource groups). A maximum of 15 tags can be provided for
        /// a resource. Each tag must have a key with a length no greater than
        /// 128 characters and a value with a length no greater than 256
        /// characters.
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IDictionary<string, string> Tags { get; set; }

        /// <summary>
        /// Gets or sets the sku name. Required for account creation; optional
        /// for update. Note that in older versions, sku name was called
        /// accountType. Possible values include: 'Standard_LRS',
        /// 'Standard_ZRS', 'Standard_GRS', 'Standard_RAGRS', 'Premium_LRS'
        /// </summary>
        [JsonProperty(PropertyName = "properties.accountType")]
        public AccountType AccountType { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Location == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Location");
            }
        }
    }
}
