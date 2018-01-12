---
title: "Azure SDK for Python | Microsoft Docs"
ms.custom: ""
ms.date: 03/07/2017
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "devlang-python"
ms.devlang: python
ms.tgt_pltfrm: ""
ms.topic: "article"
caps.latest.revision: 11
author: "kraigb"
ms.author: "kraigb"
manager: ghogen
ms.workload: 
  - "python"
  - "data-science"
  - "azure"
---

# Azure SDK for Python

The Azure SDK for Python makes it easy to consume and manage Microsoft Azure services from applications running on Windows, Mac OSX, and Linux.

## Installation

The Azure SDK is installed from the [Python Package Index](https://pypi.python.org/pypi/azure).

Install the **latest stable version** (supports Python 2.7 and 3.3+) as follows:

```command
pip install azure
```

You can also follow [Install Python and the SDK](https://azure.microsoft.com/documentation/articles/python-how-to-install/) in the Azure documentation.

## Documentation

Documentation can be found on [azure-sdk-for-python.readthedocs.org](http://azure-sdk-for-python.readthedocs.org/en/latest/index.html).

The [Azure SDK for Python Developer Center](http://azure.microsoft.com/develop/python/) also has a number of helpful resources, including a number of tutorials such as:

- Creating web apps with [Django](/azure/app-service-web/web-sites-python-create-deploy-django-app) [Flask](/azure/app-service-web/web-sites-python-create-deploy-flask-app), and [Bottle](/azure/app-service-web/web-sites-python-create-deploy-bottle-app).
- [Blob storage](/azure/storage/storage-python-how-to-use-blob-storage)
- [Table storage](/azure/storage/storage-python-how-to-use-table-storage)
- [Queue storage](/azure/storage/storage-python-how-to-use-queue-storage)
- [DocumentDB](/azure/documentdb/documentdb-python-application)
- [Service Bus Queues](/azure/service-bus-messaging/service-bus-python-how-to-use-queues)
- [Service Bus Topics/Subscriptions](/azure/service-bus-messaging/service-bus-python-how-to-use-topics-subscriptions)
- [Service Management](/azure/cloud-services/cloud-services-python-how-to-use-service-management)

For public APIs without documentation, the unit tests in the [SDK's GitHub repository](https://github.com/Azure/azure-sdk-for-python) are a good source of information:

- [Storage unit tests](https://github.com/Azure/azure-storage-python/tree/master/tests)
- [Service Bus unit tests](https://github.com/Azure/azure-sdk-for-python/tree/master/azure-servicebus/tests)
- [Service Management unit tests](https://github.com/Azure/azure-sdk-for-python/tree/master/azure-servicemanagement-legacy/tests)
- [Resource Management unit tests](https://github.com/Azure/azure-sdk-for-python/tree/master/azure-mgmt/tests)

## Support

The Git repository for the SDK is located at [https://github.com/Azure/azure-sdk-for-python](https://github.com/Azure/azure-sdk-for-python).

[File issues at the repository](https://github.com/Azure/azure-sdk-for-python/issues) if you find any problems or have questions regarding the usage of the SDK.
