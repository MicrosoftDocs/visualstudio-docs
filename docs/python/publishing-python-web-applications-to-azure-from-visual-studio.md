---
title: Publish a Python app to Azure App Service
description: Options for publishing a Python app to Azure App Service, including Git deploy and containers for Linux, and deploying to IIS.
ms.date: 03/13/2019
ms.topic: conceptual
author: JoshuaPartlow
ms.author: joshuapa
manager: jillfra
ms.custom: seodec18
ms.workload:
  - python
  - data-science
  - azure
---

# Publish to Azure App Service

At present, Python is supported on Azure App Service for Linux, and you can publish apps using [Git deploy](#publish-to-app-service-on-linux-using-git-deploy) and [containers](#publish-to-app-service-on-linux-using-containers), as described in this article.

> [!Note]
> Python support on Azure App Service for Windows is officially deprecated. As a result, the **Publish** command in Visual Studio is officially supported only for an [IIS target](#publish-to-iis), and remote debugging on Azure App Service is no longer officially supported.
>
> However, [Publishing to App Service on Windows](publish-to-app-service-windows.md) features still works for the time being, as the Python extensions for App Service on Windows remain available but will not be serviced or updated.

## Publish to App Service on Linux using Git deploy

Git deploy connects an App Service on Linux to a specific branch of a Git repository. Committing code to that branch automatically deploys to the App Service, and App Service automatically installs any dependencies listed in *requirements.txt*. In this case, App Service on Linux runs your code in a pre-configured container image that uses the Gunicorn web server. At present, this service is in Preview and not supported for production use.

For more information, see the following articles in the Azure documentation:

- [Quickstart: Create a Python web app in App Service](/azure/app-service/containers/quickstart-python?toc=%2Fpython%2Fazure%2FTOC.json) provides a short walkthrough of the Git deploy process using a simple Flask app and deployment from a local Git repository.
- [How to configure Python](/azure/app-service/containers/how-to-configure-python) describes the characteristics of the App Service on Linux container and how to customize the Gunicorn startup command for your app.

## Publish to App Service on Linux using containers

Instead of relying on the pre-built container with App Service on Linux, you can provide your own container. This option allows you to choose which web servers you use and to customize the container's behavior.

There are two options to build, manage, and push containers:

- Use Visual Studio Code and the Docker extension, as described on [Deploy Python using Docker Containers](https://code.visualstudio.com/docs/python/tutorial-deploy-containers). Even if you don't use Visual Studio Code, the article provides helpful details on building container images for Flask and Django apps using the production-ready uwsgi and nginx web servers. You can then deploy those same container using the Azure CLI.

- Use the command line and Azure CLI, as described on [Use a custom Docker image](/azure/app-service/containers/tutorial-custom-docker-image) in the Azure documentation. This guide is generic, however, and not specific to Python.

## Publish to IIS

From Visual Studio, you can publish to a Windows virtual machine or other IIS-capable computer with the **Publish** command. When using IIS, be sure to create or modify a *web.config* file in the app that tells IIS where the find the Python interpreter. For more information, see [Configure web apps for IIS](configure-web-apps-for-iis-windows.md).
