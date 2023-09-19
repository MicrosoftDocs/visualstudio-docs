---
title: Azure development with Visual Studio
description: Learn about how you can connect your apps to Azure services in Visual Studio and deploy them to the cloud.
author: ghogen
manager: jmartens
ms.technology: vs-azure
ms.custom: vs-azure
ms.workload: azure-vs
ms.topic: overview
ms.date: 09/19/2023
ms.author: ghogen
monikerRange: ">=vs-2019"
---
# Azure development with Visual Studio

With Visual Studio, you can develop apps and services that run in the Azure cloud. You can also add Azure services to an on-premises application. During the development phase, you can experiment and develop with local emulators of Azure services for convenience and cost-savings, and later deploy to Azure. With Visual Studio, you can deploy a service, web site, or web application to Azure on demand, or integrate with Azure Pipelines or GitHub Actions to deploy to Azure using continuous integration and delivery (CI/CD).

When running in the Azure cloud, apps can benefit from Azure’s high availability standards, scalability capabilities, monitoring, testing, and other benefits.

You can also work with Docker to containerize your apps and services, which provides a consistent and reproducible operating system and environment for a running application.

For multi-container services in Azure, whether it’s a web site with a few supporting web services such as Redis cache, a web API, or Azure Functions, or a complex set of microservices , you have various options for orchestrating the hosting and communication between the containers, such as Docker Compose or Kubernetes.
You can also use Visual Studio to debug all your apps and services, whether locally, in containers, or remotely in Azure.

Whether your applications are coded in .NET, Python, or JavaScript, you have options for deploying them to run in the Azure cloud. For ASP.NET web apps and .NET apps, you can use Visual Studio to add connections to Azure services to store binary data (blobs), manage message queues, access cloud-hosted databases, store secrets securely, manage authorization and authentication with identity management, and access an increasingly wide range of Azure services.
For new development of Azure-hosted web sites, web applications, web services and microservices, Microsoft recommends Azure services such as App Service and Azure Container Apps. For existing mature applications developed using the classic Azure cloud services, continued support is sustained by Azure Cloud Services (extended support).
Visual Studio also helps you work with Azure virtual machines, which continue to be important. For example, you can deploy to a virtual machine and debug services running on a virtual machine in Azure.

## Host a web applications in Azure

A web site or web application can be anything from a simple set of static pages with various resources such as images and other media files, to a complex set of pages, supporting services such as storage, databases, identity management, and caching, as well as REST APIs, or other callable functions. Web sites and web applications might or might not be containerized using Docker containers; container-based apps that consist of multiple services typically benefit from a container orchestrator, such as Docker Compose or Kubernetes.  In the microservices model, containers communicate in a language-independent and framework-independent manner through standard protocols such as HTTPS and REST, and so development teams to choose the appropriate technology stack for each individual microservice or leverage existing legacy codebases regardless of language and framework dependencies.

### ASP.NET single project



### Containerized

### Multiple web projects and services

### JavaScript in web applications – client side ??

### JavaScript in web applications – Node.js server-side ??

### Python single project ??

### Python containerized ??

## Connect to Azure Services

On-premises app using Azure services such as Azure storage, Azure SQL database

