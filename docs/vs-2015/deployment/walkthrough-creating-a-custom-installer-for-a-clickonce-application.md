---
title: "Walkthrough: Creating a Custom Installer for a ClickOnce Application | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-deployment"
ms.topic: conceptual
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
ms.assetid: fb222cc5-8aeb-4b94-8c49-b93e342f5f69
caps.latest.revision: 36
author: mikejo5000
ms.author: mikejo
manager: jillfra
---
# Walkthrough: Creating a Custom Installer for a ClickOnce Application
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Any ClickOnce application based on an .exe file can be silently installed and updated by a custom installer. A custom installer can implement custom user experience during installation, including custom dialog boxes for security and maintenance operations. To perform installation operations, the custom installer uses the <xref:System.Deployment.Application.InPlaceHostingManager> class. This walkthrough demonstrates how to create a custom installer that silently installs a ClickOnce application.  
  
## Prerequisites  
  
### To create a custom ClickOnce application installer  
  
1. In your ClickOnce application, add references to System.Deployment and System.Windows.Forms.  
  
2. Add a new class to your application and specify any name. This walkthrough uses the name `MyInstaller`.  
  
3. Add the following `Imports` or `using` statements to the top of your new class.  
  
    ```vb  
    Imports System.Deployment.Application  
    Imports System.Windows.Forms  
    ```  
  
    ```csharp  
    using System.Deployment.Application;  
    using System.Windows.Forms;  
    ```  
  
4. Add the following methods to your class.  
  
     These methods call <xref:System.Deployment.Application.InPlaceHostingManager> methods to download the deployment manifest, assert appropriate permissions, ask the user for permission to install, and then download and install the application into the ClickOnce cache. A custom installer can specify that a ClickOnce application is pre-trusted, or can defer the trust decision to the <xref:System.Deployment.Application.InPlaceHostingManager.AssertApplicationRequirements%2A> method call. This code pre-trusts the application.  
  
    > [!NOTE]
    > Permissions assigned by pre-trusting cannot exceed the permissions of the custom installer code.  
  
     [!code-csharp[System.Deployment.Application.InPlaceHostingManager#1](../snippets/csharp/VS_Snippets_Winforms/System.Deployment.Application.InPlaceHostingManager/CS/Form1.cs#1)]
     [!code-vb[System.Deployment.Application.InPlaceHostingManager#1](../snippets/visualbasic/VS_Snippets_Winforms/System.Deployment.Application.InPlaceHostingManager/VB/Form1.vb#1)]  
  
5. To attempt installation from your code, call the `InstallApplication` method. For example, if you named your class `MyInstaller`, you might call `InstallApplication` in the following way.  
  
    ```vb  
    Dim installer As New MyInstaller()  
    installer.InstallApplication("\\myServer\myShare\myApp.application")  
    MessageBox.Show("Installer object created.")  
    ```  
  
    ```csharp  
    MyInstaller installer = new MyInstaller();  
    installer.InstallApplication(@"\\myServer\myShare\myApp.application");  
    MessageBox.Show("Installer object created.");  
    ```  
  
## Next Steps  
 A ClickOnce application can also add custom update logic, including a custom user interface to show during the update process. For more information, see <xref:System.Deployment.Application.UpdateCheckInfo>. A ClickOnce application can also suppress the standard Start menu entry, shortcut, and Add or Remove Programs entry by using a `<customUX>` element. For more information, see [\<entryPoint> Element](../deployment/entrypoint-element-clickonce-application.md) and <xref:System.Deployment.Application.DownloadApplicationCompletedEventArgs.ShortcutAppId%2A>.  
  
## See Also  
 [ClickOnce Application Manifest](../deployment/clickonce-application-manifest.md)   
 [\<entryPoint> Element](../deployment/entrypoint-element-clickonce-application.md)
