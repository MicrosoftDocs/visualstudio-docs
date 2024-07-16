---
title: Manage application resources
description: Manage application resources files that aren't part of the compilation process in Visual Studio, such as icon files or audio files.
ms.custom: engagement-fy23
ms.date: 7/16/2024
ms.topic: conceptual
f1_keywords:
- msvse_resedit.dlg.SetCustomTool
helpviewer_keywords:
- Resource Designer
- Resource Editor
- Resource View
- resources [Visual Studio]
- Resources page in Project Designer
- application resources [Visual Studio]
author: anandmeg
ms.author: meghaanand
manager: mijacobs
ms.subservice: general-ide
---
# Manage application resources

Resource files are files that are part of an application but are not compiled, for example icon files or audio files. Since these files are not part of the compilation process, you can change them without having to recompile your binaries. If you are planning to localize your application, you should use resource files for all the strings and other resources that need to be changed when you localize your application.

> [!NOTE]
> This topic applies to Visual Studio on Windows. For Visual Studio for Mac, see [Managing app resources (Visual Studio for Mac)](/visualstudio/mac/managing-app-resources).

For more information about resources in .NET apps, see [Resources in .NET apps](/dotnet/framework/resources/index).

## Work with resources

In a managed code project, open the project properties window. You can open the properties window by either:

- Right-clicking the project node in **Solution Explorer** and selecting **Properties**
- Typing **project properties** in the **Ctrl**+**Q** search box
- Pressing **Alt**+**Enter** in **Solution Explorer**

Select the **Resources** tab. You can add a *.resx* file if your project does not contain one already, add and delete different kinds of resources, and modify existing resources.

## Resources in other project types

Resources are managed differently in .NET projects than in other project types. For more information about resources in:

- Universal Windows Platform (UWP) apps, see [App resources and the Resource Management System](/windows/uwp/app-resources/)
- C++/CLI (managed) projects, see [Resources in Desktop Apps](/dotnet/framework/resources/index)
- C++ projects, see [Work with resource files](/cpp/windows/working-with-resource-files) and [How to: Create a resource](/cpp/windows/how-to-create-a-resource)
    - Use the **Resource View** window (**View** > **Other Windows** > **Resource View**) to display resource files included in your projects.

## Support options

If you run into a problem with managing application resources, see [Troubleshoot errors in the Resource Editor](troubleshoot-resource-editor-errors.md).

## Related content

- [Resources in .NET apps (.NET Framework)](/dotnet/framework/resources/index)
- [Resource Editor](/cpp/windows/resource-editors)
- [Work with resource files (C++)](/cpp/windows/working-with-resource-files)
- [Resources in Universal Windows Platform apps](/windows/uwp/app-resources/)
