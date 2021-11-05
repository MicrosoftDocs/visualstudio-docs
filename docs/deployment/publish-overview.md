---
title: "Publish overview"
description: "Learn about the Publish window in Visual Studio"
ms.date: 10/14/2021
ms.topic: overview
dev_langs:
  - "FSharp"
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords:
  - "Publish tool"
  - ".NET applications, publishing"
author: mikejo5000
ms.author: mikejo
manager: jmartens
monikerRange: '>= vs-2019'
ms.technology: vs-ide-deployment
ms.workload:
  - "multiple"
---

# Overview of Publish

For ASP.NET, .NET Core, and Python apps, you can use the Publish tool to deploy your applications.

## What is Publish?

The Publish tool helps you deploy your application to various destinations. Get started by right-clicking your project in Solution Explorer and selecting **Publish** from the context menu.

## How does it work?

Publish uses *profiles* (.pubxml files) to allow for multiple project configurations and multiple publish targets for a single project.

![publish profiles](./media/publish-profiles.png)

The contents of the profile are XML and based on MSBuild.

![publish profile example contents](./media/publish-profile-example-contents.png)

The Publish profile keeps credentials in a separate, hidden by default file that doesn’t get checked-in.

![hidden user files](./media/separate-user-files.png)

You can always import publish profiles [from IIS](../deployment/tutorial-import-publish-settings-iis.md#create-the-publish-settings-file-in-iis-on-windows-server) and [Azure App Service](../deployment/tutorial-import-publish-settings-azure.md#create-the-publish-settings-file-in-azure-app-service)

![import profile](./media/import-profile.png)

## Visual Studio can help you manage dependencies to Azure services

When you use the Publish tool to deploy your application to Azure, you get the opportunity to configure dependencies to Azure services.

![dependencies during publish](./media/publish-dependencies.png)

The idea is that you may want to connect to a different SQL database or a different Storage account or a different Key Vault for different environments like testing, QA, pre-prod, and so forth.
