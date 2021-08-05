---
title: Install prerequisites with a ClickOnce app
description: Learn how to select prerequisite components to be packaged along with your ClickOnce application when it is installed.
ms.custom: SEO-VS-2020
ms.date: 11/04/2016
ms.topic: how-to
dev_langs: 
  - VB
  - CSharp
  - C++
helpviewer_keywords: 
  - deploying applications [ClickOnce], prerequisites
  - prerequisites, ClickOnce
  - components, bootstrapping
ms.assetid: e964fca5-fdfd-47cf-a1c9-7fb96b1c88b5
author: mikejo5000
ms.author: mikejo
manager: jmartens
ms.technology: vs-ide-deployment
ms.workload: 
  - multiple
---
# How to: Install prerequisites with a ClickOnce application
All [!INCLUDE[ndptecclick](../deployment/includes/ndptecclick_md.md)] applications require that the correct version of the .NET Framework is installed on a computer before they can be run; many applications have other prerequisites as well. When publishing a [!INCLUDE[ndptecclick](../deployment/includes/ndptecclick_md.md)] application, you can choose a set of prerequisite components to be packaged along with your application. At installation time, a check will be performed for each prerequisite to determine if it already exists; if not it will be installed prior to installing the [!INCLUDE[ndptecclick](../deployment/includes/ndptecclick_md.md)] application.

 Instead of packaging and publishing prerequisites, you can also specify a download location for the components. For example, rather than including prerequisites with every application that you publish, you might use a centralized file share or Web location that contains the installers for all of your prerequisites—at install time, the components will be downloaded and installed from that location.

> [!IMPORTANT]
> You should add prerequisite installer packages to your development computer before you publish your first [!INCLUDE[ndptecclick](../deployment/includes/ndptecclick_md.md)] application. For more information, see [How to: Include Prerequisites with a ClickOnce Application](../deployment/how-to-include-prerequisites-with-a-clickonce-application.md).

 Prerequisites are managed in the **Prerequisites** dialog box, accessible from the **Publish** pane of the **Project Designer**.

> [!NOTE]
> In addition to the predetermined list of prerequisites, you can add your own components to the list. For more information, see [Creating bootstrapper packages](../deployment/creating-bootstrapper-packages.md).

### To specify prerequisites to install with a ClickOnce application

1. With a project selected in **Solution Explorer**, on the **Project** menu click **Properties**.

2. Select the **Publish** pane.

3. Click the **Prerequisites** button to open the **Prerequisites** dialog box.

4. In the **Prerequisites** dialog box, make sure that the **Create setup program to install prerequisite components** check box is selected.

5. In the **Prerequisites** list, check the components that you wish to install, and then click **OK**.

     The selected components will be packaged and published along with your application.

### To specify a different download location for prerequisites

1. With a project selected in **Solution Explorer**, on the **Project** menu click **Properties**.

2. Select the **Publish** pane.

3. Click the **Prerequisites** button to open the **Prerequisites** dialog box.

4. In the **Prerequisites** dialog box, make sure that the **Create setup program to install prerequisite components** check box is selected.

5. In the **Specify the install location for prerequisites** section, select **Download prerequisites from the following location**.

6. Select a location from the drop-down list, or enter a URL, file path, or FTP location, and then click **OK.**

    > [!NOTE]
    > You must make sure that installers for the specified components exist at the specified location.

## See also
- [Publish ClickOnce applications](../deployment/publishing-clickonce-applications.md)
- [How to: Publish a ClickOnce application using the Publish Wizard](../deployment/how-to-publish-a-clickonce-application-using-the-publish-wizard.md)