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

With Visual Studio, you can both develop apps that run in the Azure cloud, and add Azure services to on-premises, desktop, and mobile apps.

### Local emulation support

During the development phase, Visual Studio enables you to experiment and develop with local emulators of Azure services for convenience and cost-savings, and later deploy to Azure.

### Docker support

You can also work with Docker to containerize your apps and services, which provides a consistent and reproducible operating system and environment for a running application. Visual Studio provides the same familiar experience when [debugging containers](../containers/edit-and-refresh.md), helps you [monitor and manage the lifecycle of your containers locally](../containers/view-and-diagnose-containers.md), and can [deploy your containers to a container registry](../containers/hosting-web-apps-in-docker.md).

### Azure deployment support

With Visual Studio you can deploy your application to Azure, on demand, with the click of a button. This is great for dev / test scenarios where CICD might not be already configured. If you need help configuring CICD for a GitHub.com repo for the first time, Visual Studio can help you get started with GitHub Action starter workflows.

### Integrated Azure features

When running in the Azure cloud, apps can benefit from Azure’s high availability standards, [scaling up](/azure/app-service/manage-scale-up) and [scaling out](/azure/app-service/manage-automatic-scaling?tabs=azure-portal) capabilities, [monitoring](/azure/azure-monitor/app/asp-net), [load testing](/azure/load-testing/overview-what-is-azure-load-testing), and other benefits. Visual Studio comes integrated with Azure functionality like [remote debugging](../debugger/remote-debugging?view=vs-2022), viewing logs, and more.

Scenarios

•	ASP.NET Web App, connecting to Azure Storage, using it to 
o	store and retrieve a blob
o	manage files
o	implement messaging using queues
o	manage structured nosql data 

•	ASP.NET Web App, connecting to Azure Cache for Redis, using it to 
o	cache data coming from an API (i.e., reduce API calls)
o	cache output (i.e., reduce CPU usage)

•	ASP.NET Web App, authenticating users with
o	Social accounts: Facebook, Google, MSA, etc.
o	Azure AD accounts (from a single tenant)
o	Azure AD accounts (from multiple different tenants)
o	Other popular authentication providers?

•	ASP.NET Web App being deployed to Azure and all of its configuration for all environments (test, UAT, pre-prod, prod) is managed through Azure App Configuration.

•	ASP.NET Web App using Azure Key Vault to access secrets. Cover both scenarios of the app running in Azure and accessing secrets, as well as using Key Vault for local F5 as well, as well as using secrets.json for local F5 as well.

•	ASP.NET Web App + Azure SQL Database + Entity Framework. Cover how we make local changes to the database and how do the changes to the database schema and contents get pushed to Azure.

•	ASP.NET Web App + Workers. Cover how it’s free to run a worker service on an existing App Service instance and it can be a direct replacement for the Windows Services that people are running on-prem and in VMs.

•	We can come up with more scenarios if we want to

Recommendations

•	If you are unsure, try Azure App Service.
•	If you need triggers, try Azure Functions.
•	If you need easy containers, try Azure Container Apps.
•	If you need advanced containers, try Azure Kubernetes Service.
•	If you want added control on top of you APIs, try Azure API Management.
•	If you want to support multiple long client connections, try Azure SignalR Service.

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

## On-premises app using Azure services such as Azure storage, Azure SQL database

