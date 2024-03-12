---
title: Deploy ASP.NET web apps to Azure
description: Learn about how you can use Visual Studio to deploy a web app to Azure.
author: ghogen
manager: mijacobs
ms.subservice: azure-development
ms.topic: overview
ms.date: 10/19/2023
ms.author: ghogen
monikerRange: ">=vs-2019"
---

# Deploy an ASP.NET web app to Azure

You can use Visual Studio to deploy a web app to Azure, or you can create automated systems that handle deployment for larger-scale web applications. The methods of deployment through Visual Studio are well-suited to on-demand deployment during the development and testing cycle. For web applications in production or preproduction team development and testing, implementing a CI/CD pipeline in Azure DevOps, or a GitHub Action, enables you and your team to automate the deployment steps in a way that scales up to larger numbers of contributors and continuous updates and changes.

## Deploy with Visual Studio

Deployment through Visual Studio is supported for many different project types. Publish is another term that you'll find used in Visual Studio IDE, which is synonymous with "Deploy." For example, if you right-click on the project node for a project type that Visual Studio can deploy, you'll see the **Publish** menu option, which provides access to wizards that can help configure a deployment, not only to Azure, but to other destinations. For a complete overview of these features in Visual Studio, see [Overview of Publish](../deployment/publish-overview.md).

For Azure deployment to a specific Azure service, you can find deployment steps for Visual Studio, along with other development tools, in the documentation for the specific Azure service, or in the ASP.NET documentation for the most commonly used Azure services for web apps, such as [Azure App Service](/aspnet/core/tutorials/publish-to-azure-webapp-using-vs).

Is your app containerized? If so, you might consider deploying to Azure Container Apps, a service that was designed specifically for containerized apps. See [Azure Container Apps](/azure/container-apps/deploy-visual-studio), but you can also work at a lower level and deploy container images to [Azure Container Registry](../containers/hosting-web-apps-in-docker.md).

For web APIs such as REST APIs or to implement events with triggers, consider deploying as an [Azure function](/azure/azure-functions/functions-create-your-first-function-visual-studio).

## Deploy with Continuous Integration

Continuous integration and continuous delivery (CI/CD) refers to systems that automatically update cloud applications when changes are integrated by individual developers, usually as part of a team effort. These methods scale to larger projects with multiple contributors.

There are two main technologies that you can use to support such scenarios. [Azure Pipelines](/azure/devops/pipelines/get-started-yaml?view=vsts&preserve-view=true) is a powerful and very configurable technology that supports team development at scale.

For continuous deployment from a source repository, see [Continuous deployment to Azure App Service](/azure/app-service/deploy-continuous-deployment), and with a GitHub repo and Visual Studio 2022 and later, you can use [GitHub Actions](overview-github-actions.md) for continuous deployment scenarios.
