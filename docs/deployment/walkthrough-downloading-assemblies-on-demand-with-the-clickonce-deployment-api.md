---
title: "Walkthrough: Downloading Assemblies on Demand with the ClickOnce Deployment API | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-deployment"
ms.tgt_pltfrm: ""
ms.topic: "article"
dev_langs: 
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords: 
  - "assemblies, downloading [ClickOnce]"
  - "ClickOnce deployment, on-demand download"
  - "on-demand assemblies, ClickOnce"
ms.assetid: d20e2789-8621-4806-b5b7-841122da1456
caps.latest.revision: 16
author: "stevehoag"
ms.author: "shoag"
manager: "wpickett"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# Walkthrough: Downloading Assemblies on Demand with the ClickOnce Deployment API
By default, all of the assemblies included in a [!INCLUDE[ndptecclick](../deployment/includes/ndptecclick_md.md)] application are downloaded when the application is first run. However, you may have parts of your application that are used by a small set of your users. In this case, you want to download an assembly only when you create one of its types. The following walkthrough demonstrates how to mark certain assemblies in your application as "optional", and how to download them by using classes in the <xref:System.Deployment.Application> namespace when the common language runtime (CLR) demands them.  
  
> [!NOTE]
>  Your application will have to run in full trust to use this procedure.  
  
## Prerequisites  
 You will need one of the following components to complete this walkthrough:  
  
-   The Windows SDK. The Windows SDK can be downloaded from the Microsoft Download Center.  
  
-   Visual Studio.  
  
## Creating the Projects  
  
#### To create a project that uses an on-demand assembly  
  
1.  Create a directory named ClickOnceOnDemand.  
  
2.  Open the Windows SDK Command Prompt or the [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] Command Prompt.  
  
3.  Change to the ClickOnceOnDemand directory.  
  
4.  Generate a public/private key pair using the following command:  
  
    ```  
    sn -k TestKey.snk  
    ```  
  
5.  Using Notepad or another text editor, define a class named `DynamicClass` with a single property named `Message`.  
  
     [!code-vb[ClickOnceLibrary#1](../deployment/codesnippet/VisualBasic/walkthrough-downloading-assemblies-on-demand-with-the-clickonce-deployment-api_1.vb)]
     [!code-cs[ClickOnceLibrary#1](../deployment/codesnippet/CSharp/walkthrough-downloading-assemblies-on-demand-with-the-clickonce-deployment-api_1.cs)]  
  
6.  Save the text as a file named `ClickOnceLibrary.cs` or `ClickOnceLibrary.vb`, depending on the language you use, to the ClickOnceOnDemand directory.  
  
7.  Compile the file into an assembly.  
  
    ```c#  
    csc /target:library /keyfile:TestKey.snk ClickOnceLibrary.cs  
    ```  
  
    ```vb#  
    vbc /target:library /keyfile:TestKey.snk ClickOnceLibrary.vb  
    ```  
  
8.  To get the public key token for the assembly, use the following command:  
  
    ```  
    sn -T ClickOnceLibrary.dll  
    ```  
  
9. Create a new file using your text editor and enter the following code. This code creates a Windows Forms application that downloads the ClickOnceLibrary assembly when it is required.  
  
     [!code-cs[ClickOnceOnDemandCmdLine#1](../deployment/codesnippet/CSharp/walkthrough-downloading-assemblies-on-demand-with-the-clickonce-deployment-api_2.cs)]
     [!code-vb[ClickOnceOnDemandCmdLine#1](../deployment/codesnippet/VisualBasic/walkthrough-downloading-assemblies-on-demand-with-the-clickonce-deployment-api_2.vb)]  
  
10. In the code, locate the call to <xref:System.Reflection.Assembly.LoadFile%2A>.  
  
11. Set`PublicKeyToken` to the value that you retrieved earlier.  
  
12. Save the file as either `Form1.cs` or `Form1.vb`.  
  
13. Compile it into an executable using the following command.  
  
    ```c#  
    csc /target:exe /reference:ClickOnceLibrary.dll Form1.cs  
    ```  
  
    ```vb#  
    vbc /target:exe /reference:ClickOnceLibrary.dll Form1.vb  
    ```  
  
## Marking Assemblies as Optional  
  
#### To mark assemblies as optional in your ClickOnce application by using MageUI.exe  
  
1.  Using MageUI.exe, create an application manifest as described in [Walkthrough: Manually Deploying a ClickOnce Application](../deployment/walkthrough-manually-deploying-a-clickonce-application.md). Use the following settings for the application manifest:  
  
    -   Name the application manifest `ClickOnceOnDemand`.  
  
    -   On the **Files** page, in the ClickOnceLibrary.dll row, set the **File Type** column to **None**.  
  
    -   On the **Files** page, in the ClickOnceLibrary.dll row, type `ClickOnceLibrary.dll` in the **Group** column.  
  
2.  Using MageUI.exe, create a deployment manifest as described in [Walkthrough: Manually Deploying a ClickOnce Application](../deployment/walkthrough-manually-deploying-a-clickonce-application.md). Use the following settings for the deployment manifest:  
  
    -   Name the deployment manifest `ClickOnceOnDemand`.  
  
## Testing the New Assembly  
  
#### To test your on-demand assembly  
  
1.  Upload your [!INCLUDE[ndptecclick](../deployment/includes/ndptecclick_md.md)] deployment to a Web server.  
  
2.  Start your application deployed with [!INCLUDE[ndptecclick](../deployment/includes/ndptecclick_md.md)] from a Web browser by entering the URL to the deployment manifest. If you call your [!INCLUDE[ndptecclick](../deployment/includes/ndptecclick_md.md)] application `ClickOnceOnDemand`, and you upload it to the root directory of adatum.com, your URL would look like this:  
  
    ```  
    http://www.adatum.com/ClickOnceOnDemand/ClickOnceOnDemand.application  
    ```  
  
3.  When your main form appears, press the <xref:System.Windows.Forms.Button>. You should see a string in a message box window that reads "Hello, World!".  
  
## See Also  
 <xref:System.Deployment.Application.ApplicationDeployment>