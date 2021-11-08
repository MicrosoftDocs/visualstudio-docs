---
title: GitHub Actions
description: Learn about how you can develop GitHub Actions in Visual Studio
author: ghogen
manager: jmartens
ms.technology: vs-azure
ms.custom: vs-azure
ms.workload: azure-vs
ms.topic: overview
ms.date: 10/19/2021
ms.author: ghogen
monikerRange: ">=vs-2019"
---
# An overview of the GitHub Actions integration in Visual Studio

[GitHub Actions](https://github.com/features/actions) is the Continuous Integration / Continuous Delivery (CI/CD) solution offered by GitHub. You can host your code for free on GitHub.com and you can use GitHub Actions to automatically build, test and deploy your application when code changes are made.

## Visual Studio generates working GitHub Action workflows for you

If your codebase is hosted on GitHub.com and your deployment target is an Azure hosting service that Visual Studio supports, you will automatically be offered to configure GitHub Actions for your repo.

![Screenshot showing CI/CD publish option.](./media/github-actions-deployment-mode.png)

Visual Studio also simplifies the process by handling your application secrets for you. 

Get started by right-clicking on your project in Solution Explorer and selecting **Publish** from the context menu. For a tutorial, see [Deploy your application to Azure using GitHub Actions workflows created by Visual Studio](../deployment/azure-deployment-using-github-actions.md).

## How do I get my project on GitHub.com?

See [create a new Git repository](../version-control/git-with-visual-studio.md#create-a-new-git-repository).

## See also

[GitHub Actions and .NET](/dotnet/devops/github-actions-overview)