---
title: Set custom permissions (ClickOnce app)
description: Learn how to deploy a ClickOnce application that uses default permissions or create a custom zone for the specific permissions that the application needs.
ms.custom: SEO-VS-2020
ms.date: 11/04/2016
ms.topic: how-to
dev_langs: 
  - VB
  - CSharp
  - C++
helpviewer_keywords: 
  - ClickOnce applications, permissions
  - permissions, ClickOnce applications
ms.assetid: 660459ca-ef73-44a8-b323-610001f63b93
author: mikejo5000
ms.author: mikejo
manager: jmartens
ms.technology: vs-ide-deployment
ms.workload: 
  - multiple
---
# How to: Set custom permissions for a ClickOnce application
You can deploy a [!INCLUDE[ndptecclick](../deployment/includes/ndptecclick_md.md)] application that uses default permissions for the Internet or Local Intranet zones. Alternatively, you can create a custom zone for the specific permissions that the application needs. You can do this by customizing the security permissions on the **Security** page of the **Project Designer**.

### To customize a permission

1. With a project selected in **Solution Explorer**, on the **Project** menu, click **Properties**.

2. Click the **Security** tab.

3. Select the **Enable ClickOnce Security Settings** check box.

4. Select the **This is a partial trust application** option button.

     The controls in the **ClickOnce security permissions** section are enabled.

5. From the **Zone your application will be installed from** drop-down list, click **(Custom)**.

6. Click **Edit Permissions XML**.

     The *app.manifest* file opens in the XML Editor.

7. Before the `</applicationRequestMinimum>` element, add XML code for permissions that your application requires.

    > [!NOTE]
    > You can use the `ToXml` method of a permission set to generate the XML code for the application manifest. For example, to generate the XML for the <xref:System.Security.Permissions.EnvironmentPermission> permission set, call the <xref:System.Security.Permissions.EnvironmentPermission.ToXml%2A> method.

## See also
- [Secure ClickOnce Applications](../deployment/securing-clickonce-applications.md)
- [Code access security for ClickOnce applications](../deployment/code-access-security-for-clickonce-applications.md)
