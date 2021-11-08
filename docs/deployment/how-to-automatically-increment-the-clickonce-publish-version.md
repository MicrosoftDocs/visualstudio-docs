---
title: Auto-increment the ClickOnce publish version
description: Learn how to disable automatic incrementing of revision number for your ClickOnce application using Visual Studio.
ms.custom: SEO-VS-2020
ms.date: 11/04/2016
ms.topic: how-to
dev_langs: 
  - VB
  - CSharp
  - C++
helpviewer_keywords: 
  - deploying applications [ClickOnce], incrementing publish version automatically
  - Publish Version property, incrementing
  - ClickOnce deployment, incrementing publish version automatically
  - publishing, ClickOnce
ms.assetid: 686ab88a-6305-4914-a05b-fe269cc0ae1e
author: mikejo5000
ms.author: mikejo
manager: jmartens
ms.technology: vs-ide-deployment
ms.workload: 
  - multiple
---
# How to: Automatically increment the ClickOnce publish version

When publishing a [!INCLUDE[ndptecclick](../deployment/includes/ndptecclick_md.md)] application, changing the `Publish Version` property causes the application to be published as an update. By default, Visual Studio automatically increments the `Revision` number of the `Publish Version` each time you publish the application.

You can disable this behavior on the **Publish** page of the **Project Designer**.

> [!NOTE]
> The dialog boxes and menu commands you see might differ from those described in Help depending on your active settings or edition. To change your settings, choose **Import and Export Settings** on the **Tools** menu. For more information, see [Reset settings](../ide/environment-settings.md#reset-settings).

## To disable automatically incrementing the publish version

1. With a project selected in **Solution Explorer**, on the **Project** menu, click **Properties**.

2. Click the **Publish** tab.

3. In the **Publish Version** section, clear the **Automatically increment revision with each release** check box.

## See also

- [How to: Set the ClickOnce publish version](../deployment/how-to-set-the-clickonce-publish-version.md)
- [Publish ClickOnce applications](../deployment/publishing-clickonce-applications.md)
- [How to: Publish a ClickOnce application using the Publish Wizard](../deployment/how-to-publish-a-clickonce-application-using-the-publish-wizard.md)