---
title: Add an app.config file to a project
description: Learn how to add an app.config file to a C# project so you can customize how the common language runtime locates and loads assembly files.
ms.date: 10/28/2024
ms.topic: how-to
dev_langs:
- CSharp
helpviewer_keywords:
- app.config files, adding to C# projects
author: anandmeg
ms.author: meghaanand
manager: mijacobs
ms.subservice: general-ide
#customer intent:  As a developer, I want to know how to add an application configuration file to my projects so that I can customize how the common language runtime locates and loads assembly files.
---
# Add an application configuration file to a C# project

By adding an application configuration file (*app.config* file) to a C# project, you can customize how the common language runtime locates and loads assembly files. When you build your project, the development environment automatically copies your *app.config* file, changes the file name of the copy to match your executable, and then moves the copy to the *bin* directory.

> [!NOTE]
> UWP apps don't contain an *app.config* file.

To add an application configuration file to a C# project:

1. In **Solution Explorer**, right-click the project node, and then select **Add** > **New Item**.

     The **Add New Item** dialog box appears.

1. Expand **Installed** > **C# Items**.

1. In the middle pane, select the **Application Configuration File** template.

     :::image type="content" source="media/vs-2022/application-configuration-file.png" alt-text="Screenshot of the Application Configuration File item in the Add New Item dialog.":::

1. Select the **Add** button.

     A file named *App.config* is added to your project.
    
     :::image type="content" source="media/vs-2022/app-config-file-csharp-project.png" alt-text="Screenshot of the App dot config file added to your project.":::

For more information about application configuration files or about assemblies in .NET, see [How the runtime locates assemblies (.NET Framework)](/dotnet/framework/deployment/how-the-runtime-locates-assemblies) and [Assemblies in .NET](/dotnet/standard/assembly/). To learn how to read application settings from an app.config file in .NET Framework, see [How to: Read application settings](/dotnet/framework/configure-apps/read-app-settings).

## Related content

- [Manage application settings (.NET)](../ide/managing-application-settings-dotnet.md)
- [Configuration file schema (.NET Framework)](/dotnet/framework/configure-apps/file-schema/index)
- [Configure apps (.NET Framework)](/dotnet/framework/configure-apps/index)
