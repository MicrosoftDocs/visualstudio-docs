---
title: Locate templates
description: Learn how to locate and organize project and item templates.
ms.date: 11/15/2022
ms.topic: how-to
helpviewer_keywords:
- project templates [Visual Studio], locations
- item templates [Visual Studio], locations
- template locations [Visual Studio]
author: TerryGLee
ms.author: tglee
manager: jmartens
ms.technology: vs-ide-general
---
# How to: Locate and organize project and item templates

 [!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]

Template files must be placed in a known location in order for them to be shown in the new project and new item dialog boxes..

## Locate templates

Installed templates and user templates are stored in two different locations.

### Installed templates

By default, templates installed with Visual Studio are located in:

::: moniker range="vs-2019"

- *%ProgramFiles(x86)%\\Microsoft Visual Studio\\2019\\\<edition>\\Common7\IDE\ProjectTemplates\\<Language\>\\<Locale ID\>*

- *%ProgramFiles(x86)%\\Microsoft Visual Studio\\2019\\\<edition>\Common7\IDE\ItemTemplates\\<Language\>\\<Locale ID\>*

For example, the following directory has the Visual Basic item templates for English (LCID 1033):

*C:\\Program Files (x86)\\Microsoft Visual Studio\\2019\\Community\\Common7\\IDE\\ItemTemplates\\VisualBasic\\1033*

::: moniker-end

::: moniker range="vs-2022"

- *%ProgramFiles%\\Microsoft Visual Studio\\2022\\\<edition>\\Common7\IDE\ProjectTemplates\\<Language\>\\<Locale ID\>*

- *%ProgramFiles%\\Microsoft Visual Studio\\2022\\\<edition>\Common7\IDE\ItemTemplates\\<Language\>\\<Locale ID\>*

For example, the following directory has the Visual Basic item templates for English (LCID 1033):

*C:\\Program Files\\Microsoft Visual Studio\\2022\\Community\\Common7\\IDE\\ItemTemplates\\VisualBasic\\1033*

::: moniker-end

### User templates

If you add a compressed (*.zip*) file that includes a *.vstemplate* file to the user template directory, the template appears in the new project and new item dialog boxes. By default, user templates are located in:

::: moniker range="vs-2019"

- *%USERPROFILE%\Documents\Visual Studio 2019\Templates\ProjectTemplates*

- *%USERPROFILE%\Documents\Visual Studio 2019\Templates\ItemTemplates*

For example, the following directory has user project templates for C#:

- *C:\Users\UserName\Documents\Visual Studio 2019\Templates\ProjectTemplates\Visual C#*

::: moniker-end

::: moniker range="vs-2022"

- *%USERPROFILE%\Documents\Visual Studio 2022\Templates\ProjectTemplates*

- *%USERPROFILE%\Documents\Visual Studio 2022\Templates\ItemTemplates*

For example, the following directory has user project templates for C#:

- *C:\Users\UserName\Documents\Visual Studio 2022\Templates\ProjectTemplates\Visual C#*

::: moniker-end

> [!TIP]
> You can change the known location for user templates in **Tools** > **Options** > **Projects and Solutions** > **Locations**.

## Next steps

To learn more about .NET SDK templates and their locations, reference the following articles.

|Article  |Description  |
|---------|---------|
|[.NET default templates](/dotnet/core/tools/dotnet-new-sdk-templates) | When you install the .NET SDK, you receive over a dozen built-in templates for creating projects and files, including console apps, class libraries, unit test projects, ASP.NET Core apps (including Angular and React projects), and configuration files.  This article lists the templates that come pre-installed with the .NET SDK and describes how to interact with them. |
|[Manage .NET project and item templates](/dotnet/core/install/templates?pivots=os-windows&preserve-view=true) | .NET provides a template system that enables users to install or uninstall packages containing templates from NuGet, a NuGet package file, or a file system directory. This article describes how to manage .NET templates through the .NET SDK CLI. |

## See also

- [Visual Studio template schema reference (extensibility)](../extensibility/visual-studio-template-schema-reference.md)
