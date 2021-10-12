---
title: "Deploy to Azure using GitHub Actions"
description: "Learn to deploy your application to Azure using GitHub Actions workflows created by Visual Studio"
ms.date: 09/03/2021
ms.topic: how-to
helpviewer_keywords:
  - "deployment, GitHub Actions"
  - GitHub Actions, publish
author: mikejo5000
ms.author: mikejo
manager: jmartens
ms.technology: vs-ide-deployment
monikerRange: '>= vs-2019'
ms.workload:
  - "multiple"
---

# Deploy your application to Azure using GitHub Actions workflows created by Visual Studio

Starting in Visual Studio 2019 version 16.11, you can create new GitHub Action workflows for .NET projects hosted on GitHub.com.

## How does it work?

In Solution Explorer, right-click your GitHub.com hosted project and choose **Publish**.

![right-click > Publish](./media/solution-explorer-publish.png)

On the next screen, select **Azure** and then choose **Next**.

![select Azure](./media/wizard-azure.png)

Depending on your [project type](#which-project-types-are-supported), you get a different list of Azure services to pick from. Pick one of the [supported Azure services](#which-azure-services-are-supported) that fits your needs.

![select the appropriate Azure service for your project](./media/wizard-pick-azure-service.png)

On the final step of the wizard, select **CI/CD using GitHub Actions workflows (generates yml file)** and then choose **Finish**.

![CI/CD using GitHub Actions workflows (generates yml file)](./media/wizard-final-step.png)

Visual Studio generates a new GitHub Actions workflow and asks you to commit it and push it to GitHub.com.

![commit and push](./media/summary-commit-and-push.png)

If you complete this step using the [built-in Git tooling](../version-control/git-with-visual-studio.md#git-changes-window), Visual Studio will detect the execution of the workflow.

![workflow is running](./media/summary-workflow-running.png)

## Setting the GitHub secrets

For the generated workflow to successfully deploy to Azure, it may require access to a [publish profile](/azure/app-service/deploy-github-actions?tabs=applevel#configure-the-github-secret) 

![one github secret](./media/summary-one-github-secret.png)

A successful deployment may also require access to a [service principal](/azure/app-service/deploy-github-actions?tabs=userlevel#configure-the-github-secret).

![two github secrets](./media/summary-two-github-secrets.png)

In all cases, Visual Studio tries to set the GitHub secret for you with the correct value. If it fails, it will let you know and give you the opportunity to try again.

![github secret missing](./media/summary-one-github-secret-missing.png)

If it fails to set the secret again, Visual Studio gives you the opportunity to get access to the secret manually, so you can complete the process through your repo's page on github.com.

![set missing github secret](./media/summary-set-github-secret.png)

## Which project types are supported?

* ASP.NET Core
* ASP.NET 5 and above
* Azure Functions

## Which Azure services are supported?

* Azure Web Apps
* Azure Functions
* Azure API Management
