---
title: How to add an app.config file to a project
description: Learn how to add an app.config file to a C# project so you can customize how the common language runtime locates and loads assembly files.
ms.custom: SEO-VS-2020
ms.date: 01/17/2023
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

 [!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]

By adding an application configuration file (*app.config* file) to a C# project, you can customize how the common language runtime locates and loads assembly files. For more information about application configuration files or about assemblies in .NET, see [How the runtime locates assemblies (.NET Framework)](/dotnet/framework/deployment/how-the-runtime-locates-assemblies) and [Assemblies in .NET](/dotnet/standard/assembly/).

> [!NOTE]
> UWP apps don't contain an *app.config* file.

When you build your project, the development environment automatically copies your *app.config* file, changes the file name of the copy to match your executable, and then moves the copy to the **bin** directory.

## To add an application configuration file to a C# project

1. In **Solution Explorer**, right-click the project node, and then select **Add** > **New Item**.

     The **Add New Item** dialog box appears.

1. Expand **Installed** > **Visual C# Items**.

1. In the middle pane, select the **Application Configuration File** template.

1. Select the **Add** button.

     A file named *App.config* is added to your project.

## See also

- [Manage application settings (.NET)](../ide/managing-application-settings-dotnet.md)
- [Configuration file schema (.NET Framework)](/dotnet/framework/configure-apps/file-schema/index)
- [Configure apps (.NET Framework)](/dotnet/framework/configure-apps/index)
