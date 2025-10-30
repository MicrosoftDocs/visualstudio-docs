---
title: Create custom installer for ClickOnce application
description: Explore the process for a custom installer to silently install and update a ClickOnce application based on an .exe file. 
ms.date: "11/04/2016"
ms.topic: how-to
dev_langs:
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords:
  - "ClickOnce deployment, custom installer"
  - "installer [ClickOnce], custom"
  - "deploying applications [ClickOnce], custom installer"
  - "InPlaceHostingManager [ClickOnce], custom installer"
  - "custom installer [ClickOnce]"
author: mikejo5000
ms.author: mikejo
manager: mijacobs
ms.subservice: deployment
---
# Walkthrough: Create a custom installer for a ClickOnce application

Any ClickOnce application based on an *.exe* file can be silently installed and updated by a custom installer. A custom installer can implement custom user experience during installation, including custom dialog boxes for security and maintenance operations. To perform installation operations, the custom installer uses the <xref:System.Deployment.Application.InPlaceHostingManager> class. This walkthrough demonstrates how to create a custom installer that silently installs a ClickOnce application.

 [!INCLUDE[ndptecclick](../deployment/includes/dotnet-support-application-deployment-api.md)]

## Prerequisites

### To create a custom ClickOnce application installer

1. In your ClickOnce application, add references to System.Deployment and System.Windows.Forms.

2. Add a new class to your application and specify any name. This walkthrough uses the name `MyInstaller`.

3. Add the following `Imports` or `using` directives to the top of your new class.

    ### [C#](#tab/csharp)
    ```csharp
    using System.Deployment.Application;
    using System.Windows.Forms;
    ```

    ### [VB](#tab/vb)
    ```vb
    Imports System.Deployment.Application
    Imports System.Windows.Forms
    ```
    ---

4. Add the following methods to your class.

     These methods call <xref:System.Deployment.Application.InPlaceHostingManager> methods to download the deployment manifest, assert appropriate permissions, ask the user for permission to install, and then download and install the application into the ClickOnce cache. A custom installer can specify that a ClickOnce application is pre-trusted, or can defer the trust decision to the <xref:System.Deployment.Application.InPlaceHostingManager.AssertApplicationRequirements%2A> method call. This code pre-trusts the application.

    > [!NOTE]
    > Permissions assigned by pre-trusting cannot exceed the permissions of the custom installer code.

    ### [C#](#tab/csharp)
    :::code language="csharp" source="../snippets/csharp/VS_Snippets_Winforms/System.Deployment.Application.InPlaceHostingManager/CS/Form1.cs" id="Snippet1":::

    ### [VB](#tab/vb)
    :::code language="vb" source="../snippets/visualbasic/VS_Snippets_Winforms/System.Deployment.Application.InPlaceHostingManager/VB/Form1.vb" id="Snippet1":::
    ---

5. To attempt installation from your code, call the `InstallApplication` method. For example, if you named your class `MyInstaller`, you might call `InstallApplication` in the following way.

    ### [C#](#tab/csharp)
    ```csharp
    MyInstaller installer = new MyInstaller();
    installer.InstallApplication(@"\\myServer\myShare\myApp.application");
    MessageBox.Show("Installer object created.");
    ```

    ### [VB](#tab/vb)
    ```vb
    Dim installer As New MyInstaller()
    installer.InstallApplication("\\myServer\myShare\myApp.application")
    MessageBox.Show("Installer object created.")
    ```
    ---

## Next steps
 A ClickOnce application can also add custom update logic, including a custom user interface to show during the update process. For more information, see <xref:System.Deployment.Application.UpdateCheckInfo>. A ClickOnce application can also suppress the standard Start menu entry, shortcut, and Add or Remove Programs entry by using a `<customUX>` element. For more information, see [\<entryPoint> element](../deployment/entrypoint-element-clickonce-application.md) and <xref:System.Deployment.Application.DownloadApplicationCompletedEventArgs.ShortcutAppId%2A>.

## Related content
- [ClickOnce application manifest](../deployment/clickonce-application-manifest.md)
- [\<entryPoint> element](../deployment/entrypoint-element-clickonce-application.md)
