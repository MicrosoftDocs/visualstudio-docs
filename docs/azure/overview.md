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

With Visual Studio, you can both develop apps that run in the Azure cloud, and connect to Azure services in your on-premises, desktop, and mobile apps. In this article, you learn about how Visual Studio can help with Azure development, whether you're getting a web site up and running, connecting to services like databases, secrets management, caching, or storage.

## Connected Services

Visual Studio **Connected Services** is the name the features that support connecting your projects (web and on-premises) to Azure services. Read more about the Azure services you can connect to and manage from Visual Studio at [About Visual Studio Connected Services](overview-connected-services.md).

You can perform many common Azure operations right from the Visual Studio IDE. Instead of using the Azure Portal, you can provision resources in Azure, create resource groups, browse and view Azure resources, and of course, deploy your applications and services. Once your project is connected to Azure services or deployed, the **Connected Services** tab displays information about your resources, and contains convenient links to your deployments. See [Work with Azure in Visual Studio](overview-azure-integration.md).

## Azure deployment support

With Visual Studio you can deploy your application to Azure, on demand, with the click of a button. This is great during development and testing, where CI/CD might not be already configured. 

If you need help configuring CI/CD for a GitHub repo for the first time, Visual Studio can help you get started with GitHub Action starter workflows. Learn more at [Deploy your application to Azure using GitHub Actions workflows created by Visual Studio](azure-deployment-using-github-actions.md).

## Integrated Azure features

When running in the Azure cloud, apps can benefit from Azure’s high availability standards, [scaling up](/azure/app-service/manage-scale-up) and [scaling out](/azure/app-service/manage-automatic-scaling?tabs=azure-portal) capabilities, [monitoring](/azure/azure-monitor/app/asp-net), [load testing](/azure/load-testing/overview-what-is-azure-load-testing), and other benefits. Visual Studio comes integrated with Azure functionality like [remote debugging](../debugger/remote-debugging.md), viewing logs, and more.

## Local emulation support

During the development phase, you can experiment and develop with local emulators of Azure services for convenience and cost-savings, and later deploy to Azure. Learn more at [Local and connected configurations](overview-connected-services.md#local-and-connected-configurations).

## Docker support

You can also work with Docker to containerize your apps and services, which provides a consistent and reproducible operating system and environment for a running application. Visual Studio provides the same familiar experience when [debugging containers](../containers/edit-and-refresh.md), helps you [monitor and manage the lifecycle of your containers locally](../containers/view-and-diagnose-containers.md), and can [deploy your containers to a container registry](../containers/hosting-web-apps-in-docker.md).

## Connecting to storage and databases

### Connect to Azure storage

- Store and retrieve a blob
- Manage files
- Implement messaging using queues
- Manage structured NoSQL data 

Learn more at [Azure storage](/azure/storage) and learn how to [Connect to Azure storage](vs-azure-tools-connected-services-storage.md) with Visual Studio.

### Connect to databases

Connecting to Azure SQL database and other Azure database offering such as Cosmos DB is as easy as connecting to a local SQL Server. For details, see [Databases and data providers](overview-connected-services.md#databases-and-data-providers).

### Connect to web and data services

Data providers are making services available via standard protocols, such as OData. You can connect to these, or if you are creating web services yourself, you can choose ASP.NET Web API, Azure Functions, or Azure API Management, and add those connections. For a list of supported services and protocols and how to connect to them, see [Connect your app to gRPC, OpenAPI, and WCF endpoints](overview-connected-services.md#connect-your-app-to-grpc-openapi-and-wcf-endpoints).

## Web application scenarios

ASP.NET Core provides a comprehensive solution for simple web sites and complex web applications. Azure services can help address many of the needs and solve many of the challenges that arise in web site and web application development. ASP.NET Core web applications frequently use client-side JavaScript.

Node.js offers another option for web application development with server-side JavaScript.

Python is an increasingly popular language which, when using web frameworks Django and Flask, is another way of developing web applications.

### Connect to Azure Cache for Redis

- Cache data coming from an API (and thereby reduce API calls)
- Cache output (this can reduce CPU usage)

Learn more at [Connect to Azure Cache for Redis by using Visual Studio Connected Services](azure-cache-for-redis-add-connected-services.md).

### Authenticating users

- Social accounts: Facebook, Google, MSA, etc.
- Azure AD accounts (from a single tenant)
- Azure AD accounts (from multiple different tenants)
- Other popular authentication providers?

### App Configuration

ASP.NET Web App being deployed to Azure and all of its configuration for all environments (test, UAT, pre-prod, prod) is managed through Azure App Configuration.

### Secrets management

ASP.NET Web App using Azure Key Vault to access secrets. Cover both scenarios of the app running in Azure and accessing secrets, as well as using Key Vault for local F5 as well, as well as using secrets.json for local F5 as well.

### Data migration

ASP.NET Web App + Azure SQL Database + Entity Framework. Cover how we make local changes to the database and how do the changes to the database schema and contents get pushed to Azure.

### Worker services

ASP.NET Web App + Workers. Cover how it’s free to run a worker service on an existing App Service instance and it can be a direct replacement for the Windows Services that people are running on-prem and in VMs.

## Recommendations

If you are unsure, try Azure App Service.

If you need triggers, try Azure Functions.

If you need easy containers, try Azure Container Apps.

If you need advanced containers, try Azure Kubernetes Service.

If you want added control on top of you APIs, try Azure API Management.

If you want to support multiple long client connections, try Azure SignalR Service.

## Next steps


