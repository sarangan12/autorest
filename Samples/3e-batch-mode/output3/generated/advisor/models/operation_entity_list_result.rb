# encoding: utf-8
# Code generated by Microsoft (R) AutoRest Code Generator 1.2.2.0
# Changes may cause incorrect behavior and will be lost if the code is
# regenerated.

module Advisor
  module Models
    #
    # The list of Advisor operations.
    #
    class OperationEntityListResult
      include MsRest::JSONable
      # @return [String] The link used to get the next page of operations.
      attr_accessor :next_link

      # @return [Array<OperationEntity>] The list of operations.
      attr_accessor :value


      #
      # Mapper for OperationEntityListResult class as Ruby Hash.
      # This will be used for serialization/deserialization.
      #
      def self.mapper()
        {
          required: false,
          serialized_name: 'OperationEntityListResult',
          type: {
            name: 'Composite',
            class_name: 'OperationEntityListResult',
            model_properties: {
              next_link: {
                required: false,
                serialized_name: 'nextLink',
                type: {
                  name: 'String'
                }
              },
              value: {
                required: false,
                serialized_name: 'value',
                type: {
                  name: 'Sequence',
                  element: {
                      required: false,
                      serialized_name: 'OperationEntityElementType',
                      type: {
                        name: 'Composite',
                        class_name: 'OperationEntity'
                      }
                  }
                }
              }
            }
          }
        }
      end
    end
  end
end
