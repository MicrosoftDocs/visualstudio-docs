---
title: "How to add an app.config file to a project in Visual Studio | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.reviewer: ""
ms.suite: ""
ms.technology: vs-ide-general
ms.tgt_pltfrm: ""
ms.topic: "article"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "app.config files, adding to C# projects"
author: "gewarren"
ms.author: "gewarren"
manager: ghogen
ms.workload: 
  - "dotnet"
---
# How to: Add an Application Configuration File to a C# Project

By adding an application configuration file (app.config file) to a C# project, you can customize how the common language runtime locates and loads assembly files. For more information about application configuration files, see [How the Runtime locates assemblies (.NET Framework)](/dotnet/framework/deployment/how-the-runtime-locates-assemblies).

> [!NOTE]
> UWP apps don't contain an app.config file.

When you build your project, the development environment automatically copies your app.config file, changes the file name of the copy to match your executable, and then moves the copy to the **bin** directory.

## To add an application configuration file to a C# project

1. On the menu bar, choose **Project** > **Add New Item**.

     The **Add New Item** dialog box appears.

1. Expand **Installed** > **Visual C# Items**, and then choose the **Application Configuration File** template.

3.In the **Name** text box, enter a name, and then choose the **Add** button.

     A file named app.config is added to your project.

## See also

[Managing Application Settings (.NET)](../ide/managing-application-settings-dotnet.md)  
[Configuration File Schema (.NET Framework)](/dotnet/framework/configure-apps/file-schema/index)  
[Configuring Apps (.NET Framework)](/dotnet/framework/configure-apps/index)