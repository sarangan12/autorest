# coding=utf-8
# --------------------------------------------------------------------------
# Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
# Changes may cause incorrect behavior and will be lost if the code is
# regenerated.
# --------------------------------------------------------------------------

from msrest.serialization import Model


class StorageAccountUpdateParameters(Model):
    """The parameters to update on the account.

    :param tags: Resource tags
    :type tags: dict
    :param account_type: Gets or sets the account type. Note that StandardZRS
     and PremiumLRS accounts cannot be changed to other account types, and
     other account types cannot be changed to StandardZRS or PremiumLRS.
     Possible values include: 'Standard_LRS', 'Standard_ZRS', 'Standard_GRS',
     'Standard_RAGRS', 'Premium_LRS'
    :type account_type: str or :class:`AccountType
     <storage.models.AccountType>`
    :param custom_domain: User domain assigned to the storage account. Name is
     the CNAME source. Only one custom domain is supported per storage account
     at this time. To clear the existing custom domain, use an empty string for
     the custom domain name property.
    :type custom_domain: :class:`CustomDomain <storage.models.CustomDomain>`
    """

    _attribute_map = {
        'tags': {'key': 'tags', 'type': '{str}'},
        'account_type': {'key': 'properties.accountType', 'type': 'AccountType'},
        'custom_domain': {'key': 'properties.customDomain', 'type': 'CustomDomain'},
    }

    def __init__(self, tags=None, account_type=None, custom_domain=None):
        self.tags = tags
        self.account_type = account_type
        self.custom_domain = custom_domain
