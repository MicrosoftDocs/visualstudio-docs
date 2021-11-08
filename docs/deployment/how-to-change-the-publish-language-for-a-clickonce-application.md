---
title: Change publish language for ClickOnce application
description: Learn how to specify a language/culture for a localize application in ClickOnce, instead of defaulting to the language/culture of your development computer.
ms.custom: SEO-VS-2020
ms.date: 11/04/2016
ms.topic: how-to
dev_langs: 
  - VB
  - CSharp
  - C++
helpviewer_keywords: 
  - Publish language property
  - ClickOnce deployment, changing publish language
  - publishing, ClickOnce
ms.assetid: ef5024c4-cda1-4970-bc75-32a2a10c92c3
author: mikejo5000
ms.author: mikejo
manager: jmartens
ms.technology: vs-ide-deployment
ms.workload: 
  - multiple
---
# How to: Change the publish language for a ClickOnce application

When publishing a [!INCLUDE[ndptecclick](../deployment/includes/ndptecclick_md.md)] application, the user interface displayed during installation defaults to the language and culture of your development computer. If you are publishing a localized application, you will need to specify a language and culture to match the localized version. This is determined by the `Publish language` property for your project.

The `Publish language` property can be set in the **Publish Options** dialog box, accessible from the **Publish** page of the **Project Designer**.

> [!NOTE]
> The dialog boxes and menu commands you see might differ from those described in Help depending on your active settings or edition. To change your settings, choose **Import and Export Settings** on the **Tools** menu. For more information, see [Reset settings](../ide/environment-settings.md#reset-settings).

## To change the publish language

1. With a project selected in **Solution Explorer**, on the **Project** menu, click **Properties**.

2. Click the **Publish** tab.

3. Click the **Options** button to open the **Publish Options** dialog box.

4. Click **Description**.

5. In the **Publish Options** dialog box, select a language and culture from the **Publish language** drop-down list, and then click **OK**.

## See also

- [Publish ClickOnce applications](../deployment/publishing-clickonce-applications.md)
- [How to: Publish a ClickOnce application using the Publish Wizard](../deployment/how-to-publish-a-clickonce-application-using-the-publish-wizard.md)