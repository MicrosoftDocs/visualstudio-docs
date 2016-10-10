---
title: "ClickOnce Deployment on Windows Vista"
ms.custom: na
ms.date: 10/10/2016
ms.devlang: 
  - VB
  - CSharp
  - C++
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-deployment
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: b21a0ebc-0ff6-4f49-8993-7d1ad3f8cac2
caps.latest.revision: 12
manager: wpickett
translation.priority.ht: 
  - cs-cz
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - pl-pl
  - pt-br
  - ru-ru
  - tr-tr
  - zh-cn
  - zh-tw
---
# ClickOnce Deployment on Windows Vista
Building applications in Visual Studio for User Account Control (UAC) on Windows Vista normally generates an embedded manifest, encoded as binary XML data in the application's executable file. Because ClickOnce and Registration-Free COM applications require an external manifest, Visual Studio generates a file for these types of projects containing the UAC data instead of an embedded manifest. By default, Visual Studio uses information from a file called app.manifest to generate external UAC manifest information (for ClickOnce and Registration-Free COM deployment), or to embed it in the application's executable file (for all other cases). Visual Studio provides the following options for manifest generation:  
  
-   Use an embedded manifest. Embed UAC data in the application's executable file and run as normal user.  
  
     This is the default setting (unless you use ClickOnce). This setting will support the usual manner in which Visual Studio operates on Windows Vista; that is, the generation of an internal and external manifest, both using `AsInvoker`.  
  
-   Use an external manifest. Generate an external manifest by using app.manifest.  
  
     This generates only the external manifest by using the information in app.manifest. When you publish an application by using ClickOnce or Registration-Free COM, Visual Studio adds app.manifest to the project and adds this option.  
  
-   Use no manifest. Create the application without a manifest.  
  
     This approach is also known as *virtualization*. Use this option for compatibility with existing applications from earlier versions of Visual Studio.  
  
 The new properties are available on the **Application** page of the Project Designer (for Visual C# projects only) and in the MSBuild project file format.  
  
 Note that the method for configuring UAC manifest generation in the Visual Studio IDE differs depending on project type (Visual C# and Visual Basic).  
  
 For information about configuring Visual C# projects for manifest generation, see [Application Page, Project Designer (C#)](../VS_IDE/Application-Page--Project-Designer--C#-.md).  
  
 For information about configuring Visual Basic projects for manifest generation, see [Application Page, Project Designer (Visual Basic)](../VS_IDE/Application-Page--Project-Designer--Visual-Basic-.md).  
  
## See Also  
 [ClickOnce Security and Deployment](../VS_IDE/ClickOnce-Security-and-Deployment.md)   
 [User Permissions and Visual Studio](assetId:///d5c55084-1e7b-4b61-b478-137db01c0fc0)   
 [Application Page, Project Designer (C#)](../VS_IDE/Application-Page--Project-Designer--C#-.md)   
 [Application Page, Project Designer (Visual Basic)](../VS_IDE/Application-Page--Project-Designer--Visual-Basic-.md)