/*
 * Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
 * Changes may cause incorrect behavior and will be lost if the code is
 * regenerated.
 */

'use strict';

const models = require('./index');

/**
 * @class
 * Initializes a new instance of the StorageAccountCreateParameters class.
 * @constructor
 * The parameters to provide for the account.
 *
 * @member {string} location The location of the resource. This will be one of
 * the supported and registered Azure Geo Regions (e.g. West US, East US,
 * Southeast Asia, etc.). The geo region of a resource cannot be changed once
 * it is created, but if an identical geo region is specified on update, the
 * request will succeed.
 *
 * @member {object} [tags] A list of key value pairs that describe the
 * resource. These tags can be used for viewing and grouping this resource
 * (across resource groups). A maximum of 15 tags can be provided for a
 * resource. Each tag must have a key with a length no greater than 128
 * characters and a value with a length no greater than 256 characters.
 *
 * @member {string} accountType The sku name. Required for account creation;
 * optional for update. Note that in older versions, sku name was called
 * accountType. Possible values include: 'Standard_LRS', 'Standard_ZRS',
 * 'Standard_GRS', 'Standard_RAGRS', 'Premium_LRS'
 *
 */
class StorageAccountCreateParameters extends models['BaseResource'] {
  constructor() {
    super();
  }

  /**
   * Defines the metadata of StorageAccountCreateParameters
   *
   * @returns {object} metadata of StorageAccountCreateParameters
   *
   */
  mapper() {
    return {
      required: false,
      serializedName: 'StorageAccountCreateParameters',
      type: {
        name: 'Composite',
        className: 'StorageAccountCreateParameters',
        modelProperties: {
          location: {
            required: true,
            serializedName: 'location',
            type: {
              name: 'String'
            }
          },
          tags: {
            required: false,
            serializedName: 'tags',
            type: {
              name: 'Dictionary',
              value: {
                  required: false,
                  serializedName: 'StringElementType',
                  type: {
                    name: 'String'
                  }
              }
            }
          },
          accountType: {
            required: true,
            serializedName: 'properties.accountType',
            type: {
              name: 'Enum',
              allowedValues: [ 'Standard_LRS', 'Standard_ZRS', 'Standard_GRS', 'Standard_RAGRS', 'Premium_LRS' ]
            }
          }
        }
      }
    };
  }
}

module.exports = StorageAccountCreateParameters;
