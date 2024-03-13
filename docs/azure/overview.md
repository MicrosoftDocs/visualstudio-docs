---
title: Azure development with Visual Studio
description: Learn about how you can connect your apps to Azure services in Visual Studio and deploy them to the cloud.
author: ghogen
manager: mijacobs
ms.subservice: azure-development
ms.topic: overview
ms.date: 01/31/2024
ms.author: ghogen
monikerRange: ">=vs-2019"
---

# Azure development with Visual Studio

Application development can be easier if you use cloud services to handle many issues that you would otherwise have to implement. When you use cloud services hosted in the Azure cloud, you use a reliable and highly available cloud environment that is managed by Microsoft to handle much of the infrastructure that many apps and services need, so that you can focus development efforts on what is unique to your application.

In this article, you learn about how Visual Studio can help with Azure development, whether you're getting a web site up and running, connecting to services like storage, databases, secrets management, or using services that add value like caching.

[!INCLUDE [subscription-azure-benefits](includes/subscription-azure-benefits.md)]

You can host your web apps in Azure and dynamically scale out to serve larger numbers of concurrent users, instead of overloading a limited infrastructure. Hosting in Azure makes it possible to make use of the rich ecosystem of services that the Azure platform provides. Your apps can be more easily managed using rich services such App Service, or for containerized apps, Azure Container Apps.

For on-premises apps, you can attach to Azure to get the benefits of some specific Azure services, such as storage of blobs, databases hosted in Azure, monitoring via App Insights, identity management, and much more.

Visual Studio has many capabilities that can make it much easier to develop applications that connect to Azure services, or that are themselves deployed to Azure and hosted in the Azure cloud. Visual Studio provides mechanisms to make it easier to connect to services during the initial development phase, as well as making it easy to publish or deploy an application to Azure, and also, you can connect to your Azure application with the Visual Studio debugger on your local machine, making your debugging experience for cloud applications as easy as local debugging.

## Supported technologies and languages

With Visual Studio, you can both develop apps that run in the Azure cloud, and connect to Azure services from your on-premises, desktop, and mobile apps. Visual Studio is the most full-featured and complete environment for Windows developers to connect .NET and ASP.NET applications to Azure services. Visual Studio also supports development in other technology stacks, such as Node.js and Python, which you can use to create web sites and web applications that you can deploy to Azure using the Azure CLI.

C++ developers can access Azure services such as Azure Storage using a C++ client library, and IoT device developers using C and C++ can connect devices and services to Azure. See [Cloud and web programming in Visual C++](/cpp/cloud/cloud-and-web-programming-in-visual-cpp).

Users of Azure Cloud Services, supported in Visual Studio for many previous releases, can continue to work with these services in Visual Studio using [Azure Cloud Services (extended support)](../azure/cloud-services-extended-support.md).

## Connect to Azure services

When you want to use an Azure service in your application, it usually requires multiple changes to your project, such as package references, code changes, and configuration changes, as well as many changes in Azure to specify the services to connect to, or create them if they don't already exist. Visual Studio helps make this process easier by making those changes in your project and in Azure, based on the information you provide. Visual Studio also gives a list of all the changes, so you can examine them and fully understand what changed.

Visual Studio **Connected Services** is the name for the step-by-step wizards you can use to connect your projects (web and on-premises) to Azure services. Read more about the Azure services you can connect to and manage from Visual Studio at [About Visual Studio Connected Services](overview-connected-services.md).

