---
title: Azure development with Visual Studio
description: Learn about how you can connect your apps to Azure services in Visual Studio and deploy them to the cloud.
author: ghogen
manager: mijacobs
ms.subservice: azure-development
ms.topic: overview
ms.date: 7/1/2025
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
| Multicontainer app | [Deploy a multicontainer app to Azure Container Apps](./deploy-multicontainer-azure-container-apps.md) |
| Azure Functions | [Create your first C# function in Azure using Visual Studio](/azure/azure-functions/functions-create-your-first-function-visual-studio#publish-the-project-to-azure) |
| Azure Container Registry | [Deploy an ASP.NET container to a container registry using Visual Studio](../containers/hosting-web-apps-in-docker.md) |

If you need help configuring CI/CD for a GitHub repo for the first time, Visual Studio can help you get started with GitHub Action starter workflows. Learn more at [Deploy your application to Azure using GitHub Actions workflows created by Visual Studio](azure-deployment-using-github-actions.md). Read more about setting up CI/CD for deployment to Azure at [Continuous deployment to Azure App Service](/azure/app-service/deploy-continuous-deployment?tabs=github).

## .NET Aspire

[.NET Aspire](/dotnet/aspire) provides infrastructure for orchestrating services and components of observable, cloud-based apps. *Observable apps* are those that are set up to be thoroughly monitored in real-time while executing. .NET Aspire is particularly relevant during development time as a means of organizing and coordinating multiple services, databases, and other dependencies.

Visual Studio 17.9 and later, with the **ASP.NET and web development** and **Azure development** workloads installed, includes the [.NET Aspire SDK](/dotnet/aspire/fundamentals/dotnet-aspire-sdk) and provides [project templates](/dotnet/aspire/fundamentals/aspire-sdk-templates?pivots=visual-studio) for .NET Aspire.

ASP.NET Core projects include an option to enlist in Aspire orchestration at project creation time, and a context menu item, **Add** > **NET Aspire Orchestrator Support** in Solution Explorer that you can use to enlist a project in Aspire orchestration. These actions add Aspire orchestration projects (AppHost and ServiceDefaults) to the solution (unless already present). In Visual Studio 17.13 and later, this functionality is also supported for Azure Functions projects. For more detailed information, see [.NET Aspire tooling](/dotnet/aspire/fundamentals/setup-tooling?tabs=windows&pivots=visual-studio).

## Debug in Azure using Visual Studio

You can use Visual Studio debug your application while it's running in Azure, so that you can identify and reproduce problems in an environment that is as close as possible to a production environment. For web apps hosted in Azure App Service, see [Remote debug ASP.NET Core on Azure App Service](../debugger/remote-debugging-azure-app-service.md). For Azure Functions, see [Develop Azure Functions with Visual Studio - Remote debugging](/azure/azure-functions/functions-develop-vs#remote-debugging?tabs=isolated-process).

If you're using a virtual machine (VM) to host an ASP.NET Core web app, see [Remote debug ASP.NET Core on Internet Information Services (IIS) using an Azure VM from Visual Studio](../debugger/remote-debugging-azure.md).

## Use integrated Azure features

When running in the Azure cloud, apps can benefit from the Azure standards for high availability, [scaling up](/azure/app-service/manage-scale-up) and [scaling out](/azure/app-service/manage-automatic-scaling?tabs=azure-portal) capabilities, [monitoring](/azure/azure-monitor/app/asp-net), [load testing](/azure/load-testing/overview-what-is-azure-load-testing), and other benefits. Visual Studio comes integrated with Azure functionality like [Remote debugging](../debugger/remote-debugging.md), viewing logs, and more.

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

## ASP.NET web applications

See our [overview](overview-aspnet-azure-development.md) for developing ASP.NET web applications for Azure in Visual Studio.

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
