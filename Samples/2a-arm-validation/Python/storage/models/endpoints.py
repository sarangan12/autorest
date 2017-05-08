# coding=utf-8
# --------------------------------------------------------------------------
# Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
# Changes may cause incorrect behavior and will be lost if the code is
# regenerated.
# --------------------------------------------------------------------------

from msrest.serialization import Model


class Endpoints(Model):
    """The URIs that are used to perform a retrieval of a public blob, queue or
    table object.

    :param blob: Gets the blob endpoint.
    :type blob: str
    :param queue: Gets the queue endpoint.
    :type queue: str
    :param table: Gets the table endpoint.
    :type table: str
    :param file: Gets the file endpoint.
    :type file: str
    """

    _attribute_map = {
        'blob': {'key': 'blob', 'type': 'str'},
        'queue': {'key': 'queue', 'type': 'str'},
        'table': {'key': 'table', 'type': 'str'},
        'file': {'key': 'file', 'type': 'str'},
    }

    def __init__(self, blob=None, queue=None, table=None, file=None):
        self.blob = blob
        self.queue = queue
        self.table = table
        self.file = file
