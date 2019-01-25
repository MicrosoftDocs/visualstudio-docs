---
title: Azure SDK for Python
description: The Azure SDK for Python makes it easy to consume Microsoft Azure services from Python applications running on any platform.
ms.date: 12/06/2018
ms.prod: visual-studio-dev15
ms.topic: conceptual
author: kraigb
ms.author: kraigb
manager: jillfra
ms.workload:
  - python
  - data-science
  - azure
---

# Consume Azure services using the Azure SDK for Python

The Azure SDK for Python makes it easy to consume and manage Microsoft Azure services from applications running on Windows, MacOS, and Linux.

## Installation

The Azure SDK is installed from the [Python Package Index](https://pypi.python.org/pypi/azure).

Install the **latest stable version** (supports Python 2.7 and 3.x) as follows:

```command
pip install azure
```

You can also follow [Install Python and the SDK](https://docs.microsoft.com/azure/python-how-to-install/) in the Azure documentation.

## Documentation

The [Azure SDK for Python Developer Center](https://docs.microsoft.com/python/azure/?view=azure-python) also has a number of helpful resources, including a number of tutorials:

- [Creating web apps on Azuyre App Service on Linux](/azure/app-service/containers/quickstart-python).
- [Blob storage](/azure/storage/blobs/storage-quickstart-blobs-python)
- [Table storage](/azure/cosmos-db/table-storage-how-to-use-python)
- [Queue storage](/azure/storage/storage-python-how-to-use-queue-storage)
- [Azure Cosmos DB](/azure/cosmos-db/sql-api-python-application)
- [Service Bus queues](/azure/service-bus-messaging/service-bus-python-how-to-use-queues)
- [Service Bus topics/subscriptions](/azure/service-bus-messaging/service-bus-python-how-to-use-topics-subscriptions)
- [Service management](/azure/cloud-services/cloud-services-python-how-to-use-service-management)

For public APIs without documentation, the unit tests in the [SDK GitHub repository](https://github.com/Azure/azure-sdk-for-python) are a good source of information:

- [Storage unit tests](https://github.com/Azure/azure-storage-python/tree/master/tests)
- [Service Bus unit tests](https://github.com/Azure/azure-sdk-for-python/tree/master/azure-servicebus/tests)
- [Service management unit tests](https://github.com/Azure/azure-sdk-for-python/tree/master/azure-servicemanagement-legacy/tests)

## Support

The GitHub repository for the SDK is located at [https://github.com/Azure/azure-sdk-for-python](https://github.com/Azure/azure-sdk-for-python).

[File issues at the repository](https://github.com/Azure/azure-sdk-for-python/issues) if you find any problems or have questions regarding the usage of the SDK.