You can perform all the required Azure operations right from the Visual Studio IDE as you go through the Connected Services wizards. Instead of using the [Azure portal](https://portal.azure.com), you can provision resources in Azure, create resource groups, browse and view Azure resources, and deploy your applications and services. Once your project is connected to Azure services or deployed, the **Connected Services** tab displays information about your resources, and contains convenient links to your deployments. See [Work with Azure in Visual Studio](overview-azure-integration.md).

## Deploy your applications to the Azure cloud

With Visual Studio you can deploy your application to Azure, on demand, with the click of a button. This convenience is great during development and testing, where CI/CD might not be already configured. CI/CD (continuous integration and continuous delivery (CI/CD)) is a system whereby local changes made to application code by development teams are automatically integrated into the deployed application running in Azure, without interrupting the deployed service. You can use [Azure Pipelines](/azure/devops/pipelines) or [GitHub Actions](../azure/azure-deployment-using-github-actions.md) to set this up.

What are you deploying?

| Deployment target | Documentation |
| - | - |
| Azure App Service (.NET Core) | [Deploy an ASP.NET Core web app](/azure/app-service/quickstart-dotnetcore?tabs=net70&pivots=development-environment-vs&toc=%2Fvisualstudio%2Fazure%2Ftoc.json&bc=%2Fvisualstudio%2Fazure%2Fbreadcrumb%2Ftoc.json#publish-your-web-app) |
| Azure App Service (.NET Framework) | [Deploy an ASP.NET web app (.NET Framework)](/azure/app-service/quickstart-dotnetcore?toc=%2Fvisualstudio%2Fazure%2Ftoc.json&bc=%2Fvisualstudio%2Fazure%2Fbreadcrumb%2Ftoc.json&tabs=netframework48&pivots=development-environment-vs) |
| Azure Container Apps | [Deploy to Azure Container Apps using Visual Studio](/azure/container-apps/deploy-visual-studio) |
| Azure Functions | [Create your first C# function in Azure using Visual Studio](/azure/azure-functions/functions-create-your-first-function-visual-studio#publish-the-project-to-azure) |
| Azure Container Registry | [Deploy an ASP.NET container to a container registry using Visual Studio](../containers/hosting-web-apps-in-docker.md) |

If you need help configuring CI/CD for a GitHub repo for the first time, Visual Studio can help you get started with GitHub Action starter workflows. Learn more at [Deploy your application to Azure using GitHub Actions workflows created by Visual Studio](azure-deployment-using-github-actions.md). Read more about setting up CI/CD for deployment to Azure at [Continuous deployment to Azure App Service](/azure/app-service/deploy-continuous-deployment?tabs=github).

## Debug in Azure using Visual Studio

You can use Visual Studio debug your application while it's running in Azure, so that you can identify and reproduce problems in an environment that is as close as possible to a production environment. For web apps hosted in Azure App Service, see [Remote debug ASP.NET Core on Azure App Service](../debugger/remote-debugging-azure-app-service.md). For Azure Functions, see [Develop Azure Functions with Visual Studio - Remote debugging](/azure/azure-functions/functions-develop-vs#remote-debugging?tabs=isolated-process).

If you're using a virtual machine (VM) to host an ASP.NET Core web app, see [Remote debug ASP.NET Core on IIS using an Azure VM from Visual Studio](../debugger/remote-debugging-azure.md).


## Use integrated Azure features

When running in the Azure cloud, apps can benefit from Azure's high availability standards, [scaling up](/azure/app-service/manage-scale-up) and [scaling out](/azure/app-service/manage-automatic-scaling?tabs=azure-portal) capabilities, [monitoring](/azure/azure-monitor/app/asp-net), [load testing](/azure/load-testing/overview-what-is-azure-load-testing), and other benefits. Visual Studio comes integrated with Azure functionality like [Remote debugging](../debugger/remote-debugging.md), viewing logs, and more.

## Save money with local emulation support

During the development phase, you can experiment and develop with local emulators of Azure services for convenience and cost-savings, and later deploy to Azure. Learn more at [Local and connected configurations](overview-connected-services.md#local-and-connected-configurations).

## Docker support

You can also work with Docker to containerize your apps and services. Using Docker containers provides a consistent and reproducible operating system and environment for a running application. Visual Studio provides the same familiar experience when [debugging containers](../containers/edit-and-refresh.md), helps you [monitor and manage the lifecycle of your containers locally](../containers/view-and-diagnose-containers.md), and can [deploy your containers to a container registry](../containers/hosting-web-apps-in-docker.md).

Once you've containerized your app, it's easy to deploy the containers to Azure using services such as [Azure App Service](/azure/app-service/quickstart-dotnetcore?tabs=net70&pivots=development-environment-vs#publish-your-web-app) or [Azure Container Apps](/azure/container-apps/deploy-visual-studio).

## Connect apps to Azure Storage and database services

Managing files and data can be a lot easier with Azure Storage, which is a highly available, massively scalable, durable, and secure storage for a variety of data objects in the cloud. You can use Azure Storage to store everything and make it available to your web sites, desktop apps, or mobile apps.

Azure also provides many different data services suited to different needs, from a cloud-hosted SQL Database that makes for an easy transition from an on-premises SQL Server, to big data solutions that can scale up to the largest requirements.

### Connect to Azure Storage

- Store and retrieve a blob
- Manage files
- Implement messaging using queues
- Manage structured NoSQL data

Learn more at [Azure Storage](/azure/storage) and learn how to [Connect to Azure Storage](vs-azure-tools-connected-services-storage.md) with Visual Studio.

### Connect to databases

Connecting to [Azure SQL Database](/azure/azure-sql/database/sql-database-paas-overview?view=azuresql&preserve-view=true) and other Azure database offering such as [Azure Cosmos DB](/azure/cosmos-db/introduction) is as easy as connecting to a local [SQL Server](/sql/sql-server/?view=sql-server-ver16&preserve-view=true). For details, see [Databases and data providers](overview-connected-services.md#databases-and-data-providers).

### Connect to web and data services

Data providers are making services available via standard protocols, such as Open Data Protocol (OData) and gRPC. You can connect to these services, or if you're creating web services yourself, you can choose ASP.NET Web API, Azure Functions, or Azure API Management, and add those connections. For a list of supported services and protocols and how to connect to them, see [Connect your app to gRPC, OpenAPI, and WCF endpoints](overview-connected-services.md#connect-your-app-to-grpc-openapi-and-wcf-endpoints).

## ASP.NET Core Web application scenarios

ASP.NET Core provides a comprehensive solution for simple web sites and complex web applications. Azure services can help address many of the needs and solve many of the challenges that arise in web site and web application development. ASP.NET Core web applications frequently use client-side JavaScript.

:::image type="content" source="./media/overview-azure-integration/scalable-ecommerce-web-app.png" alt-text="Diagram of web application example architecture." lightbox="./media/overview-azure-integration/scalable-ecommerce-web-app-high-res.png" :::

### Connect to Azure Cache for Redis

Azure Cache for Redis provides an in-memory data store for Azure services, web sites, and web applications. You can use Azure Cache for Redis as a distributed data or content cache, a session store, a message broker, and more. Supported scenarios include:

- Cache data coming from an API (and thereby reduce API calls)
- Cache output (this can reduce CPU usage)
- Cache session state

Learn more at [What is Azure Cache for Redis?](/azure/azure-cache-for-redis/cache-overview) or get started with [Connect to Azure Cache for Redis by using Visual Studio Connected Services](azure-cache-for-redis-add-connected-service.md).

### Authenticating users

Most web sites need some kind of user management and authentication mechanism, either site-specific or provided by an identity provider with which a user has an existing account. Built-in user authentication is supported in Azure App Service. Learn more at [Authentication and authorization in Azure App Service and Azure Functions](/azure/app-service/overview-authentication-authorization) and get started with [Add app authentication to your web app running on Azure App Service](/azure/app-service/scenario-secure-app-authentication-app-service). Microsoft Entra ID (previously known as Azure Active Directory) is a full-featured cloud-based identity management service. Learn more at [What is Microsoft Entra](/azure/active-directory/fundamentals/whatis).

Supported authentication providers include:

- Social accounts: Facebook, Google, Microsoft account, and others
- Microsoft Entra accounts (from a single tenant)
- Microsoft Entra accounts (from multiple different tenants)

Learn how to start using these services in your apps at [Connect to Microsoft Entra ID by using Connected Services in Visual Studio](vs-active-directory-add-connected-service.md).

### App Configuration

Your ASP.NET web app deployed to Azure might need configuration for all environments (test, user acceptance testing (UAT), preproduction, and production). You can manage this configuration through [Azure App Configuration](/azure/azure-app-configuration/overview). Learn how to connect your apps to Azure App Configuration at [Connect to Azure App Configuration by using Visual Studio Connected Services](vs-azure-tools-connected-services-app-configuration.md).

### Secrets management

Secure storage of passwords and other secrets, such as access keys to databases and tokens for API providers, is a common problem for which Azure Key Vault provides a secure solution. You can use Azure Key Vault to store secrets for your app running in Azure, and also during development, you can use the key vault in Azure, or a local store (`secrets.json`) for local execution, testing, and debugging. Get started during design and development without any dependencies on the cloud, but then transition to later stages of testing and production with no disruption. Learn more at [Azure Key Vault](/azure/key-vault) and get started at [Connect Key Vault to your web application by using Visual Studio Connected Services](/azure/key-vault/general/vs-key-vault-add-connected-service).

### Data migration using Entity Framework

Visual Studio helps solve the issue of developing your app and changing a database locally and then synchronizing with a production database in Azure.

In the case of ASP.NET Web App using Azure SQL Database and Entity Framework, when you make local changes to the database, you can push those schema changes and data changes to Azure in a structured way using Entity Framework migrations. See [Entity Framework migrations](azure-sql-database-add-connected-service.md#entity-framework-migrations).

### Worker services

ASP.NET web apps can benefit from running worker services. There's no additional cost to run a worker service on an existing App Service instance and it can be a direct replacement for the Windows Services that you might be running on-premises or in a virtual machine. See [Worker services in .NET](/dotnet/core/extensions/workers?pivots=dotnet-7-0).

## Other web application technologies

Developers who use JavaScript and Python can use Visual Studio or [Visual Studio Code](https://code.visualstudio.com/docs) for Azure development. With either development environment, [install the Azure CLI](/cli/azure/install-azure-cli) and follow tutorials in the documentation for the Azure CLI, and find quickstarts and tutorials in the documentation for every Azure service that help you add the connection code manually.

Node.js offers another option for web application development with server-side JavaScript. Learn more at [What is Azure for JavaScript developers](/azure/developer/javascript/core/what-is-azure-for-javascript-development) Get started with [Deploy a Node.js web app in Azure](/azure/app-service/quickstart-nodejs?tabs=windows&pivots=development-environment-vscode).

Python is an increasingly popular language which, when using web frameworks Django and Flask, is another way of developing web applications. See [Get started with Python on Azure](/azure/developer/python/get-started?tabs=windows%2Capt%2Ccmd).

## Recommended Azure services

This section can help you learn what Azure services might be useful. Start by going through these quickstarts that show you how to get started with each service using Visual Studio as a development tool. These links take you into the documentation for each Azure service, starting at a page that is geared toward Visual Studio users (where available).

If you are unsure of what Azure service might best fit your needs, try [Azure App Service](/azure/app-service/quickstart-dotnetcore?tabs=net70&pivots=development-environment-vs#publish-your-web-app).

[Triggers](/azure/azure-functions/functions-triggers-bindings?tabs=isolated-process%2Cpython-v2&pivots=programming-language-csharp) are events that you set up to run code when certain conditions occur. They can be scheduled according to a timer, or they can be set up to respond to messages in a queue, events within other Azure services, or web hooks. If you need triggers, try [Azure Functions](/azure/azure-functions/functions-create-your-first-function-visual-studio).

If you need easy containers, try [Azure Container Apps](/azure/container-apps/deploy-visual-studio).

If you need advanced containers, try [Azure Kubernetes Service](/azure/aks).

If you want added control on top of your APIs, try [Azure API Management](/azure/api-management/api-management-key-concepts).

If you want to support multiple long client connections, try [Azure SignalR Service](/azure/azure-signalr/signalr-overview).

If you're developing complex distributed apps and need orchestration between many services, try [.NET Aspire](/dotnet/aspire/get-started/aspire-overview).

## Next steps

Learn more about Azure services that you might be interested in at [Azure services](https://azure.microsoft.com/products/).

## Related content

Get architectural advice for Azure development at [Azure Architecture Center](/azure/architecture/).

For work on legacy Azure Cloud Services, see [Azure Cloud Services - Extended Support](./cloud-services-extended-support.md).
