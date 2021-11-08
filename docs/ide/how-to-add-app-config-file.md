---
title: How to add an app.config file to a project
description: Learn how to add an app.config file to a C# project so you can customize how the common language runtime locates and loads assembly files.
ms.custom: SEO-VS-2020
ms.date: 11/20/2020
ms.topic: how-to
dev_langs:
- CSharp
helpviewer_keywords:
- app.config files, adding to C# projects
author: TerryGLee
ms.author: tglee
manager: jmartens
ms.technology: vs-ide-general
ms.workload:
- dotnet
---
# How to: Add an application configuration file to a C# project

By adding an application configuration file (*app.config* file) to a C# project, you can customize how the common language runtime locates and loads assembly files. For more information about application configuration files, see [How the runtime locates assemblies (.NET Framework)](/dotnet/framework/deployment/how-the-runtime-locates-assemblies).

> [!NOTE]
> UWP apps don't contain an *app.config* file.

When you build your project, the development environment automatically copies your *app.config* file, changes the file name of the copy to match your executable, and then moves the copy to the **bin** directory.

## To add an application configuration file to a C# project

1. On the menu bar, choose **Project** > **Add New Item**.

     The **Add New Item** dialog box appears.

1. Expand **Installed** > **Visual C# Items**, and then choose the **Application Configuration File** template.

1. In the **Name** text box, enter a name, and then choose the **Add** button.

     A file named *app.config* is added to your project.

## See also

- [Manage application settings (.NET)](../ide/managing-application-settings-dotnet.md)
- [Configuration file schema (.NET Framework)](/dotnet/framework/configure-apps/file-schema/index)
- [Configure apps (.NET Framework)](/dotnet/framework/configure-apps/index)
