# encoding: utf-8
# Code generated by Microsoft (R) AutoRest Code Generator 1.2.2.0
# Changes may cause incorrect behavior and will be lost if the code is
# regenerated.

module Advisor
  #
  # Suppressions
  #
  class Suppressions

    #
    # Creates and initializes a new instance of the Suppressions class.
    # @param client service class for accessing basic functionality.
    #
    def initialize(client)
      @client = client
    end

    # @return [ComposedCowbellClient] reference to the ComposedCowbellClient
    attr_reader :client

    #
    # Obtains the details of a suppression.
    #
    # @param resource_uri [String] The fully qualified Azure Resource Manager
    # identifier of the resource to which the recommendation applies.
    # @param recommendation_id [String] The recommendation ID.
    # @param name [String] The name of the suppression.
    # @param custom_headers [Hash{String => String}] A hash of custom headers that
    # will be added to the HTTP request.
    #
    # @return [SuppressionContract] operation results.
    #
    def get(resource_uri, recommendation_id, name, custom_headers = nil)
      response = get_async(resource_uri, recommendation_id, name, custom_headers).value!
      response.body unless response.nil?
    end

    #
    # Obtains the details of a suppression.
    #
    # @param resource_uri [String] The fully qualified Azure Resource Manager
    # identifier of the resource to which the recommendation applies.
    # @param recommendation_id [String] The recommendation ID.
    # @param name [String] The name of the suppression.
    # @param custom_headers [Hash{String => String}] A hash of custom headers that
    # will be added to the HTTP request.
    #
    # @return [MsRest::HttpOperationResponse] HTTP response information.
    #
    def get_with_http_info(resource_uri, recommendation_id, name, custom_headers = nil)
      get_async(resource_uri, recommendation_id, name, custom_headers).value!
    end

    #
    # Obtains the details of a suppression.
    #
    # @param resource_uri [String] The fully qualified Azure Resource Manager
    # identifier of the resource to which the recommendation applies.
    # @param recommendation_id [String] The recommendation ID.
    # @param name [String] The name of the suppression.
    # @param [Hash{String => String}] A hash of custom headers that will be added
    # to the HTTP request.
    #
    # @return [Concurrent::Promise] Promise object which holds the HTTP response.
    #
    def get_async(resource_uri, recommendation_id, name, custom_headers = nil)
      fail ArgumentError, 'resource_uri is nil' if resource_uri.nil?
      fail ArgumentError, 'recommendation_id is nil' if recommendation_id.nil?
      fail ArgumentError, 'name is nil' if name.nil?
      api_version = '2017-04-19'


      request_headers = {}
      path_template = '{resourceUri}/providers/Microsoft.Advisor/recommendations/{recommendationId}/suppressions/{name}'

      request_url = @base_url || @client.base_url

      options = {
          middlewares: [[MsRest::RetryPolicyMiddleware, times: 3, retry: 0.02], [:cookie_jar]],
          path_params: {'resourceUri' => resource_uri,'recommendationId' => recommendation_id,'name' => name},
          query_params: {'api-version' => api_version},
          headers: request_headers.merge(custom_headers || {}),
          base_url: request_url
      }
      promise = @client.make_request_async(:get, path_template, options)

      promise = promise.then do |result|
        http_response = result.response
        status_code = http_response.status
        response_content = http_response.body
        unless status_code == 200
          error_model = JSON.load(response_content)
          fail MsRest::HttpOperationError.new(result.request, http_response, error_model)
        end

        # Deserialize Response
        if status_code == 200
          begin
            parsed_response = response_content.to_s.empty? ? nil : JSON.load(response_content)
            result.body = Advisor::Models::SuppressionContract.new.from_json(parsed_response)
          rescue Exception => e
            fail MsRest::DeserializationError.new('Error occurred in deserializing the response', e.message, e.backtrace, result)
          end
        end

        result
      end

      promise.execute
    end

    #
    # Enables the snoozed or dismissed attribute of a recommendation. The snoozed
    # or dismissed attribute is referred to as a suppression. Use this API to
    # create or update the snoozed or dismissed status of a recommendation.
    #
    # @param resource_uri [String] The fully qualified Azure Resource Manager
    # identifier of the resource to which the recommendation applies.
    # @param recommendation_id [String] The recommendation ID.
    # @param name [String] The name of the suppression.
    # @param suppression_contract [SuppressionContract] The snoozed or dismissed
    # attribute; for example, the snooze duration.
    # @param custom_headers [Hash{String => String}] A hash of custom headers that
    # will be added to the HTTP request.
    #
    # @return [SuppressionContract] operation results.
    #
    def create(resource_uri, recommendation_id, name, suppression_contract, custom_headers = nil)
      response = create_async(resource_uri, recommendation_id, name, suppression_contract, custom_headers).value!
      response.body unless response.nil?
    end

    #
    # Enables the snoozed or dismissed attribute of a recommendation. The snoozed
    # or dismissed attribute is referred to as a suppression. Use this API to
    # create or update the snoozed or dismissed status of a recommendation.
    #
    # @param resource_uri [String] The fully qualified Azure Resource Manager
    # identifier of the resource to which the recommendation applies.
    # @param recommendation_id [String] The recommendation ID.
    # @param name [String] The name of the suppression.
    # @param suppression_contract [SuppressionContract] The snoozed or dismissed
    # attribute; for example, the snooze duration.
    # @param custom_headers [Hash{String => String}] A hash of custom headers that
    # will be added to the HTTP request.
    #
    # @return [MsRest::HttpOperationResponse] HTTP response information.
    #
    def create_with_http_info(resource_uri, recommendation_id, name, suppression_contract, custom_headers = nil)
      create_async(resource_uri, recommendation_id, name, suppression_contract, custom_headers).value!
    end

    #
    # Enables the snoozed or dismissed attribute of a recommendation. The snoozed
    # or dismissed attribute is referred to as a suppression. Use this API to
    # create or update the snoozed or dismissed status of a recommendation.
    #
    # @param resource_uri [String] The fully qualified Azure Resource Manager
    # identifier of the resource to which the recommendation applies.
    # @param recommendation_id [String] The recommendation ID.
    # @param name [String] The name of the suppression.
    # @param suppression_contract [SuppressionContract] The snoozed or dismissed
    # attribute; for example, the snooze duration.
    # @param [Hash{String => String}] A hash of custom headers that will be added
    # to the HTTP request.
    #
    # @return [Concurrent::Promise] Promise object which holds the HTTP response.
    #
    def create_async(resource_uri, recommendation_id, name, suppression_contract, custom_headers = nil)
      fail ArgumentError, 'resource_uri is nil' if resource_uri.nil?
      fail ArgumentError, 'recommendation_id is nil' if recommendation_id.nil?
      fail ArgumentError, 'name is nil' if name.nil?
      fail ArgumentError, 'suppression_contract is nil' if suppression_contract.nil?
      api_version = '2017-04-19'


      request_headers = {}

      request_headers['Content-Type'] = 'application/json; charset=utf-8'

      # Serialize Request
      request_content = suppression_contract.nil? ? nil: suppression_contract.to_json
      request_content = request_content != nil ? JSON.generate(request_content, quirks_mode: true) : nil

      path_template = '{resourceUri}/providers/Microsoft.Advisor/recommendations/{recommendationId}/suppressions/{name}'

      request_url = @base_url || @client.base_url

      options = {
          middlewares: [[MsRest::RetryPolicyMiddleware, times: 3, retry: 0.02], [:cookie_jar]],
          path_params: {'resourceUri' => resource_uri,'recommendationId' => recommendation_id,'name' => name},
          query_params: {'api-version' => api_version},
          body: request_content,
          headers: request_headers.merge(custom_headers || {}),
          base_url: request_url
      }
      promise = @client.make_request_async(:put, path_template, options)

      promise = promise.then do |result|
        http_response = result.response
        status_code = http_response.status
        response_content = http_response.body
        unless status_code == 200
          error_model = JSON.load(response_content)
          fail MsRest::HttpOperationError.new(result.request, http_response, error_model)
        end

        # Deserialize Response
        if status_code == 200
          begin
            parsed_response = response_content.to_s.empty? ? nil : JSON.load(response_content)
            result.body = Advisor::Models::SuppressionContract.new.from_json(parsed_response)
          rescue Exception => e
            fail MsRest::DeserializationError.new('Error occurred in deserializing the response', e.message, e.backtrace, result)
          end
        end

        result
      end

      promise.execute
    end

    #
    # Enables the activation of a snoozed or dismissed recommendation. The snoozed
    # or dismissed attribute of a recommendation is referred to as a suppression.
    #
    # @param resource_uri [String] The fully qualified Azure Resource Manager
    # identifier of the resource to which the recommendation applies.
    # @param recommendation_id [String] The recommendation ID.
    # @param name [String] The name of the suppression.
    # @param custom_headers [Hash{String => String}] A hash of custom headers that
    # will be added to the HTTP request.
    #
    #
    def delete(resource_uri, recommendation_id, name, custom_headers = nil)
      response = delete_async(resource_uri, recommendation_id, name, custom_headers).value!
      nil
    end

    #
    # Enables the activation of a snoozed or dismissed recommendation. The snoozed
    # or dismissed attribute of a recommendation is referred to as a suppression.
    #
    # @param resource_uri [String] The fully qualified Azure Resource Manager
    # identifier of the resource to which the recommendation applies.
    # @param recommendation_id [String] The recommendation ID.
    # @param name [String] The name of the suppression.
    # @param custom_headers [Hash{String => String}] A hash of custom headers that
    # will be added to the HTTP request.
    #
    # @return [MsRest::HttpOperationResponse] HTTP response information.
    #
    def delete_with_http_info(resource_uri, recommendation_id, name, custom_headers = nil)
      delete_async(resource_uri, recommendation_id, name, custom_headers).value!
    end

    #
    # Enables the activation of a snoozed or dismissed recommendation. The snoozed
    # or dismissed attribute of a recommendation is referred to as a suppression.
    #
    # @param resource_uri [String] The fully qualified Azure Resource Manager
    # identifier of the resource to which the recommendation applies.
    # @param recommendation_id [String] The recommendation ID.
    # @param name [String] The name of the suppression.
    # @param [Hash{String => String}] A hash of custom headers that will be added
    # to the HTTP request.
    #
    # @return [Concurrent::Promise] Promise object which holds the HTTP response.
    #
    def delete_async(resource_uri, recommendation_id, name, custom_headers = nil)
      fail ArgumentError, 'resource_uri is nil' if resource_uri.nil?
      fail ArgumentError, 'recommendation_id is nil' if recommendation_id.nil?
      fail ArgumentError, 'name is nil' if name.nil?
      api_version = '2017-04-19'


      request_headers = {}
      path_template = '{resourceUri}/providers/Microsoft.Advisor/recommendations/{recommendationId}/suppressions/{name}'

      request_url = @base_url || @client.base_url

      options = {
          middlewares: [[MsRest::RetryPolicyMiddleware, times: 3, retry: 0.02], [:cookie_jar]],
          path_params: {'resourceUri' => resource_uri,'recommendationId' => recommendation_id,'name' => name},
          query_params: {'api-version' => api_version},
          headers: request_headers.merge(custom_headers || {}),
          base_url: request_url
      }
      promise = @client.make_request_async(:delete, path_template, options)

      promise = promise.then do |result|
        http_response = result.response
        status_code = http_response.status
        response_content = http_response.body
        unless status_code == 204
          error_model = JSON.load(response_content)
          fail MsRest::HttpOperationError.new(result.request, http_response, error_model)
        end


        result
      end

      promise.execute
    end

    #
    # Retrieves the list of snoozed or dismissed suppressions for a subscription.
    # The snoozed or dismissed attribute of a recommendation is referred to as a
    # suppression.
    #
    # @param top [Integer] The number of suppressions per page if a paged version
    # of this API is being used.
    # @param skip_token [String] The page-continuation token to use with a paged
    # version of this API.
    # @param custom_headers [Hash{String => String}] A hash of custom headers that
    # will be added to the HTTP request.
    #
    # @return [SuppressionContractListResult] operation results.
    #
    def list(top = nil, skip_token = nil, custom_headers = nil)
      response = list_async(top, skip_token, custom_headers).value!
      response.body unless response.nil?
    end

    #
    # Retrieves the list of snoozed or dismissed suppressions for a subscription.
    # The snoozed or dismissed attribute of a recommendation is referred to as a
    # suppression.
    #
    # @param top [Integer] The number of suppressions per page if a paged version
    # of this API is being used.
    # @param skip_token [String] The page-continuation token to use with a paged
    # version of this API.
    # @param custom_headers [Hash{String => String}] A hash of custom headers that
    # will be added to the HTTP request.
    #
    # @return [MsRest::HttpOperationResponse] HTTP response information.
    #
    def list_with_http_info(top = nil, skip_token = nil, custom_headers = nil)
      list_async(top, skip_token, custom_headers).value!
    end

    #
    # Retrieves the list of snoozed or dismissed suppressions for a subscription.
    # The snoozed or dismissed attribute of a recommendation is referred to as a
    # suppression.
    #
    # @param top [Integer] The number of suppressions per page if a paged version
    # of this API is being used.
    # @param skip_token [String] The page-continuation token to use with a paged
    # version of this API.
    # @param [Hash{String => String}] A hash of custom headers that will be added
    # to the HTTP request.
    #
    # @return [Concurrent::Promise] Promise object which holds the HTTP response.
    #
    def list_async(top = nil, skip_token = nil, custom_headers = nil)
      fail ArgumentError, '@client.subscription_id is nil' if @client.subscription_id.nil?
      api_version = '2017-04-19'


      request_headers = {}
      path_template = 'subscriptions/{subscriptionId}/providers/Microsoft.Advisor/suppressions'

      request_url = @base_url || @client.base_url

      options = {
          middlewares: [[MsRest::RetryPolicyMiddleware, times: 3, retry: 0.02], [:cookie_jar]],
          path_params: {'subscriptionId' => @client.subscription_id},
          query_params: {'api-version' => api_version,'$top' => top,'$skipToken' => skip_token},
          headers: request_headers.merge(custom_headers || {}),
          base_url: request_url
      }
      promise = @client.make_request_async(:get, path_template, options)

      promise = promise.then do |result|
        http_response = result.response
        status_code = http_response.status
        response_content = http_response.body
        unless status_code == 200
          error_model = JSON.load(response_content)
          fail MsRest::HttpOperationError.new(result.request, http_response, error_model)
        end

        # Deserialize Response
        if status_code == 200
          begin
            parsed_response = response_content.to_s.empty? ? nil : JSON.load(response_content)
            result.body = Advisor::Models::SuppressionContractListResult.new.from_json(parsed_response)
          rescue Exception => e
            fail MsRest::DeserializationError.new('Error occurred in deserializing the response', e.message, e.backtrace, result)
          end
        end

        result
      end

      promise.execute
    end

  end
end
