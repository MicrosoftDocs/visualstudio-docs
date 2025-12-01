---

# As a web developer, I want to connect web apps to Azure, and deploy and debug in the cloud.
title: Develop ASP.NET web sites for Azure with Visual Studio
titleSuffix: ""
description: Learn about how Visual Studio can help you connect your ASP.NET web apps to Azure services, including information about the available services.
author: ghogen
manager: mijacobs
ms.subservice: azure-development
ms.topic: overview
ms.date: 04/15/2024
ms.author: ghogen
monikerRange: ">=vs-2019"
---

# Overview: Develop ASP.NET web apps for Azure with Visual Studio

ASP.NET Core provides a comprehensive solution for simple web sites and complex web applications. Azure services can help address many of the needs and solve many of the challenges that arise in web site and web application development. ASP.NET Core web applications frequently use client-side JavaScript.

[!INCLUDE [subscription-azure-benefits](includes/subscription-azure-benefits.md)]

## Prerequisites

If you haven't already, read the [Azure development in Visual Studio](overview.md) overview, which covers the basics of Connected Services in Visual Studio, deploying to Azure, debugging Azure applications, using Docker containers, and much more.

You'll need [Visual Studio](https://aka.ms/vs/download) 2019 or later with the **Azure development** and **ASP.NET and web development** workloads installed.

## Architecture diagram

The following diagram shows an example of an architecture of an Azure web application with some of the Azure services that handle common scenarios, such as storage, accessing a SQL database, and authentication.

:::image type="content" source="./media/overview-azure-integration/scalable-ecommerce-web-app.png" alt-text="Diagram of web application example architecture." lightbox="./media/overview-azure-integration/scalable-ecommerce-web-app-high-res.png" :::

## Connect to storage and databases

Many services not specific to web applications, but important for most web applications, were already covered in the main overview. See [Connect your apps to Azure Storage and databases](overview.md#connect-apps-to-azure-storage-and-database-services), and [Connect your app to gRPC, OpenAPI, and WCF endpoints](overview-connected-services.md#connect-your-app-to-grpc-openapi-and-wcf-endpoints).

## Connect to Azure Cache for Redis

Azure Cache for Redis provides an in-memory data store for Azure services, web sites, and web applications. You can use Azure Cache for Redis as a distributed data or content cache, a session store, a message broker, and more. Supported scenarios include:

- Cache data coming from an API (and thereby reduce API calls)
- Cache output (this can reduce CPU usage)
- Cache session state

Learn more at [What is Azure Cache for Redis?](/azure/azure-cache-for-redis/cache-overview) or get started with [Connect to Azure Cache for Redis by using Visual Studio Connected Services](azure-cache-for-redis-add-connected-service.md).

## Authenticating users

Most web sites need some kind of user management and authentication mechanism, either site-specific or provided by an identity provider with which a user has an existing account. Built-in user authentication is supported in Azure App Service. Learn more at [Authentication and authorization in Azure App Service and Azure Functions](/azure/app-service/overview-authentication-authorization) and get started with [Add app authentication to your web app running on Azure App Service](/azure/app-service/scenario-secure-app-authentication-app-service). Microsoft Entra ID (previously known as Azure Active Directory) is a full-featured cloud-based identity management service. Learn more at [What is Microsoft Entra](/azure/active-directory/fundamentals/whatis).

Supported authentication providers include:

- Social accounts: Facebook, Google, Microsoft account, and others
- Microsoft Entra accounts (from a single tenant)
- Microsoft Entra accounts (from multiple different tenants)

Learn how to start using these services in your apps at [Connect to Microsoft Entra ID by using Connected Services in Visual Studio](vs-active-directory-add-connected-service.md).

## App Configuration

Your ASP.NET web app deployed to Azure might need configuration for all environments (test, user acceptance testing (UAT), preproduction, and production). You can manage this configuration through [Azure App Configuration](/azure/azure-app-configuration/overview). Learn how to connect your apps to Azure App Configuration at [Connect to Azure App Configuration by using Visual Studio Connected Services](vs-azure-tools-connected-services-app-configuration.md).

## Secrets management

Secure storage of passwords and other secrets, such as access keys to databases and tokens for API providers, is a common problem for which Azure Key Vault provides a secure solution. You can use Azure Key Vault to store secrets for your app running in Azure, and also during development, you can use the key vault in Azure, or a local store (`secrets.json`) for local execution, testing, and debugging. Get started during design and development without any dependencies on the cloud, but then transition to later stages of testing and production with no disruption. Learn more at [Azure Key Vault](/azure/key-vault) and get started at [Connect Key Vault to your web application by using Visual Studio Connected Services](/azure/key-vault/general/vs-key-vault-add-connected-service).

## Data migration using Entity Framework

Visual Studio helps solve the issue of developing your app and changing a database locally and then synchronizing with a production database in Azure.

In the case of ASP.NET Web App using Azure SQL Database and Entity Framework, when you make local changes to the database, you can push those schema changes and data changes to Azure in a structured way using Entity Framework migrations. See [Entity Framework migrations](azure-sql-database-add-connected-service.md#entity-framework-migrations).

## Worker services

ASP.NET web apps can benefit from running worker services. There's no additional cost to run a worker service on an existing App Service instance and it can be a direct replacement for the Windows Services that you might be running on-premises or in a virtual machine. See [Worker services in .NET](/dotnet/core/extensions/workers?pivots=dotnet-7-0).

## Next steps

Learn more about Azure services that you might be interested in at [Azure services](https://azure.microsoft.com/products/).

## Related content

Get architectural advice for Azure development at [Azure Architecture Center](/azure/architecture/).

Browse the [ASP.NET documentation](/aspnet/).
