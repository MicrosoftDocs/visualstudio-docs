---
title: Azure SDK for Python
description: The Azure SDK for Python makes it easy to consume Microsoft Azure services from Python applications running on any platform.
ms.date: 09/56/2018
ms.prod: visual-studio-dev15
ms.technology: vs-python
ms.topic: conceptual
author: kraigb
ms.author: kraigb
manager: douge
ms.workload: 
  - python
  - data-science
  - azure
---

# Azure SDK for Python

The Azure SDK for Python makes it easy to consume and manage Microsoft Azure services from applications running on Windows, Mac OSX, and Linux.

## Installation

The Azure SDK is installed from the [Python Package Index](https://pypi.python.org/pypi/azure).

Install the **latest stable version** (supports Python 2.7 and 3.x) as follows:

```command
pip install azure
```

You can also follow [Install Python and the SDK](https://docs.microsoft.com/azure/python-how-to-install/) in the Azure documentation.

## Documentation

Full documentation is found on the [Azure for Python developer center](https://docs.microsoft.com/en-us/python/azure/?view=azure-python). For a qucik experience, see [Get started with cloud development using Python](/python/azure/python-sdk-azure-get-started?view=azure-python).

Also see these tutorials for other using Azure services with Python:

- Azure App Service:
  - [Create a web apps](/azure/app-service/containers/quickstart-python)
  - [Build a Docker Python and PostgreSQL web app in Azure](/azure/app-service/containers/tutorial-docker-python-postgresql-app)
- Azure Storage:
  - [Blob storage](/azure/storage/blobs/storage-quickstart-blobs-python)
  - [Table storage and Cosmos DB](/azure/cosmos-db/table-storage-how-to-use-python)
  - [Queue storage](/azure/storage/queues/storage-python-how-to-use-queue-storage)
  - [Flask and Cosmos DB](/azure/cosmos-db/sql-api-python-application)
- Service Bus
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
