# encoding: utf-8
# Code generated by Microsoft (R) AutoRest Code Generator 1.2.2.0
# Changes may cause incorrect behavior and will be lost if the code is
# regenerated.

module Advisor
  module Models
    #
    # Model object.
    #
    #
    class StorageAccountCheckNameAvailabilityParameters
      include MsRest::JSONable
      # @return [String]
      attr_accessor :name

      # @return [String] . Default value: 'Microsoft.Storage/storageAccounts' .
      attr_accessor :type


      #
      # Mapper for StorageAccountCheckNameAvailabilityParameters class as Ruby
      # Hash.
      # This will be used for serialization/deserialization.
      #
      def self.mapper()
        {
          required: false,
          serialized_name: 'StorageAccountCheckNameAvailabilityParameters',
          type: {
            name: 'Composite',
            class_name: 'StorageAccountCheckNameAvailabilityParameters',
            model_properties: {
              name: {
                required: true,
                serialized_name: 'name',
                type: {
                  name: 'String'
                }
              },
              type: {
                required: false,
                serialized_name: 'type',
                default_value: 'Microsoft.Storage/storageAccounts',
                type: {
                  name: 'String'
                }
              }
            }
          }
        }
      end
    end
  end
end
