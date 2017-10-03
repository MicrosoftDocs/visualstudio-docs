---
title: "How to: Add an Application Configuration File to a C# Project | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-general"
ms.tgt_pltfrm: ""
ms.topic: "article"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "app.config files, adding to C# projects"
ms.assetid: 9caf6bb0-c2fc-4ab6-ba69-bed3b880fbf8
caps.latest.revision: 20
author: "gewarren"
ms.author: "gewarren"
manager: "ghogen"
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
# How to: Add an Application Configuration File to a C# Project
By adding an application configuration file (app.config file) to a C# project, you can customize how the common language runtime locates and loads assembly files. For more information about application configuration files, see [How the Runtime Locates Assemblies](/dotnet/framework/deployment/how-the-runtime-locates-assemblies).  
  
> [!NOTE]
>  The Windows Store doesn't support <xref:System.Configuration>. As a result, Store apps don't contain an app.config template.  
  
 When you build your project, the development environment automatically copies your app.config file, changes the file name of the copy to match your executable, and then moves the copy to the bin directory.  
  
### To add an application configuration file to your C# project  
  
1.  On the menu bar, choose **Project**, **Add New Item**.  
  
     The **Add New Item** dialog box appears.  
  
2.  Expand **Installed**, expand **Visual C# Items**, and then choose the **Application Configuration File** template.  
  
3.  In the **Name** text box, enter a name, and then choose the **Add** button.  
  
     A file that's named app.config is added to your project.  
  
## See Also  
 [Managing Application Settings (.NET)](../ide/managing-application-settings-dotnet.md)   
 [Configuration File Schema](/dotnet/framework/configure-apps/file-schema/index)   
 [Configuring Apps](/dotnet/framework/configure-apps/index)   
 [How to: Configure an App to Target a .NET Framework Version](http://msdn.microsoft.com/en-us/5247b307-89ca-417b-8dd0-e8f9bd2f4717)   
 [Using the Visual Studio Development Environment for C#](../csharp-ide/using-the-visual-studio-development-environment-for-csharp.md)